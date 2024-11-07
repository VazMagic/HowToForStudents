namespace HowTo
{
    partial class frmHowTo
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
            this.btnOpenSecondForm = new System.Windows.Forms.Button();
            this.btnDelegates = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImportTextFile = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnDbase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "How To ...";
            // 
            // btnOpenSecondForm
            // 
            this.btnOpenSecondForm.BackColor = System.Drawing.Color.Yellow;
            this.btnOpenSecondForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSecondForm.ForeColor = System.Drawing.Color.Purple;
            this.btnOpenSecondForm.Location = new System.Drawing.Point(12, 105);
            this.btnOpenSecondForm.Name = "btnOpenSecondForm";
            this.btnOpenSecondForm.Size = new System.Drawing.Size(318, 91);
            this.btnOpenSecondForm.TabIndex = 1;
            this.btnOpenSecondForm.Text = "How To Close Form 1 and Open Form 2";
            this.btnOpenSecondForm.UseVisualStyleBackColor = false;
            this.btnOpenSecondForm.Click += new System.EventHandler(this.btnOpenSecondForm_Click);
            // 
            // btnDelegates
            // 
            this.btnDelegates.BackColor = System.Drawing.Color.Yellow;
            this.btnDelegates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelegates.ForeColor = System.Drawing.Color.Purple;
            this.btnDelegates.Location = new System.Drawing.Point(354, 105);
            this.btnDelegates.Name = "btnDelegates";
            this.btnDelegates.Size = new System.Drawing.Size(318, 91);
            this.btnDelegates.TabIndex = 2;
            this.btnDelegates.Text = "Pass Data from Second Form Back To Previous Form";
            this.btnDelegates.UseVisualStyleBackColor = false;
            this.btnDelegates.Click += new System.EventHandler(this.btnDelegates_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Yellow;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Purple;
            this.btnExport.Location = new System.Drawing.Point(355, 219);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(318, 91);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Data To Text File";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImportTextFile
            // 
            this.btnImportTextFile.BackColor = System.Drawing.Color.Yellow;
            this.btnImportTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportTextFile.ForeColor = System.Drawing.Color.Purple;
            this.btnImportTextFile.Location = new System.Drawing.Point(13, 219);
            this.btnImportTextFile.Name = "btnImportTextFile";
            this.btnImportTextFile.Size = new System.Drawing.Size(318, 91);
            this.btnImportTextFile.TabIndex = 3;
            this.btnImportTextFile.Text = "Import Data from a Text File";
            this.btnImportTextFile.UseVisualStyleBackColor = false;
            this.btnImportTextFile.Click += new System.EventHandler(this.btnImportTextFile_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.Yellow;
            this.btnImportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.ForeColor = System.Drawing.Color.Purple;
            this.btnImportExcel.Location = new System.Drawing.Point(13, 331);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(318, 91);
            this.btnImportExcel.TabIndex = 5;
            this.btnImportExcel.Text = "Import/Export XLSX and XML Data with DataGridView";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnDbase
            // 
            this.btnDbase.BackColor = System.Drawing.Color.Yellow;
            this.btnDbase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbase.ForeColor = System.Drawing.Color.Purple;
            this.btnDbase.Location = new System.Drawing.Point(354, 331);
            this.btnDbase.Name = "btnDbase";
            this.btnDbase.Size = new System.Drawing.Size(318, 91);
            this.btnDbase.TabIndex = 6;
            this.btnDbase.Text = "MS Access Database";
            this.btnDbase.UseVisualStyleBackColor = false;
            this.btnDbase.Click += new System.EventHandler(this.btnDbase_Click);
            // 
            // frmHowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 448);
            this.Controls.Add(this.btnDbase);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImportTextFile);
            this.Controls.Add(this.btnDelegates);
            this.Controls.Add(this.btnOpenSecondForm);
            this.Controls.Add(this.label1);
            this.Name = "frmHowTo";
            this.Text = "How To ...";
            this.Load += new System.EventHandler(this.frmHowTo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenSecondForm;
        private System.Windows.Forms.Button btnDelegates;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImportTextFile;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnDbase;
    }
}

