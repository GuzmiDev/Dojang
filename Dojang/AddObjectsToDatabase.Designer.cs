namespace Dojang
{
    partial class AddObjectsToDatabase
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
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.btnSaveToDataBase = new System.Windows.Forms.Button();
            this.inputNameBelt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(258, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Location = new System.Drawing.Point(258, 154);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(92, 26);
            this.btnUploadImg.TabIndex = 1;
            this.btnUploadImg.Text = "Cargar";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // btnSaveToDataBase
            // 
            this.btnSaveToDataBase.Location = new System.Drawing.Point(386, 154);
            this.btnSaveToDataBase.Name = "btnSaveToDataBase";
            this.btnSaveToDataBase.Size = new System.Drawing.Size(95, 27);
            this.btnSaveToDataBase.TabIndex = 2;
            this.btnSaveToDataBase.Text = "Guardar";
            this.btnSaveToDataBase.UseVisualStyleBackColor = true;
            this.btnSaveToDataBase.Click += new System.EventHandler(this.btnSaveToDataBase_Click);
            // 
            // inputNameBelt
            // 
            this.inputNameBelt.Location = new System.Drawing.Point(256, 198);
            this.inputNameBelt.Name = "inputNameBelt";
            this.inputNameBelt.Size = new System.Drawing.Size(225, 23);
            this.inputNameBelt.TabIndex = 3;
            // 
            // AddObjectsToDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputNameBelt);
            this.Controls.Add(this.btnSaveToDataBase);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddObjectsToDatabase";
            this.Text = "AddObjectsToDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnUploadImg;
        private Button btnSaveToDataBase;
        private TextBox inputNameBelt;
    }
}