namespace Dojang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImgStudentPerfil = new WinFormsApp1.Controls.CircularPictureBox();
            this.IdGetter = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.Label();
            this.Belt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgStudentPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Belt)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgStudentPerfil
            // 
            this.ImgStudentPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgStudentPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ImgStudentPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ImgStudentPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.ImgStudentPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ImgStudentPerfil.BorderSize = 2;
            this.ImgStudentPerfil.GradientAngle = 50F;
            this.ImgStudentPerfil.Location = new System.Drawing.Point(523, 34);
            this.ImgStudentPerfil.Name = "ImgStudentPerfil";
            this.ImgStudentPerfil.Size = new System.Drawing.Size(194, 194);
            this.ImgStudentPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgStudentPerfil.TabIndex = 0;
            this.ImgStudentPerfil.TabStop = false;
            this.ImgStudentPerfil.Click += new System.EventHandler(this.ImgStudentPerfil_Click);
            // 
            // IdGetter
            // 
            this.IdGetter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdGetter.Location = new System.Drawing.Point(485, 588);
            this.IdGetter.Name = "IdGetter";
            this.IdGetter.Size = new System.Drawing.Size(288, 23);
            this.IdGetter.TabIndex = 1;
            this.IdGetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // StudentName
            // 
            this.StudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentName.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentName.Location = new System.Drawing.Point(374, 326);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(514, 99);
            this.StudentName.TabIndex = 2;
            this.StudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Belt
            // 
            this.Belt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Belt.BackColor = System.Drawing.Color.Transparent;
            this.Belt.Location = new System.Drawing.Point(513, 215);
            this.Belt.Name = "Belt";
            this.Belt.Size = new System.Drawing.Size(213, 85);
            this.Belt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Belt.TabIndex = 3;
            this.Belt.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ImgStudentPerfil);
            this.Controls.Add(this.Belt);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.IdGetter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImgStudentPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Belt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsApp1.Controls.CircularPictureBox ImgStudentPerfil;
        private TextBox IdGetter;
        private Label StudentName;
        private PictureBox Belt;
    }
}