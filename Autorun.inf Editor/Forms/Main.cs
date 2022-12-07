﻿#region Namespaces

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace Autorun.inf_Editor.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            CreateNewDocument();
        }
        
        private void CreateNewDocument()
        {
            RTB_Editor.Text = AutorunFile.Header;
            RTB_Editor.Select(RTB_Editor.TextLength, 1);

            DocumentLocation = string.Empty;
            DocumentSaved = true;
        }

        public static bool DocumentSaved { get; set; }
        
        public static string DocumentLocation { get; set; }

        private void TSMI_New_Click(object sender, EventArgs e)
        {
            try
            {
                var saved = AskToSaveDocument(RTB_Editor.Text);
                CreateNewDocument();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void TSMI_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DocumentSaved)
                {
                    var saved = SaveDocument(RTB_Editor.Text);

                    if (saved)
                    {
                        CreateNewDocument();
                    }
                }
                else
                {
                    CreateNewDocument();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                AskToSaveDocument(RTB_Editor.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Application.Exit();
        }

        private static bool AskToSaveDocument(string document)
        {
            if (string.IsNullOrEmpty(document))
            {
                return false;
            }

            try
            {
                if (!DocumentSaved)
                {
                    // Ask to save document.
                    string message = "Do you want to save the document?";
                    string title = "Save";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Yes)
                    {
                        var saved = SaveDocument(document);
                        return saved;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        private static bool SaveDocument(string document)
        {
            if (string.IsNullOrEmpty(document))
            {
                DocumentSaved = false;
                return false;
            }

            try
            {
                if (!DocumentSaved)
                {
                    if (!string.IsNullOrEmpty(DocumentLocation) && File.Exists(DocumentLocation)) // Save
                    {
                        File.WriteAllText(DocumentLocation, document);
                    }
                    else // Save As...
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Title = @"Save",
                            Filter = AutorunFile.AutorunFileDialogFilter.Filter,
                            FileName = AutorunFile.FileName
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DocumentLocation = saveFileDialog.FileName;
                            File.WriteAllText(saveFileDialog.FileName, document);
                        }
                    }

                    DocumentSaved = true;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            DocumentSaved = false;
            return false;
        }

        private void TSMI_Save_Click(object sender, EventArgs e)
        {
            SaveDocument(RTB_Editor.Text);
        }

        private void TSMI_SaveAs_Click(object sender, EventArgs e)
        {
            try
            {
               var saved = SaveDocument(RTB_Editor.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void RTB_Editor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DocumentSaved = false;

                if (RTB_Editor.TextLength > 0)
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                AskToSaveDocument(RTB_Editor.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}