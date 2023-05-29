namespace Models
{
    public class ListItem
    {
        public string TextColor { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;

        public ListItem(string ListItemData, string ListItemDataColor)
        {
            Data = ListItemData;
            TextColor = ListItemDataColor;
        }
    }
}
