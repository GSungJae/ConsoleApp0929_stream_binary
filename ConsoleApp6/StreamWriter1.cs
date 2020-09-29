using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp6
{
    class StreamWriter1
    {
        [STAThread]
        static void Main()
        {
            // C:\Users\GDC6\source\repos\ConsoleApp6\ConsoleApp6\bin\Debug
            // System.Environment.CurrentDirectory = "C:\\";

            
            SaveFileDialog dlg = new SaveFileDialog();
            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8))
                {
                    sw.WriteLine("ㅎㅇㅎㅇ gdgd {0}", "fsfsdf");
                    sw.WriteLine(11414213);
                    sw.WriteLine("qwDW");
                    sw.Flush();
                    // sw.Close();using을 사용하면 close를 사용할필요가없음.
                }
            }
        }
    }
}
