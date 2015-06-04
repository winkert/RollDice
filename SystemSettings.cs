using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace RollDiced
{
    [Serializable]
    public class SystemSettings
    {
        public SystemSettings()
        {
            playSound = true;
            clearSearch = true;
        }
        public bool playSound;
        public bool clearSearch;
        public static void SaveSettings(SystemSettings s, String loc)
        {
            try
            {
                using (Stream FileStream = File.Create(loc))
                { BinaryFormatter serializer = new BinaryFormatter(); serializer.Serialize(FileStream, s); }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e.Message);
            }
        }

        public static SystemSettings OpenSettings(String loc)
        {
            try
            {
                using (Stream FileStream = File.OpenRead(loc))
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    return (SystemSettings)deserializer.Deserialize(FileStream);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e.Message);
                return null;
            }
        }

    }
}
