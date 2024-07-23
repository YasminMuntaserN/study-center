using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BL_
{
    public class MeetingPattern
    {
        public int PatternID { get; set; }
        public string PatternName { get; set; }

        public override string ToString()
        {
            return PatternName; // This is what will be displayed in the ComboBox
        }
    }

}
