#region Namespaces

using Autorun.inf_Editor.Utilities;

#endregion

namespace Autorun.inf_Editor
{
    /// <summary>
    ///     The <see cref="AutorunFile" /> class.
    /// </summary>
    public class AutorunFile
    {
        public static string Title = "Autorun";

        public static string FileExtension = "inf";

        public static string FileName = Title.ToLower() + "." + FileExtension;

        public static FileDialogFilter AutorunFileDialogFilter = new FileDialogFilter(FileName, FileExtension);

        public static string Header = "[" + Title.ToLower() + "]";

        public static int HeaderLength = Header.Length;
    }
}