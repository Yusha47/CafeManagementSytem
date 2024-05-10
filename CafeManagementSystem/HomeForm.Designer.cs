namespace CafeManagementSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.removeItembtn = new System.Windows.Forms.Button();
            this.updateItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemDeleteControl1 = new CafeManagementSystem.itemDeleteControl();
            this.itemUpdateControl1 = new CafeManagementSystem.itemUpdateControl();
            this.addItemControl1 = new CafeManagementSystem.addItemControl();
            this.placeOrderControl1 = new CafeManagementSystem.placeOrderControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.removeItembtn);
            this.panel1.Controls.Add(this.updateItemBtn);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Controls.Add(this.placeOrderBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 533);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(68, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // removeItembtn
            // 
            this.removeItembtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.removeItembtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeItembtn.BackgroundImage")));
            this.removeItembtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeItembtn.FlatAppearance.BorderSize = 0;
            this.removeItembtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItembtn.ForeColor = System.Drawing.Color.White;
            this.removeItembtn.Location = new System.Drawing.Point(17, 122);
            this.removeItembtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeItembtn.Name = "removeItembtn";
            this.removeItembtn.Size = new System.Drawing.Size(129, 41);
            this.removeItembtn.TabIndex = 3;
            this.removeItembtn.Text = "Remove Item";
            this.removeItembtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeItembtn.UseVisualStyleBackColor = false;
            this.removeItembtn.Click += new System.EventHandler(this.removeItembtn_Click);
            // 
            // updateItemBtn
            // 
            this.updateItemBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.updateItemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateItemBtn.BackgroundImage")));
            this.updateItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateItemBtn.FlatAppearance.BorderSize = 0;
            this.updateItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemBtn.ForeColor = System.Drawing.Color.White;
            this.updateItemBtn.Location = new System.Drawing.Point(17, 65);
            this.updateItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateItemBtn.Name = "updateItemBtn";
            this.updateItemBtn.Size = new System.Drawing.Size(127, 41);
            this.updateItemBtn.TabIndex = 2;
            this.updateItemBtn.Text = "Update Item";
            this.updateItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateItemBtn.UseVisualStyleBackColor = false;
            this.updateItemBtn.Click += new System.EventHandler(this.updateItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addItemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addItemBtn.BackgroundImage")));
            this.addItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemBtn.FlatAppearance.BorderSize = 0;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.Color.White;
            this.addItemBtn.Location = new System.Drawing.Point(17, 11);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(125, 36);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.BackColor = System.Drawing.Color.Blue;
            this.placeOrderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("placeOrderBtn.BackgroundImage")));
            this.placeOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeOrderBtn.FlatAppearance.BorderSize = 0;
            this.placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.Transparent;
            this.placeOrderBtn.Location = new System.Drawing.Point(21, 179);
            this.placeOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(121, 34);
            this.placeOrderBtn.TabIndex = 0;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.placeOrderBtn.UseVisualStyleBackColor = false;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.placeOrderControl1);
            this.panel2.Controls.Add(this.itemDeleteControl1);
            this.panel2.Controls.Add(this.itemUpdateControl1);
            this.panel2.Controls.Add(this.addItemControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(144, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 533);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // itemDeleteControl1
            // 
            this.itemDeleteControl1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.itemDeleteControl1.Location = new System.Drawing.Point(0, 0);
            this.itemDeleteControl1.Margin = new System.Windows.Forms.Padding(2);
            this.itemDeleteControl1.Name = "itemDeleteControl1";
            this.itemDeleteControl1.Size = new System.Drawing.Size(823, 533);
            this.itemDeleteControl1.TabIndex = 3;
            this.itemDeleteControl1.Load += new System.EventHandler(this.itemDeleteControl1_Load);
            // 
            // itemUpdateControl1
            // 
            this.itemUpdateControl1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.itemUpdateControl1.Location = new System.Drawing.Point(0, 0);
            this.itemUpdateControl1.Margin = new System.Windows.Forms.Padding(2);
            this.itemUpdateControl1.Name = "itemUpdateControl1";
            this.itemUpdateControl1.Size = new System.Drawing.Size(823, 533);
            this.itemUpdateControl1.TabIndex = 2;
            // 
            // addItemControl1
            // 
            this.addItemControl1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addItemControl1.Location = new System.Drawing.Point(0, 0);
            this.addItemControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItemControl1.Name = "addItemControl1";
            this.addItemControl1.Size = new System.Drawing.Size(823, 533);
            this.addItemControl1.TabIndex = 1;
            // 
            // placeOrderControl1
            // 
            this.placeOrderControl1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.placeOrderControl1.Location = new System.Drawing.Point(1, 2);
            this.placeOrderControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.placeOrderControl1.Name = "placeOrderControl1";
            this.placeOrderControl1.Size = new System.Drawing.Size(823, 533);
            this.placeOrderControl1.TabIndex = 4;
            this.placeOrderControl1.Load += new System.EventHandler(this.placeOrderControl1_Load);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button removeItembtn;
        private System.Windows.Forms.Label label1;
        private addItemControl addItemControl1;
        private itemUpdateControl itemUpdateControl1;
        private placeOrderControl placeOrderControl1;
        private System.Windows.Forms.Panel panel2;
        private itemDeleteControl itemDeleteControl1;
    }
}