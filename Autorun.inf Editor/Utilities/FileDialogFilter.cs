namespace Autorun.inf_Editor.Utilities
{
    /// <summary>
    ///     The <see cref="FileDialogFilter" /> class.
    /// </summary>
    public class FileDialogFilter
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FileDialogFilter" /> class.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <param name="extensions">The extensions.</param>
        public FileDialogFilter(string description, params string[] extensions)
        {
            Description = description;
            Extensions = extensions;

            Filter = string.Empty;

            string filter = string.Empty;
            filter += Description + "|";
            for (var index = 0; index < extensions.Length; index++)
            {
                string extension = extensions[index];

                if (index == 0)
                {
                    filter += "*." + extension;
                }
                else
                {
                    filter += ";*." + extension;
                }
            }

            Filter = filter;
        }

        /// <summary>
        ///     Gets the description.
        /// </summary>
        /// <value>
        ///     The description.
        /// </value>
        public string Description { get; }

        /// <summary>
        ///     Gets the filter.
        /// </summary>
        /// <value>
        ///     The filter.
        /// </value>
        public string Filter { get; }

        /// <summary>
        ///     Gets the extensions.
        /// </summary>
        /// <value>
        ///     The extensions.
        /// </value>
        public string[] Extensions { get; }

        /// <summary>
        ///     Merges the filters.
        /// </summary>
        /// <param name="filter1">The filter1.</param>
        /// <param name="filter2">The filter2.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string MergeFilters(FileDialogFilter filter1, FileDialogFilter filter2)
        {
            var mergedFilters = $"{filter1.Filter}|{filter2.Filter}";
            return mergedFilters;
        }

        /// <summary>
        ///     The <see cref="Filters" /> class.
        /// </summary>
        public static class Filters
        {
            public static FileDialogFilter Executable = new FileDialogFilter("Executable File", "exe");
            public static FileDialogFilter AllFiles = new FileDialogFilter("All Files", "*");
            public static FileDialogFilter TextFiles = new FileDialogFilter("Text File", "txt", "log");
            public static FileDialogFilter AssemblyFiles = new FileDialogFilter("Assembly File", "exe", "dll");
        }
    }
}