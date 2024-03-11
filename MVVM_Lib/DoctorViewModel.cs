using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Lib
{
    public class DoctorViewModel
    {
        public int DoctorID { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public bool GPTDoctor {  get; set; }
        public Uri DoctorLink { get; set; }
    }
}
