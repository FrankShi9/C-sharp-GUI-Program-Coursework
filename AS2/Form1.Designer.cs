
namespace AS2
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.lblPop = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemov = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.CountryList = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPopSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(201, 34);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(100, 22);
            this.txtPop.TabIndex = 3;
            this.txtPop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // lblPop
            // 
            this.lblPop.AutoSize = true;
            this.lblPop.Location = new System.Drawing.Point(198, 13);
            this.lblPop.Name = "lblPop";
            this.lblPop.Size = new System.Drawing.Size(106, 17);
            this.lblPop.TabIndex = 2;
            this.lblPop.Text = "Population Size";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemov
            // 
            this.btnRemov.Location = new System.Drawing.Point(106, 62);
            this.btnRemov.Name = "btnRemov";
            this.btnRemov.Size = new System.Drawing.Size(75, 23);
            this.btnRemov.TabIndex = 5;
            this.btnRemov.Text = "Remove";
            this.btnRemov.UseVisualStyleBackColor = true;
            this.btnRemov.Click += new System.EventHandler(this.btnRemov_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(201, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CountryList
            // 
            this.CountryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cPopSize});
            this.CountryList.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CountryList.HideSelection = false;
            this.CountryList.Location = new System.Drawing.Point(13, 104);
            this.CountryList.Name = "CountryList";
            this.CountryList.Size = new System.Drawing.Size(288, 233);
            this.CountryList.TabIndex = 7;
            this.CountryList.TileSize = new System.Drawing.Size(50, 50);
            this.CountryList.UseCompatibleStateImageBehavior = false;
            this.CountryList.UseWaitCursor = true;
            this.CountryList.View = System.Windows.Forms.View.Details;
            this.CountryList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Sort);
            this.CountryList.SelectedIndexChanged += new System.EventHandler(this.UpdateInfo);
            // 
            // cName
            // 
            this.cName.Text = "Name↓";
            this.cName.Width = 100;
            // 
            // cPopSize
            // 
            this.cPopSize.Text = "Population Size↓";
            this.cPopSize.Width = 183;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 349);
            this.Controls.Add(this.CountryList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemov);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.lblPop);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Country App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.Label lblPop;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemov;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView CountryList;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cPopSize;
    }
}

