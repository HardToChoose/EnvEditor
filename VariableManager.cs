using Microsoft.Win32;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;

namespace EnvEditor
{
    class VariableManager
    {
        /// <summary>
        /// System environmental variables that differ on diverse PC's
        /// </summary>
        private static readonly string[] PlatformSpecific =
        {
            "PROCESSOR_REVISION",
            "NUMBER_OF_PROCESSORS",
            "PROCESSOR_LEVEL",
            "PROCESSOR_ARCHITECTURE",
            "PROCESSOR_IDENTIFIER",
            "FP_NO_HOST_CHECK",
            "USERNAME",
            "OS"
        };


        /// <summary>
        /// Registry key containing current user environmant variables' values
        /// </summary>
        private RegistryKey userKey = Registry.CurrentUser.OpenSubKey("Environment", true);

        /// <summary>
        /// Registry key containing system-wide environment variables' values
        /// </summary>
        private RegistryKey systemKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Environment", true);

        #region Private methods

        private RegistryKey SelectKey(VariableType type)
        {
            switch (type)
            {
                case VariableType.User:       return userKey;
                case VariableType.System:     return systemKey;
            }

            Debug.Assert(false, "Invalid environment variable type");
            return null;
        }

        /// <summary>
        /// Exports specified environment variables to the XML document.
        /// </summary>
        /// <param name="variables">Environment variable names</param>
        /// <param name="source">Registry key containing the specified variables</param>
        /// <param name="doc">An XML document to save variable info into</param>
        /// <param name="parent">The parent node we add varible info to</param>
        private void Export(IEnumerable<string> variables, RegistryKey source, XmlDocument doc, XmlNode parent)
        {
            XmlNode variableNode;
            XmlAttribute variableAttribute;

            foreach (var variable in variables)
            {
                var registryValue = source.GetValue(variable) as string;
                if (registryValue == null)
                    continue;

                variableAttribute = doc.CreateAttribute("name");
                variableAttribute.Value = variable;

                variableNode = doc.CreateElement("variable");
                variableNode.Attributes.Append(variableAttribute);
                variableNode.InnerText = registryValue;

                parent.AppendChild(variableNode);
            }
        }

        /// <summary>
        /// Imports environmental variables from XML to registry.
        /// </summary>
        /// <param name="source">Parent XML node containing <variable> tags</param>
        /// <param name="destination">Registry key to save variables to</param>
        private void Import(XmlNode source, RegistryKey destination)
        {
            foreach (XmlNode node in source.ChildNodes)
            {
                if (node.Name == "variable" && node.Attributes["name"] != null)
                {
                    var variableName = node.Attributes["name"].Value;
                    var variableValue = node.InnerText;

                    destination.SetValue(variableName, variableValue);
                }
            }
        }

        #endregion

        public string[] GetVariableNames(VariableType varType)
        {
            return SelectKey(varType).GetValueNames();
        }

        public void NewVariable(VariableType varType, string varName)
        {
            SelectKey(varType).SetValue(varName, "", RegistryValueKind.ExpandString);
        }

        public object GetVariableValue(VariableType varType, string varName)
        {
            return SelectKey(varType).GetValue(varName);
        }

        public void SetVariableValue(VariableType varType, string varName, string value)
        {
            SelectKey(varType).SetValue(varName, value);
        }

        public void RemoveVariable(VariableType varType, string varName)
        {
            SelectKey(varType).DeleteValue(varName);
        }

        public void ExportVariables(string fileName, bool userVariablesOnly)
        {
            var doc = new XmlDocument();
            var root = doc.CreateElement("variables");

            /* Create <user> XML node */
            var user = doc.CreateElement("user");
            Export(userKey.GetValueNames(), userKey, doc, user);
            root.AppendChild(user);

            /* Create <system> XML node if needed */
            if (!userVariablesOnly)
            {
                /* Don't import platform specific variables */
                var systemVars = systemKey.GetValueNames().ToList();
                foreach (var var in PlatformSpecific)
                {
                    if (systemVars.Contains(var))
                        systemVars.Remove(var);
                }

                var system = doc.CreateElement("system");
                Export(systemVars, systemKey, doc, system);
                root.AppendChild(system);
            }

            /* Save XML document */
            doc.AppendChild(root);
            doc.Save(fileName);
        }

        public void ImportVariables(string fileName, bool userVariablesOnly)
        {
            var doc = new XmlDocument();
            doc.Load(fileName);

            foreach (XmlNode node in doc.FirstChild.ChildNodes)
            {
                // Load system variables if allowed
                if (node.Name == "system" && !userVariablesOnly)
                {
                   Import(node, systemKey);
                }

                // Load user variables
                else if (node.Name == "user")
                {
                    Import(node, userKey);
                }
            }
        }
    }
}
