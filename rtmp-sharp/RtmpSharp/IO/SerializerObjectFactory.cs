﻿using Complete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RtmpSharp.IO
{
    class SerializerObjectFactory
    {
        // load serializable types within this library
        static readonly Type[] BaseSerializableTypes = typeof(SerializerObjectFactory).Assembly
            .GetTypes()
            .Where(x => x.GetCustomAttributes<SerializedNameAttribute>().Any())
            .ToArray();

        readonly Dictionary<Type, MethodFactory.ConstructorCall> constructors = new Dictionary<Type, MethodFactory.ConstructorCall>();
        readonly Dictionary<string, Type> remoteToLocalNames = new Dictionary<string, Type>();
        readonly Dictionary<string, string> localToRemoteNames = new Dictionary<string, string>();



        public SerializerObjectFactory()
        {
            foreach (var type in BaseSerializableTypes)
                Register(type);
        }



        public object Create(Type type) => constructors[type](new object[0]);
        public object Create(string typeName) => Create(remoteToLocalNames[typeName]);


        // Add the type to the list of creatable types
        public void Register(Type type)
        {
            if (type.IsEnum || constructors.ContainsKey(type))
                return;

            var constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Length == 0);
            if (constructor == null)
                throw new ArgumentException($"{type.FullName} does not have any accessible parameterless constructors.", nameof(type));

            constructors[type] = MethodFactory.CompileObjectConstructor(constructor);

            var attributes = type.GetCustomAttributes<SerializedNameAttribute>(false).ToArray();
            if (attributes.Length == 0)
            {
                remoteToLocalNames[type.FullName] = type;
            }
            else if (attributes.Count(x => x.Canonical) == 1)
            {
                foreach (var attribute in attributes)
                    RegisterAlias(type, attribute.SerializedName, attribute.Canonical);
            }
            else
            {
                throw new ArgumentException(
                    $"{type.FullName} has {attributes.Count(x => x.Canonical)} candidate names marked as canonical. only one can be canonical.",
                    nameof(type));
            }
        }

        public void RegisterAlias(Type type, string alias, bool canonical)
        {
            remoteToLocalNames[alias] = type;
            if (canonical)
                localToRemoteNames[type.FullName] = alias;
        }

        public string GetAlias(string typeName)
        {
            string mappedTypeName;
            return localToRemoteNames.TryGetValue(typeName, out mappedTypeName) ? mappedTypeName : typeName;
        }

        public bool CanCreate(Type type)
        {
            return constructors.ContainsKey(type);
        }

        public bool CanCreate(string typeName)
        {
            Type type;
            if (remoteToLocalNames.TryGetValue(typeName, out type))
                return CanCreate(type);
            return false;
        }
    }
}