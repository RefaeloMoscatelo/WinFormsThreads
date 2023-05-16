using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Report
{
    public delegate void PrimerCheck(int x);
    public class Primer
    {
        public event PrimerCheck PrimerCheckHandler;

        private void OnPrimerCheckHandler(int num)
        {
            if (PrimerCheckHandler!=null)
            {
                PrimerCheckHandler(num);
            }
        }

        
        public void CheckIf(int min, int max)
        {
            
            for (int i = min; i <= max; i++)
            {
               
                if (i%7==0)
                {
                    OnPrimerCheckHandler(i);
                }
            }

        }

        public void CheckAsync(int min, int max)
        {
            Thread t = new Thread(()=>{
                CheckIf(min,max);

            });
            t.IsBackground = true;
            t.Start();


        }

        

    }
}
