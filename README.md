# How-to-re-order-the-default-toolbar-items-in-Xamarin.Forms-SfImageEditor
This article explains how to re-order the default toolbar items in Syncfusion Xamarin.Forms SfImageEditor control.

Before re-ordering the items, by default it shows like in below

![](https://github.com/SyncfusionExamples/How-to-re-order-the-default-toolbar-items-in-Xamarin.Forms-SfImageEditor/blob/main/Default_ToolbarItems_Arrangement.png)


After re-ordering the items, it will be displayed like in below

 ![](https://github.com/SyncfusionExamples/How-to-re-order-the-default-toolbar-items-in-Xamarin.Forms-SfImageEditor/blob/main/After_ToolbarItems_Reordering.png)


This can be achieved by clearing the default toolbar items in the SfImageEditor control and add the toolbar items based on the index as per your desired which is mentioned in below 
 
**[XAML]**

*Define the SfImageEditor with binding its desired image 
 
 ```
 …
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <Grid Margin="10">
            <imageeditor:SfImageEditor Source="{Binding Image}" x:Name="editor"  />
        </Grid>
    </ContentPage.Content> 
    …
```
**[C#]

*Clear the default toolbar items and arrange the toolbar as per your desired order
 
 ```
   …

public MainPage()
        {
            InitializeComponent();

            var toolbarCollection = new ObservableCollection<Syncfusion.SfImageEditor.XForms.ToolbarItem>(editor.ToolbarSettings.ToolbarItems);
            editor.ToolbarSettings.ToolbarItems.Clear();

            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[2]);
            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[4]);
            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[0]);

            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[3]);
            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[1]);
            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[8]);

            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[6]);
            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[7]);
            editor.ToolbarSettings.ToolbarItems.Add(toolbarCollection[5]);

        }

   …
```

## See also

[How to customize the toolbar items in SfImageEditor](https://help.syncfusion.com/xamarin/image-editor/toolbarcustomization#customize-toolbar-items)

[How to show or hide the toolbar in SfImageEditor](https://help.syncfusion.com/xamarin/image-editor/toolbarcustomization#to-hideshow-toolbar)

[How to customize the toolbar height in SfImageEditor](https://help.syncfusion.com/xamarin/image-editor/toolbarcustomization#toolbarheight-customization)
