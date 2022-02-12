using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecstAddetor
{
    public partial class F_TextEditor : Form
        
    {
        string filePath = "";
        FileEdditor fileEditor;
        public F_TextEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtb_Edditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void mb_OpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog( )==DialogResult.OK)
            {
                fileEditor = new FileEdditor(openFileDialog1.FileName);
                List<string> lines = fileEditor.readFile();
                string restext = "";
                foreach(string line in lines)
                {
                    restext += line + "\n";
                }
                rtb_Edditor.Text = restext.Remove(restext.Length - 1);
            }
        }
        private void mb_SaveFile_Click(object sender,EventArgs e)
        {
            fileEditor.WriteFile(rtb_Edditor.Text);
        }
    }
}
