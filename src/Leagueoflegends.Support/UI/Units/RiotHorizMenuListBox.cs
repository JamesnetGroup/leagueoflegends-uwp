using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;
public class RiotHorizMenuListBox : ListBox
{
    public RiotHorizMenuListBox()
    {
        DefaultStyleKey = typeof(RiotHorizMenuListBox);
        SelectionChanged += RiotHorizMenuListBox_SelectionChanged;
    }

    private void RiotHorizMenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        foreach (var item in e.RemovedItems)
        {
            if (ContainerFromItem(item) is ListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = false;
            }
        }

        foreach (var item in e.AddedItems)
        {
            if (ContainerFromItem(item) is ListBoxItem listBoxItem)
            {
                listBoxItem.IsSelected = true;
            }
        }
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotHorizMenuListBoxItem();
    }
}
