using System.ComponentModel;

namespace AdinaBlazorDataTable.Core
{
    public class SortDiscriptor
    {
        public string ColumnKey { get; set; } = default!;
        public SortDirection Direction { get; set; }
        public enum SortDirection
        {
            Ascending,
            Descending,
        }
    }
}
