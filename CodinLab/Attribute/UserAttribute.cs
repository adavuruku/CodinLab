using System;

namespace CodinLab.Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] //TO DEFINE Where the attribute class will be use, this can be applied to class and method
    public class UserAttribute:System.Attribute
    {
        public string _terms { get; set; }
        public UserAttribute(string terms)
        {
            _terms = terms;
        }
        
        
    }
}