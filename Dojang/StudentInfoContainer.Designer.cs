namespace Dojang
{
    partial class StudentInfoContainer
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
            this.imgPerfil = new WinFormsApp1.Controls.CircularPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentName = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.daysLeftsLabel = new System.Windows.Forms.Label();
            this.iconError = new System.Windows.Forms.PictureBox();
            this.btnRenew = new System.Windows.Forms.Button();
            this.iconCorrect = new System.Windows.Forms.PictureBox();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.labelBetweenBtns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPerfil
            // 
            this.imgPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.imgPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.imgPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.imgPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.imgPerfil.BorderSize = 2;
            this.imgPerfil.GradientAngle = 50F;
            this.imgPerfil.Location = new System.Drawing.Point(337, 18);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(120, 120);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 0;
            this.imgPerfil.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StudentName
            // 
            this.StudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentName.Font = new System.Drawing.Font("Roboto Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentName.ForeColor = System.Drawing.Color.White;
            this.StudentName.Location = new System.Drawing.Point(142, 206);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(514, 99);
            this.StudentName.TabIndex = 3;
            this.StudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(541, 18);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 19);
            this.dateLabel.TabIndex = 4;
            // 
            // daysLeftsLabel
            // 
            this.daysLeftsLabel.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daysLeftsLabel.ForeColor = System.Drawing.Color.White;
            this.daysLeftsLabel.Location = new System.Drawing.Point(267, 297);
            this.daysLeftsLabel.Name = "daysLeftsLabel";
            this.daysLeftsLabel.Size = new System.Drawing.Size(261, 29);
            this.daysLeftsLabel.TabIndex = 5;
            this.daysLeftsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconError
            // 
            this.iconError.Image = global::Dojang.Properties.Resources.iconmonstr_error_8;
            this.iconError.Location = new System.Drawing.Point(370, 334);
            this.iconError.Name = "iconError";
            this.iconError.Size = new System.Drawing.Size(56, 38);
            this.iconError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconError.TabIndex = 6;
            this.iconError.TabStop = false;
            this.iconError.Visible = false;
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnRenew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.Location = new System.Drawing.Point(337, 390);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(120, 40);
            this.btnRenew.TabIndex = 8;
            this.btnRenew.Text = "RENOVAR";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Visible = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // iconCorrect
            // 
            this.iconCorrect.Image = global::Dojang.Properties.Resources.iconmonstr_check_mark_5;
            this.iconCorrect.Location = new System.Drawing.Point(369, 334);
            this.iconCorrect.Name = "iconCorrect";
            this.iconCorrect.Size = new System.Drawing.Size(56, 38);
            this.iconCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCorrect.TabIndex = 7;
            this.iconCorrect.TabStop = false;
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWeek.ForeColor = System.Drawing.Color.White;
            this.btnWeek.Location = new System.Drawing.Point(215, 390);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(116, 40);
            this.btnWeek.TabIndex = 9;
            this.btnWeek.Text = "SEMANAL";
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Visible = false;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(463, 390);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(116, 40);
            this.btnMonth.TabIndex = 10;
            this.btnMonth.Text = "MENSUAL";
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Visible = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // labelBetweenBtns
            // 
            this.labelBetweenBtns.AutoSize = true;
            this.labelBetweenBtns.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBetweenBtns.ForeColor = System.Drawing.Color.White;
            this.labelBetweenBtns.Location = new System.Drawing.Point(381, 396);
            this.labelBetweenBtns.Name = "labelBetweenBtns";
            this.labelBetweenBtns.Size = new System.Drawing.Size(31, 29);
            this.labelBetweenBtns.TabIndex = 11;
            this.labelBetweenBtns.Text = "O";
            this.labelBetweenBtns.Visible = false;
            // 
            // StudentInfoContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBetweenBtns);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.iconCorrect);
            this.Controls.Add(this.iconError);
            this.Controls.Add(this.daysLeftsLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentInfoContainer";
            this.Text = "StudentInfoContainer";
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsApp1.Controls.CircularPictureBox imgPerfil;
        private PictureBox pictureBox1;
        private Label StudentName;
        private Label dateLabel;
        private Label daysLeftsLabel;
        private PictureBox iconError;
        private Button btnRenew;
        private PictureBox iconCorrect;
        private Button btnWeek;
        private Button btnMonth;
        private Label labelBetweenBtns;
    }
}