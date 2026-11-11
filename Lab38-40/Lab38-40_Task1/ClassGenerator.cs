using System;
using System.Collections.Generic;

namespace Lab38_40_Task1
{
    /// <summary>
    /// Генерує код простого класу мовою C#.
    /// </summary>
    public class ClassGenerator
    {
        private readonly string _className;
        private readonly List<Field> _fields = new();

        public ClassGenerator(string className)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(className);
            _className = className;
        } 

        public ClassGenerator AddField(string name, string type)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            ArgumentException.ThrowIfNullOrWhiteSpace(type);

            _fields.Add(new Field(name, type));

            return this;
        }

        public ClassDescription Build()
        {
            ClassDescription classDescription = new ClassDescription(_className);

            foreach (Field field in _fields)
                classDescription.AddField(field);


            return classDescription;
        }

        public override string ToString()
        {
            return Build().ToString();
        }
    }
}