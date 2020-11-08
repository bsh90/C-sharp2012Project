namespace highschool
{
    partial class frmMAmuzeshi
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
            this.btnKarnameShow = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.yearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highSchoolDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highSchoolDataSet2 = new highschool.HighSchoolDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnkarnamePrint = new System.Windows.Forms.Button();
            this.stuCode = new System.Windows.Forms.Label();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.termBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highSchoolDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highSchoolDataSet3 = new highschool.HighSchoolDataSet3();
            this.txtSCode = new System.Windows.Forms.TextBox();
            this.term = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataSourcePersonel = new highschool.DataSourcePersonel();
            this.dataSourcePersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highSchoolDataSet4 = new highschool.HighSchoolDataSet4();
            this.highSchoolDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearTableAdapter = new highschool.HighSchoolDataSet2TableAdapters.YearTableAdapter();
            this.termTableAdapter = new highschool.HighSchoolDataSet3TableAdapters.TermTableAdapter();
            this.lblTerm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourcePersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourcePersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKarnameShow
            // 
            this.btnKarnameShow.Location = new System.Drawing.Point(95, 136);
            this.btnKarnameShow.Name = "btnKarnameShow";
            this.btnKarnameShow.Size = new System.Drawing.Size(88, 23);
            this.btnKarnameShow.TabIndex = 31;
            this.btnKarnameShow.Text = "مشاهده کارنامه";
            this.btnKarnameShow.UseVisualStyleBackColor = true;
            this.btnKarnameShow.Click += new System.EventHandler(this.btnKarnameShow_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "سال";
            // 
            // cmbYear
            // 
            this.cmbYear.DataSource = this.yearBindingSource;
            this.cmbYear.DisplayMember = "year";
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(12, 13);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(100, 21);
            this.cmbYear.TabIndex = 29;
            this.cmbYear.ValueMember = "YearID";
            // 
            // yearBindingSource
            // 
            this.yearBindingSource.DataMember = "Year";
            this.yearBindingSource.DataSource = this.highSchoolDataSet2BindingSource;
            // 
            // highSchoolDataSet2BindingSource
            // 
            this.highSchoolDataSet2BindingSource.DataSource = this.highSchoolDataSet2;
            this.highSchoolDataSet2BindingSource.Position = 0;
            // 
            // highSchoolDataSet2
            // 
            this.highSchoolDataSet2.DataSetName = "HighSchoolDataSet2";
            this.highSchoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(354, 260);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnkarnamePrint
            // 
            this.btnkarnamePrint.Location = new System.Drawing.Point(12, 136);
            this.btnkarnamePrint.Name = "btnkarnamePrint";
            this.btnkarnamePrint.Size = new System.Drawing.Size(77, 23);
            this.btnkarnamePrint.TabIndex = 27;
            this.btnkarnamePrint.Text = "پرینت کارنامه";
            this.btnkarnamePrint.UseVisualStyleBackColor = true;
            this.btnkarnamePrint.Click += new System.EventHandler(this.btnkarnamePrint_Click);
            // 
            // stuCode
            // 
            this.stuCode.AutoSize = true;
            this.stuCode.Location = new System.Drawing.Point(293, 21);
            this.stuCode.Name = "stuCode";
            this.stuCode.Size = new System.Drawing.Size(76, 13);
            this.stuCode.TabIndex = 23;
            this.stuCode.Text = "کد دانش آموزی";
            // 
            // cmbTerm
            // 
            this.cmbTerm.DataSource = this.termBindingSource;
            this.cmbTerm.DisplayMember = "term";
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(191, 48);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(100, 21);
            this.cmbTerm.TabIndex = 26;
            this.cmbTerm.ValueMember = "termID";
            // 
            // termBindingSource
            // 
            this.termBindingSource.DataMember = "Term";
            this.termBindingSource.DataSource = this.highSchoolDataSet3BindingSource;
            // 
            // highSchoolDataSet3BindingSource
            // 
            this.highSchoolDataSet3BindingSource.DataSource = this.highSchoolDataSet3;
            this.highSchoolDataSet3BindingSource.Position = 0;
            // 
            // highSchoolDataSet3
            // 
            this.highSchoolDataSet3.DataSetName = "HighSchoolDataSet3";
            this.highSchoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSCode
            // 
            this.txtSCode.Location = new System.Drawing.Point(191, 13);
            this.txtSCode.Name = "txtSCode";
            this.txtSCode.Size = new System.Drawing.Size(96, 20);
            this.txtSCode.TabIndex = 25;
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Location = new System.Drawing.Point(329, 56);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(21, 13);
            this.term.TabIndex = 24;
            this.term.Text = "ترم";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataSourcePersonel
            // 
            this.dataSourcePersonel.DataSetName = "DataSourcePersonel";
            this.dataSourcePersonel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSourcePersonelBindingSource
            // 
            this.dataSourcePersonelBindingSource.DataSource = this.dataSourcePersonel;
            this.dataSourcePersonelBindingSource.Position = 0;
            // 
            // highSchoolDataSet4
            // 
            this.highSchoolDataSet4.DataSetName = "HighSchoolDataSet4";
            this.highSchoolDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // highSchoolDataSet4BindingSource
            // 
            this.highSchoolDataSet4BindingSource.DataSource = this.highSchoolDataSet4;
            this.highSchoolDataSet4BindingSource.Position = 0;
            // 
            // yearTableAdapter
            // 
            this.yearTableAdapter.ClearBeforeFill = true;
            // 
            // termTableAdapter
            // 
            this.termTableAdapter.ClearBeforeFill = true;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(221, 94);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(13, 13);
            this.lblTerm.TabIndex = 32;
            this.lblTerm.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = " معدل ترم";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(26, 94);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(13, 13);
            this.lblYear.TabIndex = 34;
            this.lblYear.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "معدل سال";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "نام دانش آموز";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 49);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 37;
            // 
            // frmMAmuzeshi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 437);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.btnKarnameShow);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkarnamePrint);
            this.Controls.Add(this.stuCode);
            this.Controls.Add(this.cmbTerm);
            this.Controls.Add(this.txtSCode);
            this.Controls.Add(this.term);
            this.Name = "frmMAmuzeshi";
            this.Text = "frmHesabdar";
            this.Load += new System.EventHandler(this.frmMAmuzeshi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourcePersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourcePersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKarnameShow;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkarnamePrint;
        private System.Windows.Forms.Label stuCode;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.TextBox txtSCode;
        private System.Windows.Forms.Label term;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource highSchoolDataSet2BindingSource;
        private HighSchoolDataSet2 highSchoolDataSet2;
        private DataSourcePersonel dataSourcePersonel;
        private System.Windows.Forms.BindingSource dataSourcePersonelBindingSource;
        private HighSchoolDataSet4 highSchoolDataSet4;
        private System.Windows.Forms.BindingSource highSchoolDataSet4BindingSource;
        private HighSchoolDataSet3 highSchoolDataSet3;
        private System.Windows.Forms.BindingSource highSchoolDataSet3BindingSource;
        private System.Windows.Forms.BindingSource yearBindingSource;
        private HighSchoolDataSet2TableAdapters.YearTableAdapter yearTableAdapter;
        private System.Windows.Forms.BindingSource termBindingSource;
        private HighSchoolDataSet3TableAdapters.TermTableAdapter termTableAdapter;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}