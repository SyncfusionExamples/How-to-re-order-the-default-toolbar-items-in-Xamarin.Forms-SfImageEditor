using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageEditorReorderToolbar
{
    public partial class MainPage : ContentPage
    {
        
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
    }
}

