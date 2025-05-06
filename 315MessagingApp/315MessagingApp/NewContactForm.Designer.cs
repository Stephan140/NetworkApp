namespace _315MessagingApp
{
    partial class NewContactForm
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
            this.btnCreateNewContact = new System.Windows.Forms.Button();
            this.btnCancelNewContact = new System.Windows.Forms.Button();
            this.dgvNewContactSelect = new System.Windows.Forms.DataGridView();
            this.txtNewContactSearch = new System.Windows.Forms.TextBox();
            this.btnSelectNewContact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewContactSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNewContact
            // 
            this.btnCreateNewContact.Location = new System.Drawing.Point(30, 276);
            this.btnCreateNewContact.Name = "btnCreateNewContact";
            this.btnCreateNewContact.Size = new System.Drawing.Size(124, 50);
            this.btnCreateNewContact.TabIndex = 1;
            this.btnCreateNewContact.Text = "Create";
            this.btnCreateNewContact.UseVisualStyleBackColor = true;
            this.btnCreateNewContact.Click += new System.EventHandler(this.btnCreateNewContact_Click);
            // 
            // btnCancelNewContact
            // 
            this.btnCancelNewContact.Location = new System.Drawing.Point(160, 276);
            this.btnCancelNewContact.Name = "btnCancelNewContact";
            this.btnCancelNewContact.Size = new System.Drawing.Size(124, 50);
            this.btnCancelNewContact.TabIndex = 2;
            this.btnCancelNewContact.Text = "Cancel";
            this.btnCancelNewContact.UseVisualStyleBackColor = true;
            this.btnCancelNewContact.Click += new System.EventHandler(this.btnCancelNewContact_Click);
            // 
            // dgvNewContactSelect
            // 
            this.dgvNewContactSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewContactSelect.Location = new System.Drawing.Point(30, 63);
            this.dgvNewContactSelect.Name = "dgvNewContactSelect";
            this.dgvNewContactSelect.RowHeadersWidth = 51;
            this.dgvNewContactSelect.RowTemplate.Height = 24;
            this.dgvNewContactSelect.Size = new System.Drawing.Size(254, 150);
            this.dgvNewContactSelect.TabIndex = 3;
            this.dgvNewContactSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewContactSelect_CellContentClick);
            // 
            // txtNewContactSearch
            // 
            this.txtNewContactSearch.Location = new System.Drawing.Point(160, 35);
            this.txtNewContactSearch.Name = "txtNewContactSearch";
            this.txtNewContactSearch.Size = new System.Drawing.Size(124, 22);
            this.txtNewContactSearch.TabIndex = 4;
            this.txtNewContactSearch.TextChanged += new System.EventHandler(this.txtNewContactSearch_TextChanged);
            // 
            // btnSelectNewContact
            // 
            this.btnSelectNewContact.Location = new System.Drawing.Point(95, 219);
            this.btnSelectNewContact.Name = "btnSelectNewContact";
            this.btnSelectNewContact.Size = new System.Drawing.Size(124, 50);
            this.btnSelectNewContact.TabIndex = 5;
            this.btnSelectNewContact.Text = "Select";
            this.btnSelectNewContact.UseVisualStyleBackColor = true;
            this.btnSelectNewContact.Click += new System.EventHandler(this.btnSelectNewContact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Create New Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search:";
            // 
            // NewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectNewContact);
            this.Controls.Add(this.txtNewContactSearch);
            this.Controls.Add(this.dgvNewContactSelect);
            this.Controls.Add(this.btnCancelNewContact);
            this.Controls.Add(this.btnCreateNewContact);
            this.Name = "NewContactForm";
            this.Text = "NewContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewContactSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewContact;
        private System.Windows.Forms.Button btnCancelNewContact;
        private System.Windows.Forms.DataGridView dgvNewContactSelect;
        private System.Windows.Forms.TextBox txtNewContactSearch;
        private System.Windows.Forms.Button btnSelectNewContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}