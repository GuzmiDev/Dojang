namespace Dojang
{
    partial class StudentList
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputLastNameStudentList = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputNameStudentList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.imgPerfil = new WinFormsApp1.Controls.CircularPictureBox();
            this.btnSaveBarCode = new System.Windows.Forms.Button();
            this.panelContainerBarCode = new System.Windows.Forms.Panel();
            this.nameStudentBarCode = new System.Windows.Forms.Label();
            this.panelBarCode = new System.Windows.Forms.Panel();
            this.inputBeltStudentList = new System.Windows.Forms.ComboBox();
            this.inputScheduleStudentList = new System.Windows.Forms.ComboBox();
            this.inputPlanStudentList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panelContainerBarCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.Controls.Add(this.inputPlanStudentList, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.inputLastNameStudentList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.inputNameStudentList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputBeltStudentList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputScheduleStudentList, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(614, 250);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputLastNameStudentList
            // 
            this.inputLastNameStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLastNameStudentList.Location = new System.Drawing.Point(122, 45);
            this.inputLastNameStudentList.Name = "inputLastNameStudentList";
            this.inputLastNameStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputLastNameStudentList.TabIndex = 6;
            // 
            // inputName
            // 
            this.inputName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputName.AutoSize = true;
            this.inputName.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputName.ForeColor = System.Drawing.Color.White;
            this.inputName.Location = new System.Drawing.Point(3, 0);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(113, 38);
            this.inputName.TabIndex = 0;
            this.inputName.Text = "NOMBRE:";
            this.inputName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDOS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "CINTA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "HORARIO:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "PLAN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputNameStudentList
            // 
            this.inputNameStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNameStudentList.Location = new System.Drawing.Point(122, 7);
            this.inputNameStudentList.Name = "inputNameStudentList";
            this.inputNameStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputNameStudentList.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALUMNOS";
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(23, 118);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowTemplate.Height = 25;
            this.dataGridStudents.Size = new System.Drawing.Size(585, 469);
            this.dataGridStudents.TabIndex = 2;
            // 
            // imgPerfil
            // 
            this.imgPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.imgPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.imgPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.imgPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.imgPerfil.BorderSize = 2;
            this.imgPerfil.GradientAngle = 50F;
            this.imgPerfil.Location = new System.Drawing.Point(724, 118);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(113, 113);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 3;
            this.imgPerfil.TabStop = false;
            // 
            // btnSaveBarCode
            // 
            this.btnSaveBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnSaveBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBarCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnSaveBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBarCode.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveBarCode.ForeColor = System.Drawing.Color.White;
            this.btnSaveBarCode.Location = new System.Drawing.Point(693, 577);
            this.btnSaveBarCode.Name = "btnSaveBarCode";
            this.btnSaveBarCode.Size = new System.Drawing.Size(200, 23);
            this.btnSaveBarCode.TabIndex = 26;
            this.btnSaveBarCode.Text = "GUARDAR CODIGO";
            this.btnSaveBarCode.UseVisualStyleBackColor = false;
            // 
            // panelContainerBarCode
            // 
            this.panelContainerBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainerBarCode.BackColor = System.Drawing.Color.White;
            this.panelContainerBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerBarCode.Controls.Add(this.nameStudentBarCode);
            this.panelContainerBarCode.Controls.Add(this.panelBarCode);
            this.panelContainerBarCode.Location = new System.Drawing.Point(693, 491);
            this.panelContainerBarCode.Name = "panelContainerBarCode";
            this.panelContainerBarCode.Size = new System.Drawing.Size(200, 70);
            this.panelContainerBarCode.TabIndex = 25;
            // 
            // nameStudentBarCode
            // 
            this.nameStudentBarCode.AutoSize = true;
            this.nameStudentBarCode.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameStudentBarCode.Location = new System.Drawing.Point(3, 53);
            this.nameStudentBarCode.Name = "nameStudentBarCode";
            this.nameStudentBarCode.Size = new System.Drawing.Size(0, 14);
            this.nameStudentBarCode.TabIndex = 1;
            // 
            // panelBarCode
            // 
            this.panelBarCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarCode.Location = new System.Drawing.Point(0, 0);
            this.panelBarCode.Name = "panelBarCode";
            this.panelBarCode.Size = new System.Drawing.Size(198, 50);
            this.panelBarCode.TabIndex = 0;
            // 
            // inputBeltStudentList
            // 
            this.inputBeltStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBeltStudentList.FormattingEnabled = true;
            this.inputBeltStudentList.Location = new System.Drawing.Point(122, 83);
            this.inputBeltStudentList.Name = "inputBeltStudentList";
            this.inputBeltStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputBeltStudentList.TabIndex = 7;
            // 
            // inputScheduleStudentList
            // 
            this.inputScheduleStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputScheduleStudentList.FormattingEnabled = true;
            this.inputScheduleStudentList.Location = new System.Drawing.Point(122, 121);
            this.inputScheduleStudentList.Name = "inputScheduleStudentList";
            this.inputScheduleStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputScheduleStudentList.TabIndex = 8;
            // 
            // inputPlanStudentList
            // 
            this.inputPlanStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPlanStudentList.FormattingEnabled = true;
            this.inputPlanStudentList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputPlanStudentList.Location = new System.Drawing.Point(122, 160);
            this.inputPlanStudentList.Name = "inputPlanStudentList";
            this.inputPlanStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputPlanStudentList.TabIndex = 9;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(959, 631);
            this.Controls.Add(this.btnSaveBarCode);
            this.Controls.Add(this.panelContainerBarCode);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panelContainerBarCode.ResumeLayout(false);
            this.panelContainerBarCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dataGridStudents;
        private WinFormsApp1.Controls.CircularPictureBox imgPerfil;
        private Label inputName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSaveBarCode;
        private Panel panelContainerBarCode;
        private Label nameStudentBarCode;
        private Panel panelBarCode;
        private TextBox inputLastNameStudentList;
        private TextBox inputNameStudentList;
        private ComboBox inputPlanStudentList;
        private ComboBox inputBeltStudentList;
        private ComboBox inputScheduleStudentList;
    }
}