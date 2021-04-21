using System;
using System.Collections.Generic;
using System.Reflection;
namespace exercicio1
{
    class Equality : IEquality
    {
        private List<PropertyInfo> properties = new List<PropertyInfo>();
        Type entity;
        public Equality(Type entity, params string[] props)
        {
            PropertyInfo property;
            foreach (string prop in props)
            {
                if((property = entity.GetProperty(prop)) != null)
                    properties.Add(property);
            }
            this.entity = entity;
        }

        public bool AreEqual(object x, object y){
            if (!(x.GetType() == entity && y.GetType() == entity)) return false;
            foreach (PropertyInfo property in properties)
            {
                if(!(property.GetValue(x).Equals(property.GetValue(y))))
                    return false;
            }
            return true;
        }

    }

}

