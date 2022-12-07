namespace Autorun.inf_Editor.Dialogs
{
    partial class DialogInput
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
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.P_Footer = new System.Windows.Forms.Panel();
            this.P_Header = new System.Windows.Forms.Panel();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.L_Header = new System.Windows.Forms.Label();
            this.P_Main = new System.Windows.Forms.Panel();
            this.TLP_Main.SuspendLayout();
            this.P_Footer.SuspendLayout();
            this.P_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_Main
            // 
            this.TLP_Main.ColumnCount = 1;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Controls.Add(this.P_Footer, 0, 2);
            this.TLP_Main.Controls.Add(this.P_Header, 0, 0);
            this.TLP_Main.Controls.Add(this.P_Main, 0, 1);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 3;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TLP_Main.Size = new System.Drawing.Size(343, 245);
            this.TLP_Main.TabIndex = 0;
            // 
            // P_Footer
            // 
            this.P_Footer.Controls.Add(this.BTN_OK);
            this.P_Footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Footer.Location = new System.Drawing.Point(3, 212);
            this.P_Footer.Name = "P_Footer";
            this.P_Footer.Size = new System.Drawing.Size(337, 30);
            this.P_Footer.TabIndex = 0;
            // 
            // P_Header
            // 
            this.P_Header.Controls.Add(this.L_Header);
            this.P_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Header.Location = new System.Drawing.Point(3, 3);
            this.P_Header.Name = "P_Header";
            this.P_Header.Size = new System.Drawing.Size(337, 32);
            this.P_Header.TabIndex = 1;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(259, 3);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 0;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // L_Header
            // 
            this.L_Header.AutoSize = true;
            this.L_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Header.Location = new System.Drawing.Point(9, 6);
            this.L_Header.Name = "L_Header";
            this.L_Header.Size = new System.Drawing.Size(125, 20);
            this.L_Header.TabIndex = 0;
            this.L_Header.Text = "Enter your input:";
            // 
            // P_Main
            // 
            this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Main.Location = new System.Drawing.Point(3, 41);
            this.P_Main.Name = "P_Main";
            this.P_Main.Size = new System.Drawing.Size(337, 165);
            this.P_Main.TabIndex = 2;
            // 
            // DialogInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 245);
            this.Controls.Add(this.TLP_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input";
            this.TLP_Main.ResumeLayout(false);
            this.P_Footer.ResumeLayout(false);
            this.P_Header.ResumeLayout(false);
            this.P_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.Panel P_Footer;
        private System.Windows.Forms.Panel P_Header;
        private System.Windows.Forms.Button BTN_OK;
        protected internal System.Windows.Forms.Label L_Header;
        protected internal System.Windows.Forms.Panel P_Main;
    }
}