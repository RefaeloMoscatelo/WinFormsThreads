using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
  public  class ProgressEventArgs :EventArgs
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public ProgressEventArgs(int min)
        {
                
        }

    }
}
