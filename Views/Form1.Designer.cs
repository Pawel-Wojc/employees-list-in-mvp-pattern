namespace List.View
{
    partial class Employees
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxposition = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelBirrthDate = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDealType = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvidername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidersurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorData = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidersurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxposition
            // 
            this.comboBoxposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxposition.Items.AddRange(new object[] {
            "Developer",
            "Administrator",
            "Networker",
            "Recruiter"});
            this.comboBoxposition.Location = new System.Drawing.Point(98, 164);
            this.comboBoxposition.Name = "comboBoxposition";
            this.comboBoxposition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxposition.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(30, 65);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname";
            // 
            // labelBirrthDate
            // 
            this.labelBirrthDate.AutoSize = true;
            this.labelBirrthDate.Location = new System.Drawing.Point(12, 99);
            this.labelBirrthDate.Name = "labelBirrthDate";
            this.labelBirrthDate.Size = new System.Drawing.Size(65, 13);
            this.labelBirrthDate.TabIndex = 3;
            this.labelBirrthDate.Text = "Date of birth";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(27, 133);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(36, 13);
            this.labelSalary.TabIndex = 4;
            this.labelSalary.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Position";
            // 
            // labelDealType
            // 
            this.labelDealType.AutoSize = true;
            this.labelDealType.Location = new System.Drawing.Point(12, 207);
            this.labelDealType.Name = "labelDealType";
            this.labelDealType.Size = new System.Drawing.Size(70, 13);
            this.labelDealType.TabIndex = 6;
            this.labelDealType.Text = "Contract type";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(98, 33);
            this.textname.MaxLength = 20;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(121, 20);
            this.textname.TabIndex = 1;
            this.textname.Text = "Paweł";
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(98, 65);
            this.textsurname.MaxLength = 20;
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(121, 20);
            this.textsurname.TabIndex = 2;
            this.textsurname.Text = "Wójcik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Employee Details";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(98, 99);
            this.dateTimePicker.MaxDate = new System.DateTime(2023, 3, 29, 20, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2023, 3, 29, 0, 0, 0, 0);
            // 
            // numericSalary
            // 
            this.numericSalary.Location = new System.Drawing.Point(98, 133);
            this.numericSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericSalary.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(121, 20);
            this.numericSalary.TabIndex = 4;
            this.numericSalary.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(100, 207);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "indefinite contract";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(100, 230);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "fixed-term contract";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(100, 253);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "B2B";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(15, 327);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(259, 23);
            this.buttonDodaj.TabIndex = 21;
            this.buttonDodaj.Text = "Add";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(43, 386);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(143, 385);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 23;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(319, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(481, 450);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // errorProvidername
            // 
            this.errorProvidername.ContainerControl = this;
            // 
            // errorProvidersurname
            // 
            this.errorProvidersurname.ContainerControl = this;
            // 
            // errorData
            // 
            this.errorData.ContainerControl = this;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.numericSalary);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textsurname);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.labelDealType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelBirrthDate);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxposition);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Employees";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidersurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxposition;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelBirrthDate;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDealType;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvidername;
        private System.Windows.Forms.ErrorProvider errorProvidersurname;
        private System.Windows.Forms.ErrorProvider errorData;
    }
}

