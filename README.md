# Grouping ListView items by ignoring case sensitivity

Grouping the items by ignoring case sensitive by using the [KeySelector](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.DataSource.Portable~Syncfusion.DataSource.GroupDescriptor~KeySelector.html) property in the [GroupDescriptor](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.DataSource.Portable~Syncfusion.DataSource.GroupDescriptor.html). While returning the `KeySelector`, convert the required property name in the data model to group either as Upper or Lower case. The items will be grouped based on the `KeySelector` with returned case sensitive.

## Sample

```xaml
<listView:SfListView x:Name="listView" ItemSize="100"
                      AutoFitMode="Height"
                      ItemsSource="{Binding ContactsInfo}" 
                      ItemSpacing="10">

  <listView:SfListView.GroupHeaderTemplate>
    <DataTemplate>
      <ViewCell>
        <ViewCell.View>
          <code>
          . . .
          . . .
          <code>
        </ViewCell.View>
      </ViewCell>
    </DataTemplate>
  </listView:SfListView.GroupHeaderTemplate>
  
  <listView:SfListView.ItemTemplate>
    <DataTemplate>
      <ViewCell>
        <ViewCell.View>
          <code>
          . . .
          . . .
          <code>
        </ViewCell.View>
      </ViewCell>
    </DataTemplate>
  </listView:SfListView.ItemTemplate>
</listView:SfListView>
```

```
listView.DataSource.GroupDescriptors.Add(new GroupDescriptor() 
{ 
  PropertyName = "ContactName", 
  KeySelector = (object obj) => 
  { 
    return (obj as Contacts).ContactName.ToUpper()[0];
  } 
});

```

To know more about grouping ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/grouping)