using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frequenz.View
{
    public class UpdateView
    {
        public void Update(Control child, Control parent)
        {
            parent.Hide();
            GroupBox box = new GroupBox();
            box.Parent = parent;
            box.Location = parent.Location;
            box.Text = "sdfjsdfbskhdbfj<dbfj<bdfj<bdjfb<sjdbf<jsd fj <bvsdjfb<jsdfus";
            box.BringToFront();
        }
    }
}
