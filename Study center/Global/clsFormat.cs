using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_center.Global
{
    public class clsFormat
    {
        public static string DateToShort(DateTime Dt1) =>  Dt1.ToString("dd/MMM/yyyy");
    }
}
