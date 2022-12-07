
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Main = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.RTB_Editor = new System.Windows.Forms.RichTextBox();
            this.TSMI_Entries = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Label = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Icon = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Main.SuspendLayout();
            this.TS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // SS_Main
            // 
            this.SS_Main.Location = new System.Drawing.Point(0, 339);
            this.SS_Main.Name = "SS_Main";
            this.SS_Main.Size = new System.Drawing.Size(384, 22);
            this.SS_Main.TabIndex = 0;
            this.SS_Main.Text = "statusStrip1";
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
            this.TSMI_New.Size = new System.Drawing.Size(180, 22);
            this.TSMI_New.Text = "New";
            this.TSMI_New.Click += new System.EventHandler(this.TSMI_New_Click);
            // 
            // TSMI_Open
            // 
            this.TSMI_Open.Name = "TSMI_Open";
            this.TSMI_Open.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Open.Text = "Open";
            this.TSMI_Open.Click += new System.EventHandler(this.TSMI_Open_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_Save
            // 
            this.TSMI_Save.Name = "TSMI_Save";
            this.TSMI_Save.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Save.Text = "Save";
            this.TSMI_Save.Click += new System.EventHandler(this.TSMI_Save_Click);
            // 
            // TSMI_SaveAs
            // 
            this.TSMI_SaveAs.Name = "TSMI_SaveAs";
            this.TSMI_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.TSMI_SaveAs.Text = "Save As...";
            this.TSMI_SaveAs.Click += new System.EventHandler(this.TSMI_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // TSMI_Edit
            // 
            this.TSMI_Edit.Name = "TSMI_Edit";
            this.TSMI_Edit.Size = new System.Drawing.Size(39, 20);
            this.TSMI_Edit.Text = "Edit";
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
            this.TSMI_About.Size = new System.Drawing.Size(180, 22);
            this.TSMI_About.Text = "About";
            // 
            // TS_Main
            // 
            this.TS_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.TS_Main.Location = new System.Drawing.Point(0, 24);
            this.TS_Main.Name = "TS_Main";
            this.TS_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TS_Main.Size = new System.Drawing.Size(384, 25);
            this.TS_Main.TabIndex = 2;
            this.TS_Main.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // RTB_Editor
            // 
            this.RTB_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Editor.Location = new System.Drawing.Point(0, 49);
            this.RTB_Editor.Name = "RTB_Editor";
            this.RTB_Editor.Size = new System.Drawing.Size(384, 290);
            this.RTB_Editor.TabIndex = 3;
            this.RTB_Editor.Text = "";
            this.RTB_Editor.TextChanged += new System.EventHandler(this.RTB_Editor_TextChanged);
            // 
            // TSMI_Entries
            // 
            this.TSMI_Entries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Label,
            this.TSMI_Icon});
            this.TSMI_Entries.Name = "TSMI_Entries";
            this.TSMI_Entries.Size = new System.Drawing.Size(54, 20);
            this.TSMI_Entries.Text = "Entries";
            // 
            // TSMI_Label
            // 
            this.TSMI_Label.Name = "TSMI_Label";
            this.TSMI_Label.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Label.Text = "Label";
            // 
            // TSMI_Icon
            // 
            this.TSMI_Icon.Name = "TSMI_Icon";
            this.TSMI_Icon.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Icon.Text = "Icon";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.RTB_Editor);
            this.Controls.Add(this.TS_Main);
            this.Controls.Add(this.SS_Main);
            this.Controls.Add(this.MS_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_Main;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Main";
            this.Text = "Autorun.inf Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.TS_Main.ResumeLayout(false);
            this.TS_Main.PerformLayout();
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
        private System.Windows.Forms.ToolStrip TS_Main;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Edit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_New;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Save;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.RichTextBox RTB_Editor;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Entries;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Label;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Icon;
    }
}

