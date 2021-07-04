
namespace HotelReservation.userControls
{
    partial class ucChambre
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
            this.components = new System.ComponentModel.Container();
            this.ucMenuRes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.réserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ucMenuRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMenuRes
            // 
            this.ucMenuRes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ucMenuRes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réserverToolStripMenuItem,
            this.libérerToolStripMenuItem});
            this.ucMenuRes.Name = "ucMenuRes";
            this.ucMenuRes.Size = new System.Drawing.Size(151, 68);
            // 
            // réserverToolStripMenuItem
            // 
            this.réserverToolStripMenuItem.Name = "réserverToolStripMenuItem";
            this.réserverToolStripMenuItem.Size = new System.Drawing.Size(150, 32);
            this.réserverToolStripMenuItem.Text = "Réserver";
            this.réserverToolStripMenuItem.Click += new System.EventHandler(this.réserverToolStripMenuItem_Click);
            // 
            // libérerToolStripMenuItem
            // 
            this.libérerToolStripMenuItem.Name = "libérerToolStripMenuItem";
            this.libérerToolStripMenuItem.Size = new System.Drawing.Size(150, 32);
            this.libérerToolStripMenuItem.Text = "Libérer";
            this.libérerToolStripMenuItem.Click += new System.EventHandler(this.libérerToolStripMenuItem_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(16, 15);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(41, 29);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "    ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblType.Location = new System.Drawing.Point(116, 15);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(184, 29);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "type of chambre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reserver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.ucMenuRes;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblNum);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucChambre";
            this.Size = new System.Drawing.Size(300, 167);
            this.ucMenuRes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ucMenuRes;
        private System.Windows.Forms.ToolStripMenuItem réserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libérerToolStripMenuItem;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button button1;
    }
}
