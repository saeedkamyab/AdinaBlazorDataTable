public class DataTableColumn<TItem>
{
    public string Header { get; set; }
    public string Field { get; set; }

    public object GetValue(TItem item)
    {
        // با Reflection مقدار پراپرتی رو می‌گیریم
        var propertyInfo = typeof(TItem).GetProperty(Field);
        if (propertyInfo != null)
        {
            return propertyInfo.GetValue(item);
        }
        return string.Empty;
    }

    // Constructor ساده
    public DataTableColumn(string header, string field)
    {
        Header = header;
        Field = field;
    }
}