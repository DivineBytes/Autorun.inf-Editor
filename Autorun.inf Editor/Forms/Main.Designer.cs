
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SS_Main = new System.Windows.Forms.StatusStrip();
            this.TSSL_LnColPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_StartEndLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_New = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Entries = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Label = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Icon = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.RTB_Editor = new Autorun.inf_Editor.Controls.RichTextBoxEx();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SS_Main.SuspendLayout();
            this.MS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // SS_Main
            // 
            this.SS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_LnColPos,
            this.TSSL_StartEndLength});
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
            // 
            // MS_Main
            // 
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.TSMI_Edit,
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
            this.TSMI_New.Size = new System.Drawing.Size(123, 22);
            this.TSMI_New.Text = "New";
            this.TSMI_New.Click += new System.EventHandler(this.TSMI_New_Click);
            // 
            // TSMI_Open
            // 
            this.TSMI_Open.Name = "TSMI_Open";
            this.TSMI_Open.Size = new System.Drawing.Size(123, 22);
            this.TSMI_Open.Text = "Open";
            this.TSMI_Open.Click += new System.EventHandler(this.TSMI_Open_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // TSMI_Save
            // 
            this.TSMI_Save.Name = "TSMI_Save";
            this.TSMI_Save.Size = new System.Drawing.Size(123, 22);
            this.TSMI_Save.Text = "Save";
            this.TSMI_Save.Click += new System.EventHandler(this.TSMI_Save_Click);
            // 
            // TSMI_SaveAs
            // 
            this.TSMI_SaveAs.Name = "TSMI_SaveAs";
            this.TSMI_SaveAs.Size = new System.Drawing.Size(123, 22);
            this.TSMI_SaveAs.Text = "Save As...";
            this.TSMI_SaveAs.Click += new System.EventHandler(this.TSMI_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(123, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // TSMI_Edit
            // 
            this.TSMI_Edit.Name = "TSMI_Edit";
            this.TSMI_Edit.Size = new System.Drawing.Size(39, 20);
            this.TSMI_Edit.Text = "Edit";
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
            this.TSMI_Label.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Label.Text = "Label";
            this.TSMI_Label.Click += new System.EventHandler(this.TSMI_Label_Click);
            // 
            // TSMI_Icon
            // 
            this.TSMI_Icon.Name = "TSMI_Icon";
            this.TSMI_Icon.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Icon.Text = "Icon";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_About});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(107, 22);
            this.TSMI_About.Text = "About";
            // 
            // RTB_Editor
            // 
            this.RTB_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Editor.Location = new System.Drawing.Point(0, 24);
            this.RTB_Editor.Name = "RTB_Editor";
            this.RTB_Editor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.RTB_Editor.Size = new System.Drawing.Size(384, 315);
            this.RTB_Editor.TabIndex = 3;
            this.RTB_Editor.Text = "";
            this.RTB_Editor.TextChanged += new System.EventHandler(this.RTB_Editor_TextChanged);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
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
        private System.Windows.Forms.ToolStripMenuItem TSMI_Edit;
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
    }
}

