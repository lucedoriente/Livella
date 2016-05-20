namespace LivellaGUI
{
    partial class ProjectForm
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
            this.listBoxBaseTable = new System.Windows.Forms.ListBox();
            this.listBoxCompareTable = new System.Windows.Forms.ListBox();
            this.listBoxLinked = new System.Windows.Forms.ListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBaseTable
            // 
            this.listBoxBaseTable.FormattingEnabled = true;
            this.listBoxBaseTable.Location = new System.Drawing.Point(182, 12);
            this.listBoxBaseTable.Name = "listBoxBaseTable";
            this.listBoxBaseTable.Size = new System.Drawing.Size(198, 394);
            this.listBoxBaseTable.TabIndex = 0;
            // 
            // listBoxCompareTable
            // 
            this.listBoxCompareTable.FormattingEnabled = true;
            this.listBoxCompareTable.Location = new System.Drawing.Point(467, 12);
            this.listBoxCompareTable.Name = "listBoxCompareTable";
            this.listBoxCompareTable.Size = new System.Drawing.Size(198, 394);
            this.listBoxCompareTable.TabIndex = 1;
            // 
            // listBoxLinked
            // 
            this.listBoxLinked.FormattingEnabled = true;
            this.listBoxLinked.Location = new System.Drawing.Point(12, 415);
            this.listBoxLinked.Name = "listBoxLinked";
            this.listBoxLinked.Size = new System.Drawing.Size(826, 108);
            this.listBoxLinked.TabIndex = 2;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(386, 185);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 535);
            this.ControlBox = false;
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.listBoxLinked);
            this.Controls.Add(this.listBoxCompareTable);
            this.Controls.Add(this.listBoxBaseTable);
            this.Name = "Project";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBaseTable;
        private System.Windows.Forms.ListBox listBoxCompareTable;
        private System.Windows.Forms.ListBox listBoxLinked;
        private System.Windows.Forms.Button buttonConnect;
    }
}