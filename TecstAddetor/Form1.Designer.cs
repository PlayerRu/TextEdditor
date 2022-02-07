
namespace TecstAddetor
{
    partial class F_TextEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms_MainMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_SaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_CloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_Edditor = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ms_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Size = new System.Drawing.Size(284, 24);
            this.ms_MainMenu.TabIndex = 0;
            this.ms_MainMenu.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_OpenFile,
            this.mb_SaveFile,
            this.mb_SaveAsFile,
            this.mb_CloseFile});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // mb_OpenFile
            // 
            this.mb_OpenFile.Name = "mb_OpenFile";
            this.mb_OpenFile.Size = new System.Drawing.Size(180, 22);
            this.mb_OpenFile.Text = "Открыть";
            this.mb_OpenFile.Click += new System.EventHandler(this.mb_OpenFile_Click);
            // 
            // mb_SaveFile
            // 
            this.mb_SaveFile.Name = "mb_SaveFile";
            this.mb_SaveFile.Size = new System.Drawing.Size(180, 22);
            this.mb_SaveFile.Text = "Сохранить";
            // 
            // mb_SaveAsFile
            // 
            this.mb_SaveAsFile.Name = "mb_SaveAsFile";
            this.mb_SaveAsFile.Size = new System.Drawing.Size(180, 22);
            this.mb_SaveAsFile.Text = "Сохранить как ...";
            // 
            // mb_CloseFile
            // 
            this.mb_CloseFile.Name = "mb_CloseFile";
            this.mb_CloseFile.Size = new System.Drawing.Size(180, 22);
            this.mb_CloseFile.Text = "Закрыть";
            // 
            // rtb_Edditor
            // 
            this.rtb_Edditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Edditor.Location = new System.Drawing.Point(0, 27);
            this.rtb_Edditor.Name = "rtb_Edditor";
            this.rtb_Edditor.Size = new System.Drawing.Size(284, 213);
            this.rtb_Edditor.TabIndex = 1;
            this.rtb_Edditor.Text = "";
            this.rtb_Edditor.TextChanged += new System.EventHandler(this.rtb_Edditor_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F_TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.rtb_Edditor);
            this.Controls.Add(this.ms_MainMenu);
            this.MainMenuStrip = this.ms_MainMenu;
            this.Name = "F_TextEditor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.RichTextBox rtb_Edditor;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem mb_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem mb_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem mb_SaveAsFile;
        private System.Windows.Forms.ToolStripMenuItem mb_CloseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

