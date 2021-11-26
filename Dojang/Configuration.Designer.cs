namespace Dojang
{
    partial class Configuration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBoxPlans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPricePlan = new System.Windows.Forms.TextBox();
            this.btnSavePrice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputAddDays = new System.Windows.Forms.TextBox();
            this.btnAddDays = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputSchedules = new System.Windows.Forms.ComboBox();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scheduleSecond = new System.Windows.Forms.DateTimePicker();
            this.scheduleFirst = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONFIGURACION";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONFIGURAR PLANES";
            // 
            // inputBoxPlans
            // 
            this.inputBoxPlans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBoxPlans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputBoxPlans.FormattingEnabled = true;
            this.inputBoxPlans.Location = new System.Drawing.Point(89, 50);
            this.inputBoxPlans.Name = "inputBoxPlans";
            this.inputBoxPlans.Size = new System.Drawing.Size(116, 23);
            this.inputBoxPlans.TabIndex = 4;
            this.inputBoxPlans.SelectedIndexChanged += new System.EventHandler(this.inputBoxPlans_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRECIO: $";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputPricePlan
            // 
            this.inputPricePlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputPricePlan.Location = new System.Drawing.Point(89, 89);
            this.inputPricePlan.Name = "inputPricePlan";
            this.inputPricePlan.Size = new System.Drawing.Size(116, 23);
            this.inputPricePlan.TabIndex = 6;
            this.inputPricePlan.TextChanged += new System.EventHandler(this.inputPricePlan_TextChanged);
            this.inputPricePlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPricePlan_KeyPress);
            // 
            // btnSavePrice
            // 
            this.btnSavePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnSavePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePrice.Enabled = false;
            this.btnSavePrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnSavePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrice.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSavePrice.ForeColor = System.Drawing.Color.White;
            this.btnSavePrice.Location = new System.Drawing.Point(89, 128);
            this.btnSavePrice.Name = "btnSavePrice";
            this.btnSavePrice.Size = new System.Drawing.Size(116, 23);
            this.btnSavePrice.TabIndex = 29;
            this.btnSavePrice.Text = "GUARDAR";
            this.btnSavePrice.UseVisualStyleBackColor = false;
            this.btnSavePrice.Click += new System.EventHandler(this.btnSavePrice_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "AÑADIR DIAS EXTRAS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "DIAS:";
            // 
            // inputAddDays
            // 
            this.inputAddDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputAddDays.Location = new System.Drawing.Point(75, 50);
            this.inputAddDays.Name = "inputAddDays";
            this.inputAddDays.Size = new System.Drawing.Size(138, 23);
            this.inputAddDays.TabIndex = 32;
            this.inputAddDays.TextChanged += new System.EventHandler(this.inputAddDays_TextChanged);
            this.inputAddDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPricePlan_KeyPress);
            // 
            // btnAddDays
            // 
            this.btnAddDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnAddDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDays.Enabled = false;
            this.btnAddDays.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.btnAddDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDays.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDays.ForeColor = System.Drawing.Color.White;
            this.btnAddDays.Location = new System.Drawing.Point(97, 79);
            this.btnAddDays.Name = "btnAddDays";
            this.btnAddDays.Size = new System.Drawing.Size(116, 23);
            this.btnAddDays.TabIndex = 33;
            this.btnAddDays.Text = "AGREGAR";
            this.btnAddDays.UseVisualStyleBackColor = false;
            this.btnAddDays.Click += new System.EventHandler(this.btnAddDays_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "CONFIGURAR HORARIOS";
            // 
            // inputSchedules
            // 
            this.inputSchedules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputSchedules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSchedules.FormattingEnabled = true;
            this.inputSchedules.Location = new System.Drawing.Point(97, 54);
            this.inputSchedules.Name = "inputSchedules";
            this.inputSchedules.Size = new System.Drawing.Size(125, 23);
            this.inputSchedules.TabIndex = 35;
            this.inputSchedules.SelectedIndexChanged += new System.EventHandler(this.inputSchedules_SelectedIndexChanged);
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSchedule.Enabled = false;
            this.btnDeleteSchedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSchedule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSchedule.Location = new System.Drawing.Point(97, 83);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteSchedule.TabIndex = 36;
            this.btnDeleteSchedule.Text = "ELIMINAR";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "AGREGAR HORARIO:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(123, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "A";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "DE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(208)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(95, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "AGREGAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputBoxPlans);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputPricePlan);
            this.panel1.Controls.Add(this.btnSavePrice);
            this.panel1.Location = new System.Drawing.Point(43, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 245);
            this.panel1.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 47;
            this.label11.Text = "PLANES:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.inputAddDays);
            this.panel2.Controls.Add(this.btnAddDays);
            this.panel2.Location = new System.Drawing.Point(375, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 245);
            this.panel2.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.scheduleSecond);
            this.panel3.Controls.Add(this.scheduleFirst);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.inputSchedules);
            this.panel3.Controls.Add(this.btnDeleteSchedule);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(688, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 245);
            this.panel3.TabIndex = 48;
            // 
            // scheduleSecond
            // 
            this.scheduleSecond.AllowDrop = true;
            this.scheduleSecond.CustomFormat = "hh:mm tt";
            this.scheduleSecond.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.scheduleSecond.Location = new System.Drawing.Point(148, 167);
            this.scheduleSecond.Name = "scheduleSecond";
            this.scheduleSecond.ShowUpDown = true;
            this.scheduleSecond.Size = new System.Drawing.Size(82, 23);
            this.scheduleSecond.TabIndex = 50;
            // 
            // scheduleFirst
            // 
            this.scheduleFirst.AllowDrop = true;
            this.scheduleFirst.CustomFormat = "hh:mm tt";
            this.scheduleFirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.scheduleFirst.Location = new System.Drawing.Point(37, 167);
            this.scheduleFirst.Name = "scheduleFirst";
            this.scheduleFirst.ShowUpDown = true;
            this.scheduleFirst.Size = new System.Drawing.Size(80, 23);
            this.scheduleFirst.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "HORARIOS:";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(975, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox inputBoxPlans;
        private Label label3;
        private TextBox inputPricePlan;
        private Button btnSavePrice;
        private Label label4;
        private Label label5;
        private TextBox inputAddDays;
        private Button btnAddDays;
        private Label label6;
        private ComboBox inputSchedules;
        private Button btnDeleteSchedule;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label11;
        private Label label10;
        private DateTimePicker scheduleFirst;
        private DateTimePicker scheduleSecond;
    }
}