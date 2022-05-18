using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace sınavOtomasyon
{
    internal class gizleGoster
    {
       public void gstr(TextBox tx1)
        {
            if (tx1.ForeColor == Color.Black)
            {
                tx1.ForeColor = Color.White;
            }
            else
            {
                tx1.ForeColor = Color.Black;
            }
        }
    }
}
