using System.Linq.Expressions;

namespace AdinaBlazorDataTable.Core
{
    public class ColumnDefinition<TItem>
    {
        public string? Title { get; set; }
        public Expression<Func<TItem,object>>? Field { get; set; }
        public Func<TItem,object?>? ValueAccessor { get;private set; }
        public bool Sortable { get; set; }
        internal void Compile()
        {
            if (Field != null)
            {
                ValueAccessor=Field.Compile();
            }
        }

    }
}
