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
                UnlockControlls();
            }
        }
        private void mb_SaveFile_Click(object sender,EventArgs e)
        {
            fileEditor.WriteFile(rtb_Edditor.Text);
        }

        private void mb_CloseFile_Click(object sender, EventArgs e)
        {
            fileEditor = null;
            rtb_Edditor.Text = "";
            LockControlls();

            
        }
        void UnlockControlls()
        {
            mb_CloseFile.Enabled = true;
            mb_SaveFile.Enabled = true;
            mb_SaveAsFile.Enabled = true;
        }
        void LockControlls()
        {
            mb_CloseFile.Enabled = false;
            mb_SaveFile.Enabled = false;
            mb_SaveAsFile.Enabled = false;
        }

        private void mb_SaveAsFile_Click(object sender, EventArgs e)
        {
            if(SaveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                fileEditor.WriteFileAs(rtb_Edditor.Text, SaveFileDialog1.FileName);
            }
                  
        }

        private void mb_SaveFile_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_Edditor.SelectedText);
        }

        private void cm_Cut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_Edditor.SelectedText);
            rtb_Edditor.SelectedText = "";
        }

        private void cm_Paste_Click(object sender, EventArgs e)
        {
            if (rtb_Edditor.SelectedText == "")
            {
                int cursorPosition = rtb_Edditor.SelectionStart;
                rtb_Edditor.Text = rtb_Edditor.Text.Insert(cursorPosition, Clipboard.GetText());
                rtb_Edditor.SelectionStart = cursorPosition + Clipboard.GetText().Length;
            }
            else
                rtb_Edditor.SelectedText = Clipboard.GetText();
        }
    }
}
