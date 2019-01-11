using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace OS_kriptiranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path;
        public AesCryptoServiceProvider AES { get; set; }
        public RSACryptoServiceProvider RSA { get; set; }
        byte[] encrypted;

        private void button1_Click(object sender, EventArgs e)
        {

            RSA = new RSACryptoServiceProvider();
            RSAParameters parameters = RSA.ExportParameters(true);

            string modul = Convert.ToBase64String(parameters.Modulus);
            string eksponent = Convert.ToBase64String(parameters.Exponent);

            string javniKljuc = modul + "; " + eksponent;
            System.IO.File.WriteAllText("Javni_kljuc.txt", javniKljuc);

            //Privatni
            string D = Convert.ToBase64String(parameters.D);

            System.IO.File.WriteAllText("Privatni_kljuc.txt", D);

            statusLabel.Text = "Javni i privatni ključ generiran!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AES = new AesCryptoServiceProvider();
            
            AES.GenerateKey();
            System.IO.File.WriteAllText("Tajni_kljuc.txt",Convert.ToBase64String(AES.Key));
            statusLabel.Text = "Tajni ključ generiran!!";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                statusLabel.Text = "Datoteka: " + path + " učitana!";
            }
            
        }

        private void kriptButton_Click(object sender, EventArgs e)
        {

            if (simRadio.Checked)
            {
                var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(fileStream);

                encrypted = EncryptStringToBytes_Aes(reader.ReadToEnd(), AES.Key, AES.IV);

                ByteArrayToFile("kriptirano.txt", encrypted);


            }
            else {
                byte[] file = RSAEncrypt(File.ReadAllBytes(path));
                ByteArrayToFile("RSA_kriptirana.txt", file);
                statusLabel.Text = "Datoteka kriptirana RSA!";

            }

        }


        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

           
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

               
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

               
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                           
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            return encrypted;

        }


        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Došlo je do pogreške: {0}", ex);
                return false;
            }
        }

        private void dekriptButton_Click(object sender, EventArgs e)
        {

            if (simRadio.Checked)
            {

                string roundtrip = DecryptStringFromBytes_Aes(encrypted, AES.Key, AES.IV);
                System.IO.File.WriteAllText("dekriptirani.txt", roundtrip);
            }
            else {
                byte[] file = RSADecrypt(File.ReadAllBytes(path));
                ByteArrayToFile("RSA_dekriptirana.txt", file);
                statusLabel.Text = "Datoteka dekriptirana RSA!";
            }
        }




        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

           
            string plaintext = null;

            
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

              
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
        public byte[] RSAEncrypt(byte[] input)
        {
            return RSA.Encrypt(input, false);
        }

        public byte[] RSADecrypt(byte[] input)
        {
            return RSA.Decrypt(input, false);
        }
    }
}
