using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Swifter1
{
    class Class1
    {
        public int check = 0;
        public void main()
        {
            test ts = new test();
            bluetooth bt = new bluetooth();
            dark dt = new dark();
            
            try
            {
                MessageBox.Show(dt.main(0).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
