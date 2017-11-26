using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using UserControl = System.Windows.Controls.UserControl;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using Spire.Doc;
using WebExpress.Applets;
using Spire.Pdf;
using Spire.Pdf.HtmlConverter;
using System.Threading;
using Spire.Doc.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebExpress.WebNote
{
    /// <summary>
    /// Interaction logic for webnote.xaml
    /// </summary>
    public partial class webnote : UserControl
    {

        public webnote()
        {
            InitializeComponent();
            WebNote_Loaded();

        }
        private  void WebNote_Loaded()
        {
            // Document doc = new Document();
            // doc.LoadFromFile(@"E:\googleMap.html", Spire.Doc.FileFormat.Html, XHTMLValidationType.None);
            //System.Drawing.Image img = doc.SaveToImages(0, ImageType.Bitmap);
            // img.Save("Sample.png",System.Drawing.Imaging.ImageFormat.Png);

           
        }

        private void Grid_SizeChanged(object sender, System.Windows.SizeChangedEventArgs e)
        {

        }
      


    }
}
