using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juniper.Core.Models
{
    public class ValidationErrorModel : ObservableObject
    {
        private string error;
        public string Error
        {
            get => error;
            set => SetProperty(ref error, value);
        }

    }
}
