
namespace HotelReservation
{
    partial class HotelReservationForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucHotel1 = new HotelReservation.userControls.ucHotel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HotelReservation.Properties.Resources.logo_small;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(164, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucHotel1
            // 
            this.ucHotel1.AutoSize = true;
            this.ucHotel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucHotel1.BackColor = System.Drawing.Color.Transparent;
            this.ucHotel1.Location = new System.Drawing.Point(0, 227);
            this.ucHotel1.MaximumSize = new System.Drawing.Size(2250, 2366);
            this.ucHotel1.Name = "ucHotel1";
            this.ucHotel1.Size = new System.Drawing.Size(1228, 579);
            this.ucHotel1.TabIndex = 1;
            // 
            // HotelReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 818);
            this.Controls.Add(this.ucHotel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "HotelReservationForm";
            this.Text = "Hotel Reservation";
            this.Load += new System.EventHandler(this.HotelReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private userControls.ucHotel ucHotel1;
    }
}

