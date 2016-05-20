using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using SharedBase.Domain;

namespace SharedBase.Utils
{
    public static class HelpProject
    {
        #region Metodi Pubblici

        public static XmlDocument SerializzaProject(Project project)
        {
            try
            {
                XmlDocument result;
                XmlSerializer serializer = new XmlSerializer(typeof(Project));
                using (MemoryStream mem = new MemoryStream())
                {
                    serializer.Serialize(mem, project);
                    mem.Position = 0;
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreWhitespace = true;

                    using (var xtr = XmlReader.Create(mem, settings))
                    {
                        result = new XmlDocument();
                        result.Load(xtr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                //LoggingEvents.Log("Si è verificato una anomalia rivolgersi all'amministratore di sistema", TraceEventType.Error, ex);
                return null;
            }
        }

        public static Project DeserializzaProject(XmlDocument xml)
        {
            try
            {
                Project p = new Project();
                var serializer = new XmlSerializer(typeof(Project));
                p = (Project)serializer.Deserialize(new XmlNodeReader(xml.DocumentElement));
                return p;
            }
            catch (Exception ex)
            {
                //LoggingEvents.Log("Si è verificato una anomalia rivolgersi all'amministratore di sistema", TraceEventType.Error, ex);
                return null;
            }
        }

        public static void SaveXml(XmlDocument xml, string path)
        {
            xml.Save(path);
        }

        public static XmlDocument LoadXml(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            return xml;
        }

        #endregion Metodi Pubblici
    }
}
