namespace Proekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCrocodile = new System.Windows.Forms.PictureBox();
            this.pbKid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrocodile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKid)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCrocodile
            // 
            this.pbCrocodile.BackColor = System.Drawing.Color.Transparent;
            this.pbCrocodile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCrocodile.BackgroundImage")));
            this.pbCrocodile.Location = new System.Drawing.Point(1189, 560);
            this.pbCrocodile.Name = "pbCrocodile";
            this.pbCrocodile.Size = new System.Drawing.Size(567, 398);
            this.pbCrocodile.TabIndex = 0;
            this.pbCrocodile.TabStop = false;
            this.pbCrocodile.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCrocodile_Paint);
            // 
            // pbKid
            // 
            this.pbKid.BackColor = System.Drawing.Color.Transparent;
            this.pbKid.Image = ((System.Drawing.Image)(resources.GetObject("pbKid.Image")));
            this.pbKid.Location = new System.Drawing.Point(14, 565);
            this.pbKid.Name = "pbKid";
            this.pbKid.Size = new System.Drawing.Size(237, 324);
            this.pbKid.TabIndex = 1;
            this.pbKid.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1482, 913);
            this.Controls.Add(this.pbKid);
            this.Controls.Add(this.pbCrocodile);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "CrocoType";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrocodile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCrocodile;
        private System.Windows.Forms.PictureBox pbKid;
    }
}

