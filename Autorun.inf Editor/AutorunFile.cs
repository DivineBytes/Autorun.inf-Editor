#region Namespaces

using Autorun.inf_Editor.Utilities;
using System;
using System.IO;

#endregion

namespace Autorun.inf_Editor
{
    /// <summary>
    ///     The <see cref="AutorunFile" /> class.
    /// </summary>
    public class AutorunFile
    {
        public static string FileExtension = "inf";

        public static string FileName = "Autorun." + FileExtension;

        public static FileDialogFilter AutorunFileDialogFilter = new FileDialogFilter(FileName, FileExtension);

        public static string Header = "[autorun]" + Environment.NewLine;

        public static int HeaderLength = Header.Length;

    }
}