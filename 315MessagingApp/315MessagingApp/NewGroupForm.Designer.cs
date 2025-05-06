namespace _315MessagingApp
{
    partial class NewGroupForm
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
            this.btnAddNewGroupMember = new System.Windows.Forms.Button();
            this.txtNewGroupMembersSearch = new System.Windows.Forms.TextBox();
            this.dgvNewGroupMembersSelect = new System.Windows.Forms.DataGridView();
            this.btnCancelNewGroup = new System.Windows.Forms.Button();
            this.btnCreateNewGroup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbGroupPreview = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewGroupMembersSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create New Group";
            // 
            // btnAddNewGroupMember
            // 
            this.btnAddNewGroupMember.Location = new System.Drawing.Point(290, 247);
            this.btnAddNewGroupMember.Name = "btnAddNewGroupMember";
            this.btnAddNewGroupMember.Size = new System.Drawing.Size(124, 50);
            this.btnAddNewGroupMember.TabIndex = 11;
            this.btnAddNewGroupMember.Text = "Add";
            this.btnAddNewGroupMember.UseVisualStyleBackColor = true;
            // 
            // txtNewGroupMembersSearch
            // 
            this.txtNewGroupMembersSearch.Location = new System.Drawing.Point(160, 63);
            this.txtNewGroupMembersSearch.Name = "txtNewGroupMembersSearch";
            this.txtNewGroupMembersSearch.Size = new System.Drawing.Size(124, 22);
            this.txtNewGroupMembersSearch.TabIndex = 10;
            // 
            // dgvNewGroupMembersSelect
            // 
            this.dgvNewGroupMembersSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewGroupMembersSelect.Location = new System.Drawing.Point(30, 91);
            this.dgvNewGroupMembersSelect.Name = "dgvNewGroupMembersSelect";
            this.dgvNewGroupMembersSelect.RowHeadersWidth = 51;
            this.dgvNewGroupMembersSelect.RowTemplate.Height = 24;
            this.dgvNewGroupMembersSelect.Size = new System.Drawing.Size(254, 150);
            this.dgvNewGroupMembersSelect.TabIndex = 9;
            // 
            // btnCancelNewGroup
            // 
            this.btnCancelNewGroup.Location = new System.Drawing.Point(160, 247);
            this.btnCancelNewGroup.Name = "btnCancelNewGroup";
            this.btnCancelNewGroup.Size = new System.Drawing.Size(124, 50);
            this.btnCancelNewGroup.TabIndex = 8;
            this.btnCancelNewGroup.Text = "Cancel";
            this.btnCancelNewGroup.UseVisualStyleBackColor = true;
            this.btnCancelNewGroup.Click += new System.EventHandler(this.btnCancelNewGroup_Click);
            // 
            // btnCreateNewGroup
            // 
            this.btnCreateNewGroup.Location = new System.Drawing.Point(30, 247);
            this.btnCreateNewGroup.Name = "btnCreateNewGroup";
            this.btnCreateNewGroup.Size = new System.Drawing.Size(124, 50);
            this.btnCreateNewGroup.TabIndex = 7;
            this.btnCreateNewGroup.Text = "Create";
            this.btnCreateNewGroup.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Group Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Search:";
            // 
            // lsbGroupPreview
            // 
            this.lsbGroupPreview.FormattingEnabled = true;
            this.lsbGroupPreview.ItemHeight = 16;
            this.lsbGroupPreview.Location = new System.Drawing.Point(290, 107);
            this.lsbGroupPreview.Name = "lsbGroupPreview";
            this.lsbGroupPreview.Size = new System.Drawing.Size(124, 132);
            this.lsbGroupPreview.TabIndex = 16;
            this.lsbGroupPreview.SelectedIndexChanged += new System.EventHandler(this.lsbGroupPreview_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Group Preview";
            // 
            // NewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 303);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsbGroupPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewGroupMember);
            this.Controls.Add(this.txtNewGroupMembersSearch);
            this.Controls.Add(this.dgvNewGroupMembersSelect);
            this.Controls.Add(this.btnCancelNewGroup);
            this.Controls.Add(this.btnCreateNewGroup);
            this.Name = "NewGroupForm";
            this.Text = "NewGroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewGroupMembersSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewGroupMember;
        private System.Windows.Forms.TextBox txtNewGroupMembersSearch;
        private System.Windows.Forms.DataGridView dgvNewGroupMembersSelect;
        private System.Windows.Forms.Button btnCancelNewGroup;
        private System.Windows.Forms.Button btnCreateNewGroup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbGroupPreview;
        private System.Windows.Forms.Label label4;
    }
}