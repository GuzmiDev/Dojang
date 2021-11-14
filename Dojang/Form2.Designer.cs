namespace Dojang
{
    partial class Form2
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
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePerfil = new System.Windows.Forms.DataGridViewImageColumn();
            this.rjComboBox1 = new Dojang.Controls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDatos
            // 
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.Name,
            this.CancelationDate,
            this.ImagePerfil});
            this.tablaDatos.Location = new System.Drawing.Point(8, 123);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.RowTemplate.Height = 25;
            this.tablaDatos.Size = new System.Drawing.Size(781, 220);
            this.tablaDatos.TabIndex = 0;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // CancelationDate
            // 
            this.CancelationDate.HeaderText = "CancelationDate";
            this.CancelationDate.Name = "CancelationDate";
            // 
            // ImagePerfil
            // 
            this.ImagePerfil.HeaderText = "ImagePerfil";
            this.ImagePerfil.Name = "ImagePerfil";
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.rjComboBox1.BorderColor = System.Drawing.Color.Transparent;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(126, 52);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 1;
            this.rjComboBox1.Texts = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(126, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 2);
            this.label1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjComboBox1);
            this.Controls.Add(this.tablaDatos);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView tablaDatos;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn CancelationDate;
        private DataGridViewImageColumn ImagePerfil;
        private Controls.RJComboBox rjComboBox1;
        private Label label1;
    }
}