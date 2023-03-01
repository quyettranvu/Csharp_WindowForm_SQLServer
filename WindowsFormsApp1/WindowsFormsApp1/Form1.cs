using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                // Set the file dialog properties
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected file name in a label control
                    labelLinkFile.Text = openFileDialog1.FileName;
                }

                //If many files chosen
                //using (OpenFileDialog openFileDialog = new OpenFileDialog())
                //{
                //    openFileDialog.Multiselect = true;
                //    openFileDialog.Filter = "All files (*.*)|*.*";

                //    if (openFileDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        // Process selected files
                //        foreach (string file in openFileDialog.FileNames)
                //        {
                //            // Add file to list of files to encrypt
                //            lstFilesToEncrypt.Items.Add(file);
                //        }
                //    }
                //}

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //hello 
        }

        private void button2_Click(object sender, EventArgs e)
        {
                string filePath = labelLinkFile.Text;
                string key = textBoxEncryptKey.Text;

                if (radioButtonDES.Checked)
                {
                    if (key.Length < 8)
                {
                    key = key.PadRight(8, '\0');
                }
                else if (key.Length > 8)
                {
                    key = key.Substring(0, 8);
                }

                }

                if (File.Exists(filePath))
                {
                    byte[] keyBytes = Encoding.ASCII.GetBytes(key);
                    byte[] ivBytes = Encoding.ASCII.GetBytes("1234567890123456"); // initialization vector for AES encryption

                    if (radioButtonDES.Checked)
                    {
                        using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                        {
                            des.Key = keyBytes;
                            des.IV = keyBytes; // initialization vector for DES encryption

                            using (FileStream inputFile = new FileStream(filePath, FileMode.Open))
                            {
                                using (FileStream outputFile = new FileStream(filePath + ".des", FileMode.Create))
                                {
                                    using (CryptoStream cryptoStream = new CryptoStream(outputFile, des.CreateEncryptor(), CryptoStreamMode.Write))
                                    {
                                        inputFile.CopyTo(cryptoStream);
                                    }
                                }
                            }
                        }
                    }
                    else if (radioButtonAES.Checked)
                    {
                        using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                        {
                            aes.Key = keyBytes;
                            aes.IV = ivBytes;

                            using (FileStream inputFile = new FileStream(filePath, FileMode.Open))
                            {
                                using (FileStream outputFile = new FileStream(filePath + ".aes", FileMode.Create))
                                {
                                    using (CryptoStream cryptoStream = new CryptoStream(outputFile, aes.CreateEncryptor(), CryptoStreamMode.Write))
                                    {
                                        inputFile.CopyTo(cryptoStream);
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show("File encrypted successfully.");
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //hello
        }
    }
}
