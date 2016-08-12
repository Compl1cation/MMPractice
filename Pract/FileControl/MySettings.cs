using System;
using System.IO;
using System.Xml.Serialization;

namespace Pract2
{
    public class MySettings
    {
        [XmlElement("first")]
        public int MyNumber { get; set; }
        public string MyString { get; set; }
        public void Save()
        {
            using (Stream stream = File.Create(SettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(this.GetType());
                ser.Serialize(stream, this);
            }
        }
        private static string SettingsFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                folder = Path.Combine(folder, "MyCompany");
                folder = Path.Combine(folder, "MyApp");

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }
        private static string SettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "settings.xml");
            }
        }
        public static MySettings Load()
        {
            if (!File.Exists(SettingsFile))
                return DefaultSettings;

            using (Stream stream = File.OpenRead(SettingsFile))
            {
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(MySettings));
                    return (MySettings)ser.Deserialize(stream);
                }
                catch (InvalidOperationException)
                {
                    stream.Close();
                    File.Delete(SettingsFile);
                    return DefaultSettings;
                }
            }
        }
        private static MySettings DefaultSettings
        {
            get {
                return new MySettings
                {
                    MyNumber = 0,
                    MyString = "",
                };
            }
        }
    }
}
