using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace FileIODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateDictionary_Click(object sender, EventArgs e)
        {
            /* try
             {
                 string path = @"D:\TestFolder";
                 if (Directory.Exists(path))
                 {
                     MessageBox.Show("Directory Already Exists");
                 }
                 else
                 {
                     Directory.CreateDirectory(path);
                     MessageBox.Show("Directory Created");
                 }

             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
            try
            {
                string path = @"D:\Test Folder 2";
                DirectoryInfo info = new DirectoryInfo(path);
                if(info.Exists)
                {
                    MessageBox.Show("Direcotry Already Exist");
                }
                else
                {
                    info.Create();
                    MessageBox.Show("Created");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFille_Click(object sender, EventArgs e)
        {
            /*try
            {
                string path = @"D:\TestFolder\Employe.dat";//.dat-->Data File Binary
                if (File.Exists(path))
                {

                    MessageBox.Show("File Already Exit");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            try
            {
                string path = @"D:\Test Folder 2\emp2.dat";
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    MessageBox.Show("File Already Exist");
                }
                else
                {
                    file.Create();
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestFolder\Employe.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtID.Text));
                bw.Write(TxtName.Text);
                bw.Write(Convert.ToDouble(TxtSalary.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Write SuessFul");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs =new FileStream(@"D:\TestFolder\Employe.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtID.Text = br.ReadInt32().ToString();
                TxtName.Text=br.ReadString();
                TxtSalary.Text=br.ReadDouble().ToString();
                br.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStreamwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestFolder\Employe.dat", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnstreamRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestFolder\Employe.dat", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
