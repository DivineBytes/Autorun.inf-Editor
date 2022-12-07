using System;
using System.IO;
using System.Windows.Forms;

namespace Autorun.inf_Editor
{
    public class AutorunFileEditor
    {
        public delegate void ContentChangedDelegate(object obj, EventArgs args);

        public event ContentChangedDelegate ContentChangedEvent;

        public void ContentChanged()
        {
            SaveState = false;

            if (ContentChangedEvent != null)
            {
                ContentChangedEvent(this, EventArgs.Empty);
            }
        }
    
        /// <summary>
        /// The file save state.
        /// </summary>
        public bool SaveState { get; private set; }

        /// <summary>
        /// The file location path.
        /// </summary>
        public string Location { get; private set; }

        private string _content;

        /// <summary>
        /// The file text contents.
        /// </summary>
        public string Content {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
                ContentChanged();
            }
        }

        /// <summary>
        /// Determines whether the file exists.
        /// </summary>
        public bool FileExists
        {
            get
            {
                if (!string.IsNullOrEmpty(Location))
                {
                    var exists = File.Exists(Location);
                    return exists;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets the save title.
        /// </summary>
        public string SavedTitle
        {
            get
            {
                string saveTitle;
                if (SaveState)
                {
                    saveTitle = Location;
                }
                else
                {
                    saveTitle = "* " + Location;
                }

                return saveTitle;
            }
        }

        /// <summary>
        /// The <see cref="AutorunFileEditor"/> class.
        /// </summary>
        public AutorunFileEditor()
        {
            New();
        }

        /// <summary>
        /// The <see cref="AutorunFileEditor"/> class to open a file.
        /// </summary>
        /// <param name="location">The file location.</param>
        public AutorunFileEditor(string location) : this()
        {
            Open(location);
        }

        /// <summary>
        /// Creates a new document.
        /// </summary>
        public void New()
        {
            Content = string.Empty;
            Location = string.Empty;
            SaveState = false;
        }

        /// <summary>
        /// Open the location content.
        /// </summary>
        /// <returns>The result value.</returns>
        public bool Open()
        {
            if (!string.IsNullOrEmpty(Location))
            {
                if (File.Exists(Location))
                {
                    try
                    {
                        var opened = Open(Location);
                        return opened;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Opens the file using the specified <see cref="location"/>.
        /// </summary>
        /// <param name="location">The file location.</param>
        public bool Open(string location)
        {
            SaveState = false;

            if (!string.IsNullOrEmpty(location))
            {
                if (File.Exists(location))
                {
                    try
                    {
                        Content = File.ReadAllText(location);
                        Location = location;
                        SaveState = true;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Shows the open file dialog.
        /// </summary>
        public bool ShowOpenDialog()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Open",
                    Filter = AutorunFile.AutorunFileDialogFilter.Filter,
                    FileName = ""
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var opened = Open(openFileDialog.FileName);
                    return opened;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        /// <summary>
        /// Asks to save before action.
        /// </summary>
        /// <returns>The result value.</returns>
        public bool AskToSave()
        {
            try
            {
                if (!SaveState)
                {
                    var msgBoxResult = MessageBox.Show("Do you want to save the file?", "Save", MessageBoxButtons.YesNo);
                    if (msgBoxResult == DialogResult.Yes)
                    {
                        return Save();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        /// <summary>
        /// Shows the save as dialog.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>The result value.</returns>
        public bool ShowSaveDialog(string content)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = @"Save",
                    Filter = AutorunFile.AutorunFileDialogFilter.Filter,
                    FileName = AutorunFile.FileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var saved = Save(saveFileDialog.FileName, content);

                    if (saved)
                    {
                        Location = saveFileDialog.FileName;
                        SaveState = true;

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        /// <summary>
        /// Saves the file contents to location.
        /// </summary>
        /// <param name="showDialog">The toggle to show the dialog.</param>
        /// <returns>The result value.</returns>
        public bool Save(bool showDialog)
        {
            SaveState = false;

            if (!FileExists)
            {
                return ShowSaveDialog(Content);
            }

            try
            {
                var saved = false;

                if (showDialog)
                {
                    saved = ShowSaveDialog(Content);
                }
                else
                {
                    saved = Save(Location, Content);
                }

                if (saved)
                {
                    SaveState = true;
                    return true;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        /// <summary>
        /// Saves the file contents to location.
        /// </summary>
        /// <returns>The result value.</returns>
        public bool Save()
        {
            SaveState = false;

            if (!FileExists)
            {
                return false;
            }

            try
            {
                var saved = Save(Location, Content);

                if (saved)
                {
                    SaveState = true;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        /// <summary>
        /// Saves the file contents to location.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="content">The content.</param>
        /// <returns>The return value.</returns>
        public static bool Save(string location, string content)
        {
            if (string.IsNullOrEmpty(location))
            {
                return false;
            }

            try
            {
                if (File.Exists(location))
                {
                    FileInfo fileInfo = new FileInfo(location);

                    string currentDir = Path.GetDirectoryName(Application.ExecutablePath);
                    string fileName = fileInfo.Name;
                    string fullPath = Path.Combine(currentDir, fileName);

                    // Bypass: System.UnauthorizedAccessException: Access to the path.
                    File.WriteAllText(fullPath, content);
                    File.SetAttributes(location, FileAttributes.Normal);
                    File.Copy(fullPath, location, true);
                    File.Delete(fullPath);
                }
                else
                {
                    File.WriteAllText(location, content);
                }
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }
    }
}
