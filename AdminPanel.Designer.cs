namespace OtoparkAppV1._0
{
    partial class AdminPanel
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
            this.tableSqlData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aracKpsTxt = new System.Windows.Forms.TextBox();
            this.parkUcretiTxt = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnParkaGit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableSqlData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Park Listesi";
            // 
            // tableSqlData
            // 
            this.tableSqlData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSqlData.Location = new System.Drawing.Point(12, 37);
            this.tableSqlData.Name = "tableSqlData";
            this.tableSqlData.RowTemplate.Height = 25;
            this.tableSqlData.Size = new System.Drawing.Size(523, 162);
            this.tableSqlData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Araç Kapasitesi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saatlik Park Ücreti :";
            // 
            // aracKpsTxt
            // 
            this.aracKpsTxt.Location = new System.Drawing.Point(247, 240);
            this.aracKpsTxt.Name = "aracKpsTxt";
            this.aracKpsTxt.Size = new System.Drawing.Size(141, 23);
            this.aracKpsTxt.TabIndex = 4;
            // 
            // parkUcretiTxt
            // 
            this.parkUcretiTxt.Location = new System.Drawing.Point(247, 281);
            this.parkUcretiTxt.Name = "parkUcretiTxt";
            this.parkUcretiTxt.Size = new System.Drawing.Size(141, 23);
            this.parkUcretiTxt.TabIndex = 5;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(257, 338);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(85, 31);
            this.btnOnayla.TabIndex = 6;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnParkaGit
            // 
            this.btnParkaGit.Location = new System.Drawing.Point(411, 338);
            this.btnParkaGit.Name = "btnParkaGit";
            this.btnParkaGit.Size = new System.Drawing.Size(103, 31);
            this.btnParkaGit.TabIndex = 7;
            this.btnParkaGit.Text = "Otoparka Git";
            this.btnParkaGit.UseVisualStyleBackColor = true;
            this.btnParkaGit.Click += new System.EventHandler(this.btnParkaGit_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 381);
            this.Controls.Add(this.btnParkaGit);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.parkUcretiTxt);
            this.Controls.Add(this.aracKpsTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableSqlData);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableSqlData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView tableSqlData;
        private Label label2;
        private Label label3;
        private TextBox aracKpsTxt;
        private TextBox parkUcretiTxt;
        private Button btnOnayla;
        private Button btnParkaGit;
    }
}