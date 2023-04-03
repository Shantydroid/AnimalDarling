using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDarling.Models
{
    public sealed class Razes : ObservableObject
    {        
        public int Id { get; set; }
        public ImageSource Image { get; set; }
        public string Text { get; set; }
        
        private bool isSelected;
        public bool IsSelected { get => isSelected; set => SetProperty(ref isSelected, value); }

    }
}
