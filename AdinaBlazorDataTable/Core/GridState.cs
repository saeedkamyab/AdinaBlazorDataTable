namespace AdinaBlazorDataTable.Core
{
    public class GridState<TItem>
    {
        public IReadOnlyList<TItem> Items { get;private set; }=Array.Empty<TItem>();
        public List<ColumnDefinition<TItem>> Columns { get; }=new ();
        public List<SortDiscriptor> Sorts { get; }=new ();
        public int PageIndex { get; private set; } = 0;
        public int PageSize { get; private set; } = 20;
        public int TotalCount { get; private set; } 
        public void SetData(IEnumerable<TItem> items,int? totalcount=null)
        {
            Items = items.ToList();
            TotalCount=totalcount?? items.Count();
        }
        public void SetPage(int pageIndex,int pageSize)
        {
            PageIndex=pageIndex;
            PageSize = pageSize;
        }
    }
}
