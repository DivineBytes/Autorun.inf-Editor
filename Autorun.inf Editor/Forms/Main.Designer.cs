
namespace Autorun.inf_Editor.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SS_Main = new System.Windows.Forms.StatusStrip();
            this.TSSL_LnColPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_StartEndLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_SaveFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_New = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Entries = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Label = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Icon = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_VisitLearnMicrosoft = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_VisitWiki = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_Editor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSL_Length = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_Lines = new System.Windows.Forms.ToolStripStatusLabel();
            this.RTB_Editor = new Autorun.inf_Editor.Controls.RichTextBoxEx();
            this.SS_Main.SuspendLayout();
            this.MS_Main.SuspendLayout();
            this.CMS_Editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // SS_Main
            // 
            this.SS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Length,
            this.TSSL_Lines,
            this.TSSL_LnColPos,
            this.TSSL_StartEndLength,
            this.TSSL_SaveFileName});
            this.SS_Main.Location = new System.Drawing.Point(0, 339);
            this.SS_Main.Name = "SS_Main";
            this.SS_Main.Size = new System.Drawing.Size(384, 22);
            this.SS_Main.TabIndex = 0;
            this.SS_Main.Text = "statusStrip1";
            // 
            // TSSL_LnColPos
            // 
            this.TSSL_LnColPos.Name = "TSSL_LnColPos";
            this.TSSL_LnColPos.Size = new System.Drawing.Size(96, 17);
            this.TSSL_LnColPos.Text = "Ln 0, Col 0, Pos 0";
            // 
            // TSSL_StartEndLength
            // 
            this.TSSL_StartEndLength.Name = "TSSL_StartEndLength";
            this.TSSL_StartEndLength.Size = new System.Drawing.Size(127, 17);
            this.TSSL_StartEndLength.Text = "Start 0, End 0, Length 0";
            this.TSSL_StartEndLength.Visible = false;
            // 
            // TSSL_SaveFileName
            // 
            this.TSSL_SaveFileName.Name = "TSSL_SaveFileName";
            this.TSSL_SaveFileName.Size = new System.Drawing.Size(12, 17);
            this.TSSL_SaveFileName.Text = "*";
            // 
            // MS_Main
            // 
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.TSMI_Entries,
            this.helpToolStripMenuItem});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(384, 24);
            this.MS_Main.TabIndex = 1;
            this.MS_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_New,
            this.TSMI_Open,
            this.toolStripSeparator2,
            this.TSMI_Save,
            this.TSMI_SaveAs,
            this.toolStripSeparator1,
            this.TSMI_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // TSMI_New
            // 
            this.TSMI_New.Name = "TSMI_New";
            this.TSMI_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TSMI_New.Size = new System.Drawing.Size(195, 22);
            this.TSMI_New.Text = "New";
            this.TSMI_New.Click += new System.EventHandler(this.TSMI_New_Click);
            // 
            // TSMI_Open
            // 
            this.TSMI_Open.Name = "TSMI_Open";
            this.TSMI_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMI_Open.Size = new System.Drawing.Size(195, 22);
            this.TSMI_Open.Text = "Open";
            this.TSMI_Open.Click += new System.EventHandler(this.TSMI_Open_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // TSMI_Save
            // 
            this.TSMI_Save.Name = "TSMI_Save";
            this.TSMI_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_Save.Size = new System.Drawing.Size(195, 22);
            this.TSMI_Save.Text = "Save";
            this.TSMI_Save.Click += new System.EventHandler(this.TSMI_Save_Click);
            // 
            // TSMI_SaveAs
            // 
            this.TSMI_SaveAs.Name = "TSMI_SaveAs";
            this.TSMI_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMI_SaveAs.Size = new System.Drawing.Size(195, 22);
            this.TSMI_SaveAs.Text = "Save As...";
            this.TSMI_SaveAs.Click += new System.EventHandler(this.TSMI_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TSMI_Exit.Size = new System.Drawing.Size(195, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // TSMI_Entries
            // 
            this.TSMI_Entries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Label,
            this.TSMI_Icon,
            this.openToolStripMenuItem});
            this.TSMI_Entries.Name = "TSMI_Entries";
            this.TSMI_Entries.Size = new System.Drawing.Size(54, 20);
            this.TSMI_Entries.Text = "Entries";
            // 
            // TSMI_Label
            // 
            this.TSMI_Label.Name = "TSMI_Label";
            this.TSMI_Label.Size = new System.Drawing.Size(103, 22);
            this.TSMI_Label.Text = "Label";
            this.TSMI_Label.Click += new System.EventHandler(this.TSMI_Label_Click);
            // 
            // TSMI_Icon
            // 
            this.TSMI_Icon.Name = "TSMI_Icon";
            this.TSMI_Icon.Size = new System.Drawing.Size(103, 22);
            this.TSMI_Icon.Text = "Icon";
            this.TSMI_Icon.Click += new System.EventHandler(this.TSMI_Icon_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_About,
            this.toolStripSeparator4,
            this.TSMI_VisitLearnMicrosoft,
            this.TSMI_VisitWiki});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(182, 22);
            this.TSMI_About.Text = "About";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // TSMI_VisitLearnMicrosoft
            // 
            this.TSMI_VisitLearnMicrosoft.Name = "TSMI_VisitLearnMicrosoft";
            this.TSMI_VisitLearnMicrosoft.Size = new System.Drawing.Size(182, 22);
            this.TSMI_VisitLearnMicrosoft.Text = "Visit Learn.Microsoft";
            this.TSMI_VisitLearnMicrosoft.Click += new System.EventHandler(this.TSMI_VisitLearnMicrosoft_Click);
            // 
            // TSMI_VisitWiki
            // 
            this.TSMI_VisitWiki.Name = "TSMI_VisitWiki";
            this.TSMI_VisitWiki.Size = new System.Drawing.Size(182, 22);
            this.TSMI_VisitWiki.Text = "Visit Wiki";
            this.TSMI_VisitWiki.Click += new System.EventHandler(this.TSMI_VisitWiki_Click);
            // 
            // CMS_Editor
            // 
            this.CMS_Editor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem});
            this.CMS_Editor.Name = "CMS_Editor";
            this.CMS_Editor.Size = new System.Drawing.Size(165, 120);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // TSSL_Length
            // 
            this.TSSL_Length.Name = "TSSL_Length";
            this.TSSL_Length.Size = new System.Drawing.Size(56, 17);
            this.TSSL_Length.Text = "Length: 0";
            // 
            // TSSL_Lines
            // 
            this.TSSL_Lines.Name = "TSSL_Lines";
            this.TSSL_Lines.Size = new System.Drawing.Size(46, 17);
            this.TSSL_Lines.Text = "Lines: 1";
            // 
            // RTB_Editor
            // 
            this.RTB_Editor.ContextMenuStrip = this.CMS_Editor;
            this.RTB_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Editor.Location = new System.Drawing.Point(0, 24);
            this.RTB_Editor.Name = "RTB_Editor";
            this.RTB_Editor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.RTB_Editor.Size = new System.Drawing.Size(384, 315);
            this.RTB_Editor.TabIndex = 3;
            this.RTB_Editor.Text = "";
            this.RTB_Editor.TextChanged += new System.EventHandler(this.RTB_Editor_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.RTB_Editor);
            this.Controls.Add(this.SS_Main);
            this.Controls.Add(this.MS_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_Main;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Main";
            this.Text = "Autorun.inf Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.SS_Main.ResumeLayout(false);
            this.SS_Main.PerformLayout();
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.CMS_Editor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SS_Main;
        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.ToolStripMenuItem TSMI_New;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Save;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Entries;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Label;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Icon;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_LnColPos;
        private Controls.RichTextBoxEx RTB_Editor;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_StartEndLength;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMS_Editor;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VisitWiki;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VisitLearnMicrosoft;
        protected internal System.Windows.Forms.ToolStripStatusLabel TSSL_SaveFileName;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Length;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Lines;
    }
}

