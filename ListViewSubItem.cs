
namespace Tennis_Score_App
{
    internal class ListViewSubItem
    {
        public string Text { get; internal set; }

        public static implicit operator ListViewSubItem(ListViewItem.ListViewSubItem v)
        {
            throw new NotImplementedException();
        }
    }
}