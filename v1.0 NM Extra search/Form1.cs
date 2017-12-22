using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        string strSearchDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(strSearchDirectory);
            FileInfo[] fi = di.GetFiles();

            if (txtSearchSubstring.Text != "")
            {
                string strSearchString = txtSearchSubstring.Text;
                lbxResults.Items.Clear();
                foreach (FileInfo curFile in fi)
                {
                    if (curFile.Name.ToUpper().IndexOf(strSearchString.ToUpper()) != -1)
                    {
                        lbxResults.Items.Add(curFile.Name);
                    }
                }
                txtSearchSubstring.Clear();
                txtSearchSubstring.Focus();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDirBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strSearchDirectory = fbd.SelectedPath;
                txtSearchDirectory.Text = strSearchDirectory;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strSearchDirectory = txtSearchDirectory.Text;

        }

        private void lbxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = lbxResults.SelectedItem.ToString();
            string fullFileName = Path.Combine(@"D:\katalogplikow", file);
            Process.Start(fullFileName);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (lbxResults.SelectedIndex == -1)
            {
                MessageBox.Show("No Item selected");
            }
            else
            {
                string txt = txtSearchDirectory.Text;
                string file = lbxResults.SelectedItem.ToString();
                string fullFileName = Path.Combine(txt, file);
                Process.Start(fullFileName);
            }
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            
            btnSearch.BackColor = Color.DarkRed;
        }

        private void txtSearchDirectory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
