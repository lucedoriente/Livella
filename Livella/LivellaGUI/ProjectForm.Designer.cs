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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.listViewCompareTable = new System.Windows.Forms.ListView();
            this.listViewBaseTable = new System.Windows.Forms.ListView();
            this.listViewJoinList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            // listViewCompareTable
            // 
            this.listViewCompareTable.CheckBoxes = true;
            this.listViewCompareTable.FullRowSelect = true;
            this.listViewCompareTable.Location = new System.Drawing.Point(467, 41);
            this.listViewCompareTable.MultiSelect = false;
            this.listViewCompareTable.Name = "listViewCompareTable";
            this.listViewCompareTable.Size = new System.Drawing.Size(368, 368);
            this.listViewCompareTable.TabIndex = 7;
            this.listViewCompareTable.UseCompatibleStateImageBehavior = false;
            this.listViewCompareTable.View = System.Windows.Forms.View.Details;
            this.listViewCompareTable.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewCompareTable_ItemCheck);
            // 
            // listViewBaseTable
            // 
            this.listViewBaseTable.CheckBoxes = true;
            this.listViewBaseTable.FullRowSelect = true;
            this.listViewBaseTable.Location = new System.Drawing.Point(12, 41);
            this.listViewBaseTable.MultiSelect = false;
            this.listViewBaseTable.Name = "listViewBaseTable";
            this.listViewBaseTable.Size = new System.Drawing.Size(368, 368);
            this.listViewBaseTable.TabIndex = 9;
            this.listViewBaseTable.UseCompatibleStateImageBehavior = false;
            this.listViewBaseTable.View = System.Windows.Forms.View.Details;
            this.listViewBaseTable.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewBaseTable_ItemCheck);
            // 
            // listViewJoinList
            // 
            this.listViewJoinList.CheckBoxes = true;
            this.listViewJoinList.FullRowSelect = true;
            this.listViewJoinList.Location = new System.Drawing.Point(12, 415);
            this.listViewJoinList.MultiSelect = false;
            this.listViewJoinList.Name = "listViewJoinList";
            this.listViewJoinList.Size = new System.Drawing.Size(823, 108);
            this.listViewJoinList.TabIndex = 10;
            this.listViewJoinList.UseCompatibleStateImageBehavior = false;
            this.listViewJoinList.View = System.Windows.Forms.View.Details;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 535);
            this.ControlBox = false;
            this.Controls.Add(this.listViewJoinList);
            this.Controls.Add(this.listViewBaseTable);
            this.Controls.Add(this.listViewCompareTable);
            this.Controls.Add(this.buttonConnect);
            this.Name = "ProjectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Project";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListView listViewCompareTable;
        private System.Windows.Forms.ListView listViewBaseTable;
        private System.Windows.Forms.ListView listViewJoinList;
    }
}