namespace HowTo
{
    partial class frmLabAnalysis
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgLabAnalysis = new System.Windows.Forms.DataGridView();
            this.btnAddLab = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLabAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Magenta;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Lavender;
            this.btnClose.Location = new System.Drawing.Point(803, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Return Home";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgLabAnalysis
            // 
            this.dgLabAnalysis.AllowUserToAddRows = false;
            this.dgLabAnalysis.AllowUserToDeleteRows = false;
            this.dgLabAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLabAnalysis.Location = new System.Drawing.Point(8, 22);
            this.dgLabAnalysis.Name = "dgLabAnalysis";
            this.dgLabAnalysis.ReadOnly = true;
            this.dgLabAnalysis.Size = new System.Drawing.Size(963, 497);
            this.dgLabAnalysis.TabIndex = 1;
            // 
            // btnAddLab
            // 
            this.btnAddLab.BackColor = System.Drawing.Color.Lime;
            this.btnAddLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLab.ForeColor = System.Drawing.Color.Blue;
            this.btnAddLab.Location = new System.Drawing.Point(8, 525);
            this.btnAddLab.Name = "btnAddLab";
            this.btnAddLab.Size = new System.Drawing.Size(168, 38);
            this.btnAddLab.TabIndex = 2;
            this.btnAddLab.Text = "Add Lab";
            this.btnAddLab.UseVisualStyleBackColor = false;
            this.btnAddLab.Click += new System.EventHandler(this.btnAddLab_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(193, 525);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Lab";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmLabAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 575);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddLab);
            this.Controls.Add(this.dgLabAnalysis);
            this.Controls.Add(this.btnClose);
            this.Name = "frmLabAnalysis";
            this.Text = "Lab Analysis";
            this.Load += new System.EventHandler(this.frmLabAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLabAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgLabAnalysis;
        private System.Windows.Forms.Button btnAddLab;
        private System.Windows.Forms.Button btnDelete;
    }
}