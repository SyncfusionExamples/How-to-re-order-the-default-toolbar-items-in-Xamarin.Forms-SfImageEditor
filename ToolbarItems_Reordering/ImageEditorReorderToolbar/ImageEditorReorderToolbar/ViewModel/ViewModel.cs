using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ImageEditorReorderToolbar
{
  public class ViewModel
    {
        public ImageSource Image { get; set; }

        public ViewModel()
        {
            Image = ImageSource.FromResource("ImageEditorReorderToolbar.Image.jpeg");
        }
    }
}
