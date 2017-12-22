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
    }
}
