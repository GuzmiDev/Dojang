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
            this.label2.Location = new System.Drawing.Point(54, 143);
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
            this.inputBoxPlans.Location = new System.Drawing.Point(54, 165);
            this.inputBoxPlans.Name = "inputBoxPlans";
            this.inputBoxPlans.Size = new System.Drawing.Size(188, 23);
            this.inputBoxPlans.TabIndex = 4;
            this.inputBoxPlans.SelectedIndexChanged += new System.EventHandler(this.inputBoxPlans_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRECIO: $";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputPricePlan
            // 
            this.inputPricePlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputPricePlan.Location = new System.Drawing.Point(126, 202);
            this.inputPricePlan.Name = "inputPricePlan";
            this.inputPricePlan.Size = new System.Drawing.Size(116, 23);
            this.inputPricePlan.TabIndex = 6;
            this.inputPricePlan.TextChanged += new System.EventHandler(this.inputPricePlan_TextChanged);
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
            this.btnSavePrice.Location = new System.Drawing.Point(126, 243);
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
            this.label4.Location = new System.Drawing.Point(363, 143);
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
            this.label5.Location = new System.Drawing.Point(363, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "DIAS:";
            // 
            // inputAddDays
            // 
            this.inputAddDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputAddDays.Location = new System.Drawing.Point(414, 165);
            this.inputAddDays.Name = "inputAddDays";
            this.inputAddDays.Size = new System.Drawing.Size(138, 23);
            this.inputAddDays.TabIndex = 32;
            this.inputAddDays.TextChanged += new System.EventHandler(this.inputAddDays_TextChanged);
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
            this.btnAddDays.Location = new System.Drawing.Point(436, 194);
            this.btnAddDays.Name = "btnAddDays";
            this.btnAddDays.Size = new System.Drawing.Size(116, 23);
            this.btnAddDays.TabIndex = 33;
            this.btnAddDays.Text = "AGREGAR";
            this.btnAddDays.UseVisualStyleBackColor = false;
            this.btnAddDays.Click += new System.EventHandler(this.btnAddDays_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(975, 670);
            this.Controls.Add(this.btnAddDays);
            this.Controls.Add(this.inputAddDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSavePrice);
            this.Controls.Add(this.inputPricePlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputBoxPlans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuration";
            this.Text = "Configuration";
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
    }
}