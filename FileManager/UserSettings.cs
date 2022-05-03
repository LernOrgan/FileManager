using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FileManager
{
    [Serializable()]
    public class UserSettings
    {
        public Color UserColor { get; set; }
        public Font UserFont { get; set; }
        public string Password = "Admin"; //Пароль по умолчанию
        [OnSerializing]
        internal void OnSerializing(StreamingContext context)
        {
            Password = Crypter.Encrypt(Password);
        }
        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            Password = Crypter.Decrypt(Password);
        }
    }
}
