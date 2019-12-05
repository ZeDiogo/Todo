using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Todo
{
    public class Data
    {
        private static Data instance = new Data();

        private Data() {}

        public static Data getInstance() { return instance; }

        public static string FILEPATH = resolvePath("Todo", "list");

        private static string resolvePath(string folderName, string fileName)
        {
            var appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dir = System.IO.Path.Combine(appDataDir, folderName);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return System.IO.Path.Combine(dir, fileName);
        }

        public List<string> getList(string filePath)
        {
            if (!File.Exists(filePath))
            {
                this.newFile(filePath);
            }
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<string> list = (List<string>)serializer.Deserialize(file, typeof(List<string>));
                return list;
            }
        }

        public void setList(List<string> list, string filePath)
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, list);
            }
            //EncryptFile(filePath, filePath+".enc");
        }

        
        public void addList(string entry, string filePath)
        {
            List<string> list = getList(filePath);
            list.Add(entry);
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, list);
            }
        }


        public void rmList(int index, string filePath)
        {
            List<string> list = getList(filePath);
            list.RemoveAt(index);
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, list);
            }
        }

        //TODO: secure datastream https://ubuntuanakramli.blogspot.com/2015/04/c-encrypt-decrypt-serialized-object.html
        public void EncryptFile(string inputFile, string outputFile, string password)
        {
            //try
            //{
                //string password = "myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Encryption failed!", "Error");
            //}
        }

        public void DecryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                //string password = @"myKey12"; // Your Key Here

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            } catch
            {
                //MessageBox.Show("Invalid Password", "Error");
                throw new Exception("Wrong password");
            }
        }

        public void newFile(string inputFile)
        {
            List<string> list = new List<string>();
            setList(list, inputFile);
        }

        public void removeFile(string inputFile)
        {
            File.Delete(inputFile);
        }

        public List<String> DecryptFile(string inputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                {
                    using (RijndaelManaged RMCrypto = new RijndaelManaged())
                    {
                        using (CryptoStream cs = new CryptoStream(fsCrypt,
                                                    RMCrypto.CreateDecryptor(key, key),
                                                    CryptoStreamMode.Read))
                        {
                            using (StreamReader decrypted = new StreamReader(cs))
                            {
                                JsonSerializer serializer = new JsonSerializer();
                                List<string> list = (List<string>)serializer.Deserialize(decrypted, typeof(List<string>));
                                Console.WriteLine("First Line: " + list[0]);
                                return list;
                            }                                
                        }
                    }                       
                }                    
            } catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            return new List<String>();
        }

        public void EncryptFile(List<String> list, string outputFile, string password)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateEncryptor(key, key),
                CryptoStreamMode.Write);

            TextWriter tw = new StreamWriter(cs);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(tw, list);

            //int data;
            //while ((data = fsIn.ReadByte()) != -1)
            //    cs.WriteByte((byte)data);

            cs.Close();
            fsCrypt.Close();
        }

        //https://stackoverflow.com/questions/965042/c-sharp-serializing-deserializing-a-des-encrypted-file-from-a-stream
        public void EncryptAndSerialize(List<String> obj, string filename, String password)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);
            RijndaelManaged RMCrypto = new RijndaelManaged();
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (CryptoStream cs = new CryptoStream(fs, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write))
                {
                    XmlSerializer xmlser = new XmlSerializer(typeof(List<String>));
                    xmlser.Serialize(cs, obj);
                }
            }
        }

        public List<String> DecryptAndDeserialize(string filename, String password)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);
            RijndaelManaged RMCrypto = new RijndaelManaged();
            using (FileStream fs = File.Open(filename, FileMode.Open))
            {
                using (CryptoStream cs = new CryptoStream(fs, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read))
                {
                    XmlSerializer xmlser = new XmlSerializer(typeof(List<String>));
                    return (List<String>)xmlser.Deserialize(cs);
                }
            }
        }
    }
}
