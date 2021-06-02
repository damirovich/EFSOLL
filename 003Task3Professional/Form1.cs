using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003Task3Professional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = filename;
            textBox2.Text = fileText;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string zipPath = @"C:\3 курс\test\result.zip";
            //string extractPath = @"C:\3 курс\test\result.zip";
            //ZipFile.CreateFromDirectory(textBox1.Text, zipPath);
            //ZipFile.ExtractToDirectory(zipPath, extractPath);
            //to store the value of folderapth   
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Пожалуйста укажите путь к файлу и называние файла.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }
            string fileName = textBox1.Text;
            //Zip file & update process bar
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(fileName);
                    zip.AddFile(fileName);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(fileName);
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, fi.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }
    }
}
