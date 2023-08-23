
namespace DynamicsTableAssociations
{
    partial class MainForm
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
            label1 = new System.Windows.Forms.Label();
            tb_initial = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tb_dest = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btn_analyze = new System.Windows.Forms.Button();
            lv_initial = new System.Windows.Forms.ListView();
            lvInitialName = new System.Windows.Forms.ColumnHeader();
            lv_dest = new System.Windows.Forms.ListView();
            lvDestName = new System.Windows.Forms.ColumnHeader();
            lv_output = new System.Windows.Forms.ListView();
            ParentTable = new System.Windows.Forms.ColumnHeader();
            ParentColumn = new System.Windows.Forms.ColumnHeader();
            ChildTable = new System.Windows.Forms.ColumnHeader();
            ChildColumn = new System.Windows.Forms.ColumnHeader();
            cb_SearchLayers = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            textBoxFilter = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(17, 97);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Search :";
            // 
            // tb_initial
            // 
            tb_initial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_initial.Location = new System.Drawing.Point(103, 92);
            tb_initial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tb_initial.Name = "tb_initial";
            tb_initial.Size = new System.Drawing.Size(340, 33);
            tb_initial.TabIndex = 1;
            tb_initial.TextChanged += tbInitial_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(459, 100);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 28);
            label2.TabIndex = 2;
            label2.Text = "Search :";
            // 
            // tb_dest
            // 
            tb_dest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_dest.Location = new System.Drawing.Point(546, 97);
            tb_dest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tb_dest.Name = "tb_dest";
            tb_dest.Size = new System.Drawing.Size(384, 33);
            tb_dest.TabIndex = 3;
            tb_dest.TextChanged += tbDest_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(19, 22);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(134, 32);
            label3.TabIndex = 6;
            label3.Text = "Initial Table";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(530, 30);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(198, 32);
            label4.TabIndex = 7;
            label4.Text = "Destination Table";
            // 
            // btn_analyze
            // 
            btn_analyze.Enabled = false;
            btn_analyze.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_analyze.Location = new System.Drawing.Point(646, 607);
            btn_analyze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btn_analyze.Name = "btn_analyze";
            btn_analyze.Size = new System.Drawing.Size(286, 50);
            btn_analyze.TabIndex = 9;
            btn_analyze.Text = "Find Associations";
            btn_analyze.UseVisualStyleBackColor = true;
            btn_analyze.Click += btnAnalyze_Click;
            // 
            // lv_initial
            // 
            lv_initial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvInitialName });
            lv_initial.FullRowSelect = true;
            lv_initial.GridLines = true;
            lv_initial.Location = new System.Drawing.Point(19, 143);
            lv_initial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lv_initial.MultiSelect = false;
            lv_initial.Name = "lv_initial";
            lv_initial.Size = new System.Drawing.Size(424, 442);
            lv_initial.TabIndex = 10;
            lv_initial.UseCompatibleStateImageBehavior = false;
            lv_initial.View = System.Windows.Forms.View.Details;
            lv_initial.SelectedIndexChanged += lvInitial_SelectedIndexChanged;
            // 
            // lvInitialName
            // 
            lvInitialName.Text = "Name";
            // 
            // lv_dest
            // 
            lv_dest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvDestName });
            lv_dest.FullRowSelect = true;
            lv_dest.GridLines = true;
            lv_dest.Location = new System.Drawing.Point(467, 143);
            lv_dest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            lv_dest.MultiSelect = false;
            lv_dest.Name = "lv_dest";
            lv_dest.Size = new System.Drawing.Size(463, 442);
            lv_dest.TabIndex = 11;
            lv_dest.UseCompatibleStateImageBehavior = false;
            lv_dest.View = System.Windows.Forms.View.Details;
            lv_dest.SelectedIndexChanged += lvDest_SelectedIndexChanged;
            // 
            // lvDestName
            // 
            lvDestName.Text = "Name";
            // 
            // lv_output
            // 
            lv_output.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ParentTable, ParentColumn, ChildTable, ChildColumn });
            lv_output.FullRowSelect = true;
            lv_output.GridLines = true;
            lv_output.Location = new System.Drawing.Point(19, 685);
            lv_output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lv_output.Name = "lv_output";
            lv_output.Size = new System.Drawing.Size(1164, 479);
            lv_output.TabIndex = 12;
            lv_output.UseCompatibleStateImageBehavior = false;
            lv_output.View = System.Windows.Forms.View.Details;
            // 
            // ParentTable
            // 
            ParentTable.Text = "Parent Table";
            ParentTable.Width = 200;
            // 
            // ParentColumn
            // 
            ParentColumn.Text = "Parent Column";
            ParentColumn.Width = 200;
            // 
            // ChildTable
            // 
            ChildTable.Text = "Child Table";
            ChildTable.Width = 200;
            // 
            // ChildColumn
            // 
            ChildColumn.Text = "Child Column";
            ChildColumn.Width = 200;
            // 
            // cb_SearchLayers
            // 
            cb_SearchLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_SearchLayers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_SearchLayers.FormattingEnabled = true;
            cb_SearchLayers.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cb_SearchLayers.Location = new System.Drawing.Point(283, 607);
            cb_SearchLayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cb_SearchLayers.Name = "cb_SearchLayers";
            cb_SearchLayers.Size = new System.Drawing.Size(160, 36);
            cb_SearchLayers.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(19, 612);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(262, 28);
            label5.TabIndex = 14;
            label5.Text = "Number of Layers to Search :";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new System.Drawing.Point(956, 143);
            textBoxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxFilter.Multiline = true;
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new System.Drawing.Size(227, 442);
            textBoxFilter.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(956, 105);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 28);
            label6.TabIndex = 16;
            label6.Text = "Filter";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1201, 1182);
            Controls.Add(label6);
            Controls.Add(textBoxFilter);
            Controls.Add(label5);
            Controls.Add(cb_SearchLayers);
            Controls.Add(lv_output);
            Controls.Add(lv_dest);
            Controls.Add(lv_initial);
            Controls.Add(btn_analyze);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_dest);
            Controls.Add(label2);
            Controls.Add(tb_initial);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Dynamics AX / 365FO Table Associations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_initial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_analyze;
        private System.Windows.Forms.ListView lv_initial;
        private System.Windows.Forms.ColumnHeader lvInitialName;
        private System.Windows.Forms.ListView lv_dest;
        private System.Windows.Forms.ColumnHeader lvDestName;
        private System.Windows.Forms.ListView lv_output;
        private System.Windows.Forms.ColumnHeader ParentTable;
        private System.Windows.Forms.ColumnHeader ParentColumn;
        private System.Windows.Forms.ColumnHeader ChildTable;
        private System.Windows.Forms.ColumnHeader ChildColumn;
        private System.Windows.Forms.ComboBox cb_SearchLayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label6;
    }
}

