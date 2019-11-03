using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace GUI
{
    public partial class ucExpandButton : UserControl
    {
        public string ButtonTitle
        {
            get { return btnExpand.Text; }
            set { btnExpand.Text = value; }
        }

        public List<string> ListData { get; set; }

        public ControlType ItemType { get; set; }

        int _expandWidth = 5;
        bool _toggle = false;

        public ucExpandButton()
        {
            InitializeComponent();
        }

        #region functions
        public void NextLocation(Control beforeControl, int parentWidth)
        {
            this.Top = beforeControl.Top;
            this.Left = beforeControl.Right + 5;
            if(this.Right >= parentWidth)
            {
                this.Top += this.Height + 5;
                this.Left = 5;
            }
        }
        #endregion

        private void ucExpandButton_Load(object sender, EventArgs e)
        {
            int beginTop = btnExpand.Bottom + 5;
            foreach (var item in ListData)
            {
                #region create control
                switch (ItemType)
                {
                    case ControlType.CheckBox:
                        MetroCheckBox ckb = new MetroCheckBox();
                        ckb.Top = beginTop;
                        ckb.AutoSize = true;
                        ckb.Text = item.ToString();
                        ckb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
                        this.Controls.Add(ckb);
                        beginTop = ckb.Bottom + 5;
                        _expandWidth += ckb.Height + 5;
                        break;
                }
                #endregion
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            _toggle ^= true;
            if (_toggle) this.Height += _expandWidth;
            else this.Height -= _expandWidth;
        }

    }

    public enum ControlType
    {
        CheckBox,
        Radio
    }
}
