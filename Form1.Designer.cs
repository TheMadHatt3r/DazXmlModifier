namespace DazXmlModifier
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_runtimeDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_prodName = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_globalID = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.xId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xContent = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCategories = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCompatibilityBase = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xCompatibility = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(11, 53);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(129, 41);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Load DSX";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_runtimeDir
            // 
            this.txt_runtimeDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_runtimeDir.Location = new System.Drawing.Point(64, 27);
            this.txt_runtimeDir.Name = "txt_runtimeDir";
            this.txt_runtimeDir.Size = new System.Drawing.Size(570, 20);
            this.txt_runtimeDir.TabIndex = 2;
            this.txt_runtimeDir.Text = "C:\\Users\\Collin\\Documents\\GitHub\\DazXmlModifier\\docs\\DAZ_3D_45801_Belle_Dress_for" +
    "_Genesis_8_Females.dsx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DXF File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_prodName
            // 
            this.lbl_prodName.AutoSize = true;
            this.lbl_prodName.Location = new System.Drawing.Point(147, 58);
            this.lbl_prodName.Name = "lbl_prodName";
            this.lbl_prodName.Size = new System.Drawing.Size(78, 13);
            this.lbl_prodName.TabIndex = 8;
            this.lbl_prodName.Text = "Product Name:";
            this.lbl_prodName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lbl_globalID);
            this.groupBox5.Controls.Add(this.txt_runtimeDir);
            this.groupBox5.Controls.Add(this.btn_search);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.lbl_prodName);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(640, 104);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Content Type:";
            // 
            // lbl_globalID
            // 
            this.lbl_globalID.AutoSize = true;
            this.lbl_globalID.Location = new System.Drawing.Point(147, 76);
            this.lbl_globalID.Name = "lbl_globalID";
            this.lbl_globalID.Size = new System.Drawing.Size(79, 13);
            this.lbl_globalID.TabIndex = 9;
            this.lbl_globalID.Text = "DAZ Global ID:";
            this.lbl_globalID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(12, 309);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(640, 41);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save Modifed DSX";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToResizeRows = false;
            this.dg1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xId,
            this.xContent,
            this.xCategories,
            this.xCompatibilityBase,
            this.xCompatibility});
            this.dg1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg1.Location = new System.Drawing.Point(12, 122);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(640, 181);
            this.dg1.TabIndex = 8;
            this.dg1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg1_EditingControlShowing);
            // 
            // xId
            // 
            this.xId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xId.HeaderText = "Name";
            this.xId.MinimumWidth = 100;
            this.xId.Name = "xId";
            this.xId.ReadOnly = true;
            // 
            // xContent
            // 
            this.xContent.HeaderText = "Content Type";
            this.xContent.Items.AddRange(new object[] {
            "Follower/Wardrobe",
            "Follower/Accessory",
            "Prop",
            "Presets/Materials"});
            this.xContent.Name = "xContent";
            this.xContent.Width = 120;
            // 
            // xCategories
            // 
            this.xCategories.AutoComplete = false;
            this.xCategories.HeaderText = "Categories";
            this.xCategories.Items.AddRange(new object[] {
            "Default/Wardrobe",
            "Default/Materials",
            "Default/Accessories",
            "Default/Props",
            "Default/Poses",
            "CUSTOM HERE"});
            this.xCategories.Name = "xCategories";
            this.xCategories.Width = 120;
            // 
            // xCompatibilityBase
            // 
            this.xCompatibilityBase.HeaderText = "CompatibilityBase";
            this.xCompatibilityBase.Name = "xCompatibilityBase";
            this.xCompatibilityBase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // xCompatibility
            // 
            this.xCompatibility.HeaderText = "Compatibility";
            this.xCompatibility.Items.AddRange(new object[] {
            "Genesis 8/Female",
            "Genesis 8/Male",
            "Genesis 3/Female",
            "Genesis 3/Male",
            "Genesis 2/Female",
            "Genesis 2/Male",
            "Genesis",
            "Null (do not add)"});
            this.xCompatibility.Name = "xCompatibility";
            this.xCompatibility.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 362);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox5);
            this.MinimumSize = new System.Drawing.Size(680, 400);
            this.Name = "Form1";
            this.Text = "Daz XML Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_runtimeDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_prodName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_globalID;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xId;
        private System.Windows.Forms.DataGridViewComboBoxColumn xContent;
        private System.Windows.Forms.DataGridViewComboBoxColumn xCategories;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xCompatibilityBase;
        private System.Windows.Forms.DataGridViewComboBoxColumn xCompatibility;
    }
}

