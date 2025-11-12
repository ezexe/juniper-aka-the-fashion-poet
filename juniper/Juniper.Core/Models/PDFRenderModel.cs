using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juniper.Core.Models
{
    public class PDFRenderModel : ObservableObject
    {
        private string pdfSrc;
        public string PDFSrc
        {
            get => pdfSrc;
            set => SetProperty(ref pdfSrc, value);
        }

        private object imgSrc;
        public object ImgSrc
        {
            get => imgSrc;
            set => SetProperty(ref imgSrc, value);
        }

    }
}
