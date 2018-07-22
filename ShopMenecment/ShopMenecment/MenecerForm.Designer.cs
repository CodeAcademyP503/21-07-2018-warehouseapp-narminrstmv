namespace ShopMenecment
{
    partial class MenecerForm
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
            this.DTWMANAGER = new System.Windows.Forms.DataGridView();
            this.BTNlogout = new System.Windows.Forms.Button();
            this.Magazaadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dovriyye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTWMANAGER)).BeginInit();
            this.SuspendLayout();
            // 
            // DTWMANAGER
            // 
            this.DTWMANAGER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTWMANAGER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Magazaadi,
            this.dovriyye});
            this.DTWMANAGER.Location = new System.Drawing.Point(53, 25);
            this.DTWMANAGER.Name = "DTWMANAGER";
            this.DTWMANAGER.Size = new System.Drawing.Size(523, 199);
            this.DTWMANAGER.TabIndex = 0;
            // 
            // BTNlogout
            // 
            this.BTNlogout.Location = new System.Drawing.Point(633, 13);
            this.BTNlogout.Name = "BTNlogout";
            this.BTNlogout.Size = new System.Drawing.Size(75, 23);
            this.BTNlogout.TabIndex = 1;
            this.BTNlogout.Text = "Log out";
            this.BTNlogout.UseVisualStyleBackColor = true;
            this.BTNlogout.Click += new System.EventHandler(this.BTNlogout_Click);
            // 
            // Magazaadi
            // 
            this.Magazaadi.HeaderText = "Mağzaza adı";
            this.Magazaadi.Name = "Magazaadi";
            // 
            // dovriyye
            // 
            this.dovriyye.HeaderText = "Dövriyyə";
            this.dovriyye.Name = "dovriyye";
            // 
            // MenecerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNlogout);
            this.Controls.Add(this.DTWMANAGER);
            this.Name = "MenecerForm";
            this.Text = "MenecerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.Load += new System.EventHandler(this.MenecerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTWMANAGER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTWMANAGER;
        private System.Windows.Forms.Button BTNlogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magazaadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dovriyye;
    }
}