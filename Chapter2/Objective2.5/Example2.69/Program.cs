using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example2._69
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly pluginAssembly = Assembly.Load("Your assembly name");
            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            foreach (Type pluginType in plugins)
            {
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
            }
        }
    }

    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(Program application);
    }

    public class MyPlugin : IPlugin
    {
        public string Name
        {
            get { return "MyPlugin"; }
        }

        public string Description
        {
            get { return "My Sample Plugin"; }
        }

        public bool Load(Program application)
        {
            return true;
        }
    }

}
