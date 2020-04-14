namespace BlueMaps
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.streetLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.zipLbl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.zipLbl);
            this.splitContainer1.Panel1.Controls.Add(this.stateLbl);
            this.splitContainer1.Panel1.Controls.Add(this.cityLbl);
            this.splitContainer1.Panel1.Controls.Add(this.streetLbl);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxZip);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxState);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxCity);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxStreet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(568, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(102, 71);
            this.txtBoxStreet.Multiline = true;
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStreet.TabIndex = 1;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(102, 136);
            this.txtBoxCity.Multiline = true;
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCity.TabIndex = 2;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(102, 204);
            this.txtBoxState.Multiline = true;
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(100, 20);
            this.txtBoxState.TabIndex = 3;
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(102, 269);
            this.txtBoxZip.Multiline = true;
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(100, 20);
            this.txtBoxZip.TabIndex = 4;
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLbl.Location = new System.Drawing.Point(22, 71);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Size = new System.Drawing.Size(59, 20);
            this.streetLbl.TabIndex = 5;
            this.streetLbl.Text = "Street";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLbl.Location = new System.Drawing.Point(27, 134);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(39, 20);
            this.cityLbl.TabIndex = 6;
            this.cityLbl.Text = "City";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLbl.Location = new System.Drawing.Point(22, 204);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(53, 20);
            this.stateLbl.TabIndex = 7;
            this.stateLbl.Text = "State";
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLbl.Location = new System.Drawing.Point(27, 269);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(34, 20);
            this.zipLbl.TabIndex = 8;
            this.zipLbl.Text = "Zip";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(78, 353);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "Blue Maps";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label zipLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label streetLbl;
        private System.Windows.Forms.Button btnSearch;
    }
}

