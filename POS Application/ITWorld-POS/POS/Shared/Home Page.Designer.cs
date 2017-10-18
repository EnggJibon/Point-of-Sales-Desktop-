namespace POS.Shared
{
    partial class Home_Page
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.TabIndex = 0;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.metroScrollBar1.Maximum = 100;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.ScrollbarSize = 10;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.metroScrollBar1.TabIndex = 0;
            this.metroScrollBar1.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POS.Properties.Resources.Alien_Ink_2560X1600_Abstract_Background;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Name = "Home_Page";
            this.Text = "Home_Page";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}