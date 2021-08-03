using System;
using System.Reflection;
using CodinLab.Attribute;

namespace CodinLab
{
    class ProgramAttribute
    {
        static void Mainy(string[] args)
        {
            AttributeUsage testClass = new AttributeUsage();
            Type type = testClass.GetType();
            foreach (MethodInfo mInfo in type.GetMethods())
            {
                Console.WriteLine(mInfo);
                foreach (System.Attribute attr in
                    System.Attribute.GetCustomAttributes(mInfo))
                {
                   // Console.WriteLine("No man =>"+attr.GetType());
                    if (attr.GetType() == typeof(UserAttribute))
                        Console.WriteLine(
                            "Method {0} has a pet {1} attribute.",
                            mInfo.Name, ((UserAttribute)attr)._terms);
                }
            }

           // Console.WriteLine("Hello World!");
        }
    }
}