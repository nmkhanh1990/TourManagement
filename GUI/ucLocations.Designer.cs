namespace GUI
{
    partial class ucLocations
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlLocation = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(484, 34);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select locations";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLocation
            // 
            this.pnlLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLocation.HorizontalScrollbar = true;
            this.pnlLocation.HorizontalScrollbarBarColor = true;
            this.pnlLocation.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLocation.HorizontalScrollbarSize = 10;
            this.pnlLocation.Location = new System.Drawing.Point(3, 37);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(484, 296);
            this.pnlLocation.TabIndex = 2;
            this.pnlLocation.VerticalScrollbar = true;
            this.pnlLocation.VerticalScrollbarBarColor = true;
            this.pnlLocation.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLocation.VerticalScrollbarSize = 10;
            // 
            // ucLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ucLocations";
            this.Size = new System.Drawing.Size(490, 336);
            this.Load += new System.EventHandler(this.ucLocations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnlLocation;
    }
}
