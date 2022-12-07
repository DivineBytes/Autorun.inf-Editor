namespace Autorun.inf_Editor.UserControls
{
    partial class IconPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.NUD_Index = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Index)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Input
            // 
            this.TB_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Input.Location = new System.Drawing.Point(3, 3);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(213, 20);
            this.TB_Input.TabIndex = 0;
            // 
            // NUD_Index
            // 
            this.NUD_Index.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Index.Location = new System.Drawing.Point(222, 3);
            this.NUD_Index.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_Index.Name = "NUD_Index";
            this.NUD_Index.Size = new System.Drawing.Size(47, 20);
            this.NUD_Index.TabIndex = 1;
            this.NUD_Index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IconPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NUD_Index);
            this.Controls.Add(this.TB_Input);
            this.Name = "IconPanel";
            this.Size = new System.Drawing.Size(272, 28);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Index)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox TB_Input;
        protected internal System.Windows.Forms.NumericUpDown NUD_Index;
    }
}
