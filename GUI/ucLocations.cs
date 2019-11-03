using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucLocations : UserControl
    {
        public ucLocations()
        {
            InitializeComponent();
        }

        private void ucLocations_Load(object sender, EventArgs e)
        {
            ucExpandButton expandButton1 = new ucExpandButton();
            expandButton1.ListData = new List<string> { "abc", "def" };
            expandButton1.ItemType = ControlType.CheckBox;
            pnlLocation.Controls.Add(expandButton1);

            ucExpandButton expandButton2 = new ucExpandButton();
            expandButton2.NextLocation(expandButton1, pnlLocation.Width);
            expandButton2.ListData = new List<string> { "ghi", "klm" };
            expandButton2.ItemType = ControlType.CheckBox;
            pnlLocation.Controls.Add(expandButton2);
        }
    }
}
