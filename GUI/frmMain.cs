using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        private UserControl[] _userControls;
        private int _indexControl;

        public frmMain()
        {
            InitializeComponent();

            ucLocations uc_locations = new ucLocations();
            uc_locations.Dock = DockStyle.Fill;

            ucTours uc_tours = new ucTours();
            uc_locations.Dock = DockStyle.Fill;
            uc_tours.Hide();

            ucTourDetails uc_tourDetails = new ucTourDetails();
            uc_locations.Dock = DockStyle.Fill;
            uc_tourDetails.Hide();

            _userControls = new UserControl[] { uc_locations, uc_tours, uc_tourDetails };
            _indexControl = 0;

            pnlMain.Controls.AddRange(_userControls);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _userControls[_indexControl].Hide();
            if (_indexControl < _userControls.Length - 1) _indexControl++;
            _userControls[_indexControl].Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _userControls[_indexControl].Hide();
            if (_indexControl > 0) _indexControl--;
            _userControls[_indexControl].Show();
        }
    }
}
