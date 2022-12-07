#region Namespaces

using Autorun.inf_Editor.Dialogs;
using Autorun.inf_Editor.UserControls;
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

            RTB_Editor.CursorPositionChanged += new EventHandler(RichTextBox_CursorPositionChanged);
            RTB_Editor.SelectionChanged += new EventHandler(RichTextBox_SelectionChanged);

            CreateNewDocument();
        }
        
        private void CreateNewDocument()
        {
            RTB_Editor.Text = AutorunFile.Header;
            RTB_Editor.Select(AutorunFile.HeaderLength, 0);

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
                }

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Open",
                    Filter = AutorunFile.AutorunFileDialogFilter.Filter,
                    FileName = ""
                };

                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    DocumentSaved = true;
                    DocumentLocation = openFileDialog.FileName;
                    RTB_Editor.Text = File.ReadAllText(openFileDialog.FileName);
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
                    int lineNumber = RTB_Editor.GetLineFromCharIndex(RTB_Editor.Text.IndexOf(RTB_Editor.SelectedText));
                    int columnNumber = 0;

                    TSSL_LnColPos.Text = string.Format("Ln {0}, Col {1}", lineNumber, columnNumber);
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

        private void RichTextBox_CursorPositionChanged(object sender, System.EventArgs e)
        {
            int line = RTB_Editor.CurrentLine;
            int col = RTB_Editor.CurrentColumn;
            int pos = RTB_Editor.CurrentPosition;

            TSSL_LnColPos.Text = string.Format("Ln {0}, Col {1}, Pos {2}", line, col, pos);
        }

        private void RichTextBox_SelectionChanged(object sender, System.EventArgs e)
        {
            int start = RTB_Editor.SelectionStart;
            int end = RTB_Editor.SelectionEnd;
            int length = RTB_Editor.SelectionLength;

            TSSL_StartEndLength.Text = string.Format("Start {0}, End {1}, Length {2}", start, end, length);
        }

        private void TSMI_Label_Click(object sender, EventArgs e)
        {
            LabelPanel lp = new LabelPanel();
            lp.Dock = DockStyle.Fill;

            DialogInput di = new DialogInput();
            di.Text = "Create Label";
            di.L_Header.Text = "Enter your label:";
            
            di.P_Main.Controls.Add(lp);

            if (di.ShowDialog(this) == DialogResult.OK)
            {
                var str = string.Format("label={0}", lp.TB_Input.Text);
                WriteDocument(str);
            }
        }

        private void WriteDocument(string line)
        {
            RTB_Editor.Text += Environment.NewLine + line;
        }
    }
}