namespace AdinaBlazorDataTable.Core
{
    public class GridRequest
    {
        public int PageIndex { get;  set; } 
        public int PageSize { get;  set; }
        public IReadOnlyList<SortDiscriptor> Sorts { get; set; } = Array.Empty<SortDiscriptor>();
    }
}
