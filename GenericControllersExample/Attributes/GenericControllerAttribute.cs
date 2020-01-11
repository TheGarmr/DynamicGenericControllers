using System;

namespace GenericControllersExample.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class GenericControllerAttribute : Attribute
    {
        public GenericControllerAttribute(string route)
        {
            Route = route;
        }

        public string Route { get; set; }
    }
}
