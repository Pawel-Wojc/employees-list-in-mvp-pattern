namespace List.View
{
    partial class Form1
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
            this.comboBoxStanowisko = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDealType = new System.Windows.Forms.Label();
            this.textImie = new System.Windows.Forms.TextBox();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonWczytaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProviderImie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNazwisko = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorData = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderImie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNazwisko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStanowisko
            // 
            this.comboBoxStanowisko.FormattingEnabled = true;
            this.comboBoxStanowisko.Items.AddRange(new object[] {
            "Programista",
            "Admin",
            "Sieciowiec"});
            this.comboBoxStanowisko.Location = new System.Drawing.Point(98, 164);
            this.comboBoxStanowisko.Name = "comboBoxStanowisko";
            this.comboBoxStanowisko.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStanowisko.TabIndex = 5;
            this.comboBoxStanowisko.Text = "Programista";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Imię";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(30, 65);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(12, 99);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(81, 13);
            this.labelBirthDate.TabIndex = 3;
            this.labelBirthDate.Text = "Data Urodzenia";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(27, 133);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(39, 13);
            this.labelSalary.TabIndex = 4;
            this.labelSalary.Text = "Pensja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stanowisko";
            // 
            // labelDealType
            // 
            this.labelDealType.AutoSize = true;
            this.labelDealType.Location = new System.Drawing.Point(12, 207);
            this.labelDealType.Name = "labelDealType";
            this.labelDealType.Size = new System.Drawing.Size(76, 13);
            this.labelDealType.TabIndex = 6;
            this.labelDealType.Text = "Rodzaj umowy";
            // 
            // textImie
            // 
            this.textImie.Location = new System.Drawing.Point(98, 33);
            this.textImie.MaxLength = 20;
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(121, 20);
            this.textImie.TabIndex = 1;
            this.textImie.Text = "Paweł";
            // 
            // textNazwisko
            // 
            this.textNazwisko.Location = new System.Drawing.Point(98, 65);
            this.textNazwisko.MaxLength = 20;
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(121, 20);
            this.textNazwisko.TabIndex = 2;
            this.textNazwisko.Text = "Wójcik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dane pracownika";
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
            this.radioButton1.Size = new System.Drawing.Size(100, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Umowa o pracę";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(100, 230);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Umowa zlecenie";
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
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(43, 386);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 22;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonWczytaj
            // 
            this.buttonWczytaj.Location = new System.Drawing.Point(143, 385);
            this.buttonWczytaj.Name = "buttonWczytaj";
            this.buttonWczytaj.Size = new System.Drawing.Size(75, 23);
            this.buttonWczytaj.TabIndex = 23;
            this.buttonWczytaj.Text = "Wczytaj";
            this.buttonWczytaj.UseVisualStyleBackColor = true;
            this.buttonWczytaj.Click += new System.EventHandler(this.buttonWczytaj_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Paweł, Wójcik"});
            this.listBox1.Location = new System.Drawing.Point(319, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(481, 450);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // errorProviderImie
            // 
            this.errorProviderImie.ContainerControl = this;
            // 
            // errorProviderNazwisko
            // 
            this.errorProviderNazwisko.ContainerControl = this;
            // 
            // errorData
            // 
            this.errorData.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonWczytaj);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.numericSalary);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.textImie);
            this.Controls.Add(this.labelDealType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxStanowisko);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderImie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNazwisko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStanowisko;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDealType;
        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonWczytaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProviderImie;
        private System.Windows.Forms.ErrorProvider errorProviderNazwisko;
        private System.Windows.Forms.ErrorProvider errorData;
    }
}

