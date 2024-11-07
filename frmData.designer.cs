
namespace HowTo
{
    partial class frmData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmData));
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImportXML = new System.Windows.Forms.Button();
            this.gbCriteria = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbFlood = new System.Windows.Forms.RadioButton();
            this.rbEarthquake = new System.Windows.Forms.RadioButton();
            this.rbBusinessType = new System.Windows.Forms.RadioButton();
            this.rbConstruction = new System.Windows.Forms.RadioButton();
            this.rbRegion = new System.Windows.Forms.RadioButton();
            this.rbState = new System.Windows.Forms.RadioButton();
            this.rbLocation = new System.Windows.Forms.RadioButton();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkNotInsurance = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.gbCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(17, 141);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(133, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Criteria";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Green;
            this.btnSearch.Location = new System.Drawing.Point(615, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(20, 169);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(589, 35);
            this.txtSearch.TabIndex = 2;
            // 
            // grdData
            // 
            this.grdData.AllowUserToOrderColumns = true;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(20, 302);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(694, 150);
            this.grdData.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Blue;
            this.btnImport.Location = new System.Drawing.Point(16, 54);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(694, 36);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "&Import Excel Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Purple;
            this.btnExport.Location = new System.Drawing.Point(21, 458);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 34);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(639, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImportXML
            // 
            this.btnImportXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportXML.ForeColor = System.Drawing.Color.Blue;
            this.btnImportXML.Location = new System.Drawing.Point(16, 100);
            this.btnImportXML.Name = "btnImportXML";
            this.btnImportXML.Size = new System.Drawing.Size(694, 36);
            this.btnImportXML.TabIndex = 7;
            this.btnImportXML.Text = "Import &XML Data";
            this.btnImportXML.UseVisualStyleBackColor = true;
            this.btnImportXML.Click += new System.EventHandler(this.btnImportXML_Click);
            // 
            // gbCriteria
            // 
            this.gbCriteria.Controls.Add(this.btnClear);
            this.gbCriteria.Controls.Add(this.rbFlood);
            this.gbCriteria.Controls.Add(this.rbEarthquake);
            this.gbCriteria.Controls.Add(this.rbBusinessType);
            this.gbCriteria.Controls.Add(this.rbConstruction);
            this.gbCriteria.Controls.Add(this.rbRegion);
            this.gbCriteria.Controls.Add(this.rbState);
            this.gbCriteria.Controls.Add(this.rbLocation);
            this.gbCriteria.Location = new System.Drawing.Point(21, 215);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(693, 47);
            this.gbCriteria.TabIndex = 8;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "Criteria";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(594, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 27);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbFlood
            // 
            this.rbFlood.AutoSize = true;
            this.rbFlood.Location = new System.Drawing.Point(472, 19);
            this.rbFlood.Name = "rbFlood";
            this.rbFlood.Size = new System.Drawing.Size(51, 17);
            this.rbFlood.TabIndex = 6;
            this.rbFlood.TabStop = true;
            this.rbFlood.Text = "Flood";
            this.rbFlood.UseVisualStyleBackColor = true;
            // 
            // rbEarthquake
            // 
            this.rbEarthquake.AutoSize = true;
            this.rbEarthquake.Location = new System.Drawing.Point(386, 19);
            this.rbEarthquake.Name = "rbEarthquake";
            this.rbEarthquake.Size = new System.Drawing.Size(80, 17);
            this.rbEarthquake.TabIndex = 5;
            this.rbEarthquake.TabStop = true;
            this.rbEarthquake.Text = "Earthquake";
            this.rbEarthquake.UseVisualStyleBackColor = true;
            // 
            // rbBusinessType
            // 
            this.rbBusinessType.AutoSize = true;
            this.rbBusinessType.Location = new System.Drawing.Point(290, 19);
            this.rbBusinessType.Name = "rbBusinessType";
            this.rbBusinessType.Size = new System.Drawing.Size(94, 17);
            this.rbBusinessType.TabIndex = 4;
            this.rbBusinessType.TabStop = true;
            this.rbBusinessType.Text = "Business Type";
            this.rbBusinessType.UseVisualStyleBackColor = true;
            // 
            // rbConstruction
            // 
            this.rbConstruction.AutoSize = true;
            this.rbConstruction.Location = new System.Drawing.Point(200, 19);
            this.rbConstruction.Name = "rbConstruction";
            this.rbConstruction.Size = new System.Drawing.Size(84, 17);
            this.rbConstruction.TabIndex = 3;
            this.rbConstruction.TabStop = true;
            this.rbConstruction.Text = "Construction";
            this.rbConstruction.UseVisualStyleBackColor = true;
            // 
            // rbRegion
            // 
            this.rbRegion.AutoSize = true;
            this.rbRegion.Location = new System.Drawing.Point(135, 19);
            this.rbRegion.Name = "rbRegion";
            this.rbRegion.Size = new System.Drawing.Size(59, 17);
            this.rbRegion.TabIndex = 2;
            this.rbRegion.TabStop = true;
            this.rbRegion.Text = "Region";
            this.rbRegion.UseVisualStyleBackColor = true;
            // 
            // rbState
            // 
            this.rbState.AutoSize = true;
            this.rbState.Location = new System.Drawing.Point(79, 20);
            this.rbState.Name = "rbState";
            this.rbState.Size = new System.Drawing.Size(50, 17);
            this.rbState.TabIndex = 1;
            this.rbState.TabStop = true;
            this.rbState.Text = "State";
            this.rbState.UseVisualStyleBackColor = true;
            // 
            // rbLocation
            // 
            this.rbLocation.AutoSize = true;
            this.rbLocation.Location = new System.Drawing.Point(7, 20);
            this.rbLocation.Name = "rbLocation";
            this.rbLocation.Size = new System.Drawing.Size(66, 17);
            this.rbLocation.TabIndex = 0;
            this.rbLocation.TabStop = true;
            this.rbLocation.Text = "Location";
            this.rbLocation.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(20, 267);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(132, 24);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "Total Records:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.Location = new System.Drawing.Point(158, 267);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 24);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // chkNotInsurance
            // 
            this.chkNotInsurance.AutoSize = true;
            this.chkNotInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotInsurance.ForeColor = System.Drawing.Color.Red;
            this.chkNotInsurance.Location = new System.Drawing.Point(16, 13);
            this.chkNotInsurance.Name = "chkNotInsurance";
            this.chkNotInsurance.Size = new System.Drawing.Size(416, 35);
            this.chkNotInsurance.TabIndex = 11;
            this.chkNotInsurance.Text = "Not Importing Insurance Data";
            this.chkNotInsurance.UseVisualStyleBackColor = true;
            this.chkNotInsurance.CheckedChanged += new System.EventHandler(this.chkNotInsurance_CheckedChanged);
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 509);
            this.Controls.Add(this.chkNotInsurance);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.gbCriteria);
            this.Controls.Add(this.btnImportXML);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmData";
            this.Text = "Excel Data";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnImportXML;
        private System.Windows.Forms.GroupBox gbCriteria;
        private System.Windows.Forms.RadioButton rbState;
        private System.Windows.Forms.RadioButton rbLocation;
        private System.Windows.Forms.RadioButton rbRegion;
        private System.Windows.Forms.RadioButton rbConstruction;
        private System.Windows.Forms.RadioButton rbBusinessType;
        private System.Windows.Forms.RadioButton rbEarthquake;
        private System.Windows.Forms.RadioButton rbFlood;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkNotInsurance;
    }
}

