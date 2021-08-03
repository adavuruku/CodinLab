using System;

namespace CodinLab.Attribute
{
    public class AttributeUsage
    {
        [User("Sherif")]
        public void displaySherif()
        {
            
        }
        
        [User("Abdul")]
        public void displayAbdul()
        {
           // Console.WriteLine(UserAttribute.GetCustomAttribute(displayAbdul()));
        }

        public void HelloWorld()
        {
            
        }
    }
}