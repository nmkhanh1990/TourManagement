namespace GUI
{
    partial class ucExpandButton
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
            this.btnExpand = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnExpand
            // 
            this.btnExpand.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExpand.Location = new System.Drawing.Point(1, 1);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(192, 48);
            this.btnExpand.TabIndex = 0;
            this.btnExpand.Text = "metroButton1";
            this.btnExpand.UseSelectable = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // ucExpandButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.btnExpand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucExpandButton";
            this.Size = new System.Drawing.Size(195, 50);
            this.Load += new System.EventHandler(this.ucExpandButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnExpand;
    }
}
