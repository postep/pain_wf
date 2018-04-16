namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderMake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxReverseFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxActivateFilter = new System.Windows.Forms.CheckBox();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMake,
            this.columnHeaderModel,
            this.columnHeaderType,
            this.columnHeaderYear,
            this.columnHeaderPlate,
            this.columnHeaderSpeed});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 271);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderMake
            // 
            this.columnHeaderMake.Text = "Marka";
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Model";
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.DisplayIndex = 5;
            this.columnHeaderType.Text = "Rodzaj";
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.Text = "Rok prod.";
            // 
            // columnHeaderPlate
            // 
            this.columnHeaderPlate.Text = "Nr. rej.";
            // 
            // columnHeaderSpeed
            // 
            this.columnHeaderSpeed.DisplayIndex = 2;
            this.columnHeaderSpeed.Text = "Prędkość maks.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxReverseFilter);
            this.groupBox1.Controls.Add(this.checkBoxActivateFilter);
            this.groupBox1.Controls.Add(this.numericUpDownMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownMin);
            this.groupBox1.Location = new System.Drawing.Point(13, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtr maksymalnej prędkości";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxReverseFilter
            // 
            this.checkBoxReverseFilter.AutoSize = true;
            this.checkBoxReverseFilter.Location = new System.Drawing.Point(329, 33);
            this.checkBoxReverseFilter.Name = "checkBoxReverseFilter";
            this.checkBoxReverseFilter.Size = new System.Drawing.Size(88, 17);
            this.checkBoxReverseFilter.TabIndex = 10;
            this.checkBoxReverseFilter.Text = "Filtr odwrotny";
            this.checkBoxReverseFilter.UseVisualStyleBackColor = true;
            this.checkBoxReverseFilter.CheckedChanged += new System.EventHandler(this.checkBoxReverseFilter_CheckedChanged);
            // 
            // checkBoxActivateFilter
            // 
            this.checkBoxActivateFilter.AutoSize = true;
            this.checkBoxActivateFilter.Location = new System.Drawing.Point(329, 15);
            this.checkBoxActivateFilter.Name = "checkBoxActivateFilter";
            this.checkBoxActivateFilter.Size = new System.Drawing.Size(79, 17);
            this.checkBoxActivateFilter.TabIndex = 9;
            this.checkBoxActivateFilter.Text = "Aktywuj filtr";
            this.checkBoxActivateFilter.UseVisualStyleBackColor = true;
            this.checkBoxActivateFilter.CheckedChanged += new System.EventHandler(this.checkBoxActivateFilter_CheckedChanged);
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(152, 36);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMax.TabIndex = 8;
            this.numericUpDownMax.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMax.ValueChanged += new System.EventHandler(this.numericUpDownMax_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wartość maks.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wartość min.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(152, 13);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMin.TabIndex = 5;
            this.numericUpDownMin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Modyfikuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 411);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Samochody";
            this.Load += new System.EventHandler(this.formLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderMake;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderSpeed;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.ColumnHeader columnHeaderPlate;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxReverseFilter;
        private System.Windows.Forms.CheckBox checkBoxActivateFilter;
        private System.Windows.Forms.Button button3;
    }
}