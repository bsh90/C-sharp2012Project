namespace highschool
{
    partial class frmNazem
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
            this.txtSID = new System.Windows.Forms.TextBox();
            this.lblSID = new System.Windows.Forms.Label();
            this.mtbClass = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnSabtG = new System.Windows.Forms.Button();
            this.highSchoolDataSet5 = new highschool.HighSchoolDataSet5();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new highschool.HighSchoolDataSet5TableAdapters.ClassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(177, 12);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(80, 20);
            this.txtSID.TabIndex = 0;
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(263, 15);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(76, 13);
            this.lblSID.TabIndex = 1;
            this.lblSID.Text = "کد دانش آموزی";
            // 
            // mtbClass
            // 
            this.mtbClass.AutoSize = true;
            this.mtbClass.Location = new System.Drawing.Point(102, 15);
            this.mtbClass.Name = "mtbClass";
            this.mtbClass.Size = new System.Drawing.Size(62, 13);
            this.mtbClass.TabIndex = 2;
            this.mtbClass.Text = "شماره کلاس";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(287, 70);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(52, 13);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "دلیل غیبت";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(12, 70);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(269, 202);
            this.txtReason.TabIndex = 4;
            // 
            // cmbClass
            // 
            this.cmbClass.DataSource = this.classBindingSource;
            this.cmbClass.DisplayMember = "ClassNO";
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(12, 15);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(84, 21);
            this.cmbClass.TabIndex = 5;
            this.cmbClass.ValueMember = "ClassNO";
            // 
            // btnSabtG
            // 
            this.btnSabtG.Location = new System.Drawing.Point(20, 289);
            this.btnSabtG.Name = "btnSabtG";
            this.btnSabtG.Size = new System.Drawing.Size(75, 23);
            this.btnSabtG.TabIndex = 6;
            this.btnSabtG.Text = "ثبت غیبت";
            this.btnSabtG.UseVisualStyleBackColor = true;
            this.btnSabtG.Click += new System.EventHandler(this.btnSabtG_Click);
            // 
            // highSchoolDataSet5
            // 
            this.highSchoolDataSet5.DataSetName = "HighSchoolDataSet5";
            this.highSchoolDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.highSchoolDataSet5;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // frmNazem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 328);
            this.Controls.Add(this.btnSabtG);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.mtbClass);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.txtSID);
            this.Name = "frmNazem";
            this.Text = "frmMoalem";
            this.Load += new System.EventHandler(this.frmNazem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Label mtbClass;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnSabtG;
        private HighSchoolDataSet5 highSchoolDataSet5;
        private System.Windows.Forms.BindingSource classBindingSource;
        private HighSchoolDataSet5TableAdapters.ClassTableAdapter classTableAdapter;
    }
}