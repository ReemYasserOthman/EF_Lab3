namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTopics = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTopics
            // 
            this.dataGridViewTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopics.Location = new System.Drawing.Point(12, 207);
            this.dataGridViewTopics.Name = "dataGridViewTopics";
            this.dataGridViewTopics.RowHeadersWidth = 51;
            this.dataGridViewTopics.RowTemplate.Height = 29;
            this.dataGridViewTopics.Size = new System.Drawing.Size(566, 231);
            this.dataGridViewTopics.TabIndex = 0;
            this.dataGridViewTopics.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTopics_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TopicId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TopicName";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(101, 45);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(125, 27);
            this.textId.TabIndex = 4;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(130, 85);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 27);
            this.textName.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(613, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(275, 137);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 29);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(384, 137);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(94, 29);
            this.edit.TabIndex = 10;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(484, 137);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 29);
            this.delete.TabIndex = 11;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(353, 45);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(125, 27);
            this.textSearch.TabIndex = 12;
            this.textSearch.Text = "search";
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTopics);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewTopics;
        private Label label1;
        private Label label2;
        private TextBox textId;
        private TextBox textName;
        private ComboBox comboBox1;
        private Label label4;
        private Button add;
        private Button edit;
        private Button delete;
        private TextBox textSearch;
    }
}