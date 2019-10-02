using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Plugin;

namespace PDFMerger
{
    //Follow the Single Responsibility Principle(SR), there can only be one instance of the plugin-loader
    public static class PluginLoader
    {
        // The LoadPlugins load from the given filepath and read each DLL inside the folder
        // The LoadPlugin first reads the assemblue of each DLL. The next action is to create a class for each type in the plugin
        // for is to get a collection of each type from the plugin then you create an instance of the type and add it to the 'plugins' collection to be returned
        public static ICollection<IPlugin> LoadPlugin(string path)
        {
            string[] dllFileNames = null;
            if (Directory.Exists(path))
            {
                dllFileNames = Directory.GetFiles(path, "*.dll");
                ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
                foreach (var dllFileName in dllFileNames)
                {
                    AssemblyName assemblyName = AssemblyName.GetAssemblyName(dllFileName);
                    Assembly assembly = Assembly.Load(assemblyName);
                    assemblies.Add(assembly);
                }

                Type pluginType = typeof(IPlugin);
                ICollection<Type> pluginTypes = new List<Type>();
                foreach (var assembly in assemblies)
                {
                    if (assembly != null)
                    {
                        Type[] types = assembly.GetTypes();
                        foreach (Type type in types)
                        {
                            if (type.IsInterface || type.IsAbstract)
                            {
                                continue;
                            }
                            else
                            {
                                if (type.GetInterface(pluginType.FullName) != null)
                                {
                                    pluginTypes.Add(type);
                                }
                            }
                        }
                    }
                }

                ICollection<IPlugin> plugins = new List<IPlugin>(pluginTypes.Count);
                foreach (var type in pluginTypes)
                {
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                    plugins.Add(plugin);
                }

                return plugins;
            }

            return null;
        }
    }
}
