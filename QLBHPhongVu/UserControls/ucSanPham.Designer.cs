﻿namespace QLBHPhongVu.UserControls
{
    partial class ucSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSanPham));
            this.lblGiaKM = new System.Windows.Forms.Label();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.lblKM = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblSanCo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGiaKM
            // 
            this.lblGiaKM.AutoSize = true;
            this.lblGiaKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGiaKM.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblGiaKM.Location = new System.Drawing.Point(19, 151);
            this.lblGiaKM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaKM.Name = "lblGiaKM";
            this.lblGiaKM.Size = new System.Drawing.Size(118, 25);
            this.lblGiaKM.TabIndex = 5;
            this.lblGiaKM.Text = "Giá: 200vnd";
            this.lblGiaKM.Click += new System.EventHandler(this.lblGiaKM_Click);
            this.lblGiaKM.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.lblGiaKM.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            // 
            // picSP
            // 
            this.picSP.Image = ((System.Drawing.Image)(resources.GetObject("picSP.Image")));
            this.picSP.Location = new System.Drawing.Point(24, 6);
            this.picSP.Margin = new System.Windows.Forms.Padding(4);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(156, 124);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 4;
            this.picSP.TabStop = false;
            this.picSP.Click += new System.EventHandler(this.picSP_Click);
            this.picSP.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.picSP.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            // 
            // lblKM
            // 
            this.lblKM.BackColor = System.Drawing.Color.Transparent;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.lblKM.ForeColor = System.Drawing.Color.Gold;
            this.lblKM.Location = new System.Drawing.Point(1, 0);
            this.lblKM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(43, 28);
            this.lblKM.TabIndex = 1;
            this.lblKM.Text = "km";
            this.lblKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKM.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.lblKM.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 149);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblGiaGoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGiaGoc.Location = new System.Drawing.Point(21, 176);
            this.lblGiaGoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(47, 15);
            this.lblGiaGoc.TabIndex = 7;
            this.lblGiaGoc.Text = "200vnd";
            this.lblGiaGoc.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.lblGiaGoc.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lblKM);
            this.panel1.Location = new System.Drawing.Point(157, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 31);
            this.panel1.TabIndex = 9;
            this.panel1.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoEllipsis = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenSP.Location = new System.Drawing.Point(21, 133);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(173, 23);
            this.lblTenSP.TabIndex = 6;
            this.lblTenSP.Text = "Tên: Xe";
            this.lblTenSP.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.lblTenSP.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            // 
            // lblSanCo
            // 
            this.lblSanCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblSanCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSanCo.Location = new System.Drawing.Point(112, 178);
            this.lblSanCo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSanCo.Name = "lblSanCo";
            this.lblSanCo.Size = new System.Drawing.Size(89, 22);
            this.lblSanCo.TabIndex = 7;
            this.lblSanCo.Text = "Sẵn có";
            this.lblSanCo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSanCo.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.lblSanCo.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblGiaKM);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.picSP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSanCo);
            this.Controls.Add(this.lblGiaGoc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(203, 202);
            this.Load += new System.EventHandler(this.ucSanPham_Load);
            this.Leave += new System.EventHandler(this.ucSanPham_Leave);
            this.MouseEnter += new System.EventHandler(this.ucSanPham_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucSanPham_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblGiaKM;
        public System.Windows.Forms.PictureBox picSP;
        public System.Windows.Forms.Label lblKM;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblGiaGoc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.Label lblSanCo;
    }
}
