﻿namespace CafeManagementSystem
{
    partial class itemDeleteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteDataGridView
            // 
            this.DeleteDataGridView.AllowUserToAddRows = false;
            this.DeleteDataGridView.AllowUserToDeleteRows = false;
            this.DeleteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeleteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DeleteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteDataGridView.Location = new System.Drawing.Point(2, 66);
            this.DeleteDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteDataGridView.Name = "DeleteDataGridView";
            this.DeleteDataGridView.ReadOnly = true;
            this.DeleteDataGridView.RowTemplate.Height = 24;
            this.DeleteDataGridView.Size = new System.Drawing.Size(820, 358);
            this.DeleteDataGridView.TabIndex = 2;
            this.DeleteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.DeleteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delete";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(349, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemDeleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "itemDeleteControl";
            this.Size = new System.Drawing.Size(823, 533);
            this.Load += new System.EventHandler(this.itemDeleteControl_Load);
            this.Click += new System.EventHandler(this.itemDeleteControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DeleteDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
