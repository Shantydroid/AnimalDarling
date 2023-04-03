using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDarling.Models
{
    public sealed class RazesDetail
    {
        public ImageSource Image { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public bool IsPar { get; set; }
    }
}
