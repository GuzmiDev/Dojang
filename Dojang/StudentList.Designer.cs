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
            this.inputPhoneStudentList = new System.Windows.Forms.TextBox();
            this.inputLastNameStudentList = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNameStudentList = new System.Windows.Forms.TextBox();
            this.inputScheduleStudentList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputBeltStudentList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPlanStudentList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgPerfil = new WinFormsApp1.Controls.CircularPictureBox();
            this.btnSaveBarCode = new System.Windows.Forms.Button();
            this.panelContainerBarCode = new System.Windows.Forms.Panel();
            this.nameStudentBarCode = new System.Windows.Forms.Label();
            this.panelBarCode = new System.Windows.Forms.Panel();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProlong = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panelContainerBarCode.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.Controls.Add(this.inputPhoneStudentList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputLastNameStudentList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputNameStudentList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputScheduleStudentList, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputBeltStudentList, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(617, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 179);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputPhoneStudentList
            // 
            this.inputPhoneStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPhoneStudentList.Location = new System.Drawing.Point(122, 76);
            this.inputPhoneStudentList.Name = "inputPhoneStudentList";
            this.inputPhoneStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputPhoneStudentList.TabIndex = 11;
            // 
            // inputLastNameStudentList
            // 
            this.inputLastNameStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLastNameStudentList.Location = new System.Drawing.Point(122, 41);
            this.inputLastNameStudentList.Name = "inputLastNameStudentList";
            this.inputLastNameStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputLastNameStudentList.TabIndex = 6;
            this.inputLastNameStudentList.TextChanged += new System.EventHandler(this.inputLastNameStudentList_TextChanged);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(113, 35);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "NOMBRE:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDOS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputNameStudentList
            // 
            this.inputNameStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNameStudentList.Location = new System.Drawing.Point(122, 6);
            this.inputNameStudentList.Name = "inputNameStudentList";
            this.inputNameStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputNameStudentList.TabIndex = 5;
            this.inputNameStudentList.TextChanged += new System.EventHandler(this.inputNameStudentList_TextChanged);
            // 
            // inputScheduleStudentList
            // 
            this.inputScheduleStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputScheduleStudentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputScheduleStudentList.FormattingEnabled = true;
            this.inputScheduleStudentList.Location = new System.Drawing.Point(122, 148);
            this.inputScheduleStudentList.Name = "inputScheduleStudentList";
            this.inputScheduleStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputScheduleStudentList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "CINTA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputBeltStudentList
            // 
            this.inputBeltStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBeltStudentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputBeltStudentList.FormattingEnabled = true;
            this.inputBeltStudentList.Location = new System.Drawing.Point(122, 111);
            this.inputBeltStudentList.Name = "inputBeltStudentList";
            this.inputBeltStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputBeltStudentList.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "HORARIO:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "TELEFONO:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "PLAN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputPlanStudentList
            // 
            this.inputPlanStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPlanStudentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputPlanStudentList.FormattingEnabled = true;
            this.inputPlanStudentList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputPlanStudentList.Location = new System.Drawing.Point(116, 3);
            this.inputPlanStudentList.Name = "inputPlanStudentList";
            this.inputPlanStudentList.Size = new System.Drawing.Size(208, 23);
            this.inputPlanStudentList.TabIndex = 9;
            this.inputPlanStudentList.SelectedIndexChanged += new System.EventHandler(this.inputPlanStudentList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.dataGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.Name,
            this.LastName,
            this.Belt,
            this.Schedule,
            this.Plan,
            this.PhoneColumn,
            this.Cancelation});
            this.dataGridStudents.Location = new System.Drawing.Point(23, 118);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowTemplate.Height = 25;
            this.dataGridStudents.Size = new System.Drawing.Size(585, 469);
            this.dataGridStudents.TabIndex = 2;
            this.dataGridStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellClick);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "No";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Apellidos";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Belt
            // 
            this.Belt.HeaderText = "Cinta";
            this.Belt.Name = "Belt";
            this.Belt.ReadOnly = true;
            // 
            // Schedule
            // 
            this.Schedule.HeaderText = "Horario";
            this.Schedule.Name = "Schedule";
            this.Schedule.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "Telefono";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            // 
            // Cancelation
            // 
            this.Cancelation.HeaderText = "Cancelación";
            this.Cancelation.Name = "Cancelation";
            this.Cancelation.ReadOnly = true;
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
            this.imgPerfil.Location = new System.Drawing.Point(751, 96);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(87, 87);
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
            this.btnSaveBarCode.Location = new System.Drawing.Point(697, 591);
            this.btnSaveBarCode.Name = "btnSaveBarCode";
            this.btnSaveBarCode.Size = new System.Drawing.Size(200, 23);
            this.btnSaveBarCode.TabIndex = 26;
            this.btnSaveBarCode.Text = "GUARDAR CODIGO";
            this.btnSaveBarCode.UseVisualStyleBackColor = false;
            this.btnSaveBarCode.Click += new System.EventHandler(this.btnSaveBarCode_Click);
            // 
            // panelContainerBarCode
            // 
            this.panelContainerBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainerBarCode.BackColor = System.Drawing.Color.White;
            this.panelContainerBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerBarCode.Controls.Add(this.nameStudentBarCode);
            this.panelContainerBarCode.Controls.Add(this.panelBarCode);
            this.panelContainerBarCode.Location = new System.Drawing.Point(697, 505);
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
            // btnRenew
            // 
            this.btnRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.Location = new System.Drawing.Point(810, 468);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(140, 23);
            this.btnRenew.TabIndex = 27;
            this.btnRenew.Text = "RENOVAR";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Visible = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Location = new System.Drawing.Point(810, 374);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(140, 23);
            this.btnUpdateStudent.TabIndex = 28;
            this.btnUpdateStudent.Text = "CORREGIR";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Visible = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inputPlanStudentList, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(623, 435);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 27);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // btnProlong
            // 
            this.btnProlong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProlong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnProlong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProlong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnProlong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProlong.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProlong.ForeColor = System.Drawing.Color.White;
            this.btnProlong.Location = new System.Drawing.Point(626, 468);
            this.btnProlong.Name = "btnProlong";
            this.btnProlong.Size = new System.Drawing.Size(140, 23);
            this.btnProlong.TabIndex = 30;
            this.btnProlong.Text = "PROLONGAR";
            this.btnProlong.UseVisualStyleBackColor = false;
            this.btnProlong.Visible = false;
            this.btnProlong.Click += new System.EventHandler(this.btnProlong_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(959, 631);
            this.Controls.Add(this.btnProlong);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnSaveBarCode);
            this.Controls.Add(this.panelContainerBarCode);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "StudentList";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panelContainerBarCode.ResumeLayout(false);
            this.panelContainerBarCode.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dataGridStudents;
        private WinFormsApp1.Controls.CircularPictureBox imgPerfil;
        private Label labelName;
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
        private Button btnRenew;
        private Button btnUpdateStudent;
        private TextBox inputPhoneStudentList;
        private Label label6;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Belt;
        private DataGridViewTextBoxColumn Schedule;
        private DataGridViewTextBoxColumn Plan;
        private DataGridViewTextBoxColumn PhoneColumn;
        private DataGridViewTextBoxColumn Cancelation;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnProlong;
    }
}