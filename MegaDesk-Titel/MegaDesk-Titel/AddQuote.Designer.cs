namespace MegaDesk_Titel
{
    partial class AddQuote
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.TextBox();
            this.drawerCount = new System.Windows.Forms.NumericUpDown();
            this.SurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.deliveryTime = new System.Windows.Forms.ComboBox();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.DeliveryDays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(479, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 56);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Full Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1532, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width in Inches: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1532, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depth in Inches";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1485, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1499, 726);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surface Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1492, 783);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Requested Delivery Time:";
            // 
            // custName
            // 
            this.custName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(179, 88);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(173, 29);
            this.custName.TabIndex = 1;
            // 
            // drawerCount
            // 
            this.drawerCount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerCount.Location = new System.Drawing.Point(179, 192);
            this.drawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerCount.Name = "drawerCount";
            this.drawerCount.Size = new System.Drawing.Size(120, 29);
            this.drawerCount.TabIndex = 4;
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterial.FormattingEnabled = true;
            this.SurfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.SurfaceMaterial.Location = new System.Drawing.Point(179, 227);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(151, 31);
            this.SurfaceMaterial.TabIndex = 5;
            // 
            // deliveryTime
            // 
            this.deliveryTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTime.FormattingEnabled = true;
            this.deliveryTime.Items.AddRange(new object[] {
            "Rush Order - 3 Days (extra charge)",
            "Rush Order - 5 Days (extra charge)",
            "Rush Order - 7 Days (extra charge)",
            "Normal Order - 14 Days (No extra Charge)"});
            this.deliveryTime.Location = new System.Drawing.Point(179, 265);
            this.deliveryTime.Name = "deliveryTime";
            this.deliveryTime.Size = new System.Drawing.Size(227, 27);
            this.deliveryTime.TabIndex = 6;
            this.deliveryTime.Leave += new System.EventHandler(this.deliveryTime_Leave);
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(179, 121);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(120, 29);
            this.width.TabIndex = 2;
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.width_Validating);
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(135, 372);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(134, 56);
            this.btnGetQuote.TabIndex = 7;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // DeliveryDays
            // 
            this.DeliveryDays.Location = new System.Drawing.Point(160, 372);
            this.DeliveryDays.Name = "DeliveryDays";
            this.DeliveryDays.Size = new System.Drawing.Size(100, 20);
            this.DeliveryDays.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 56);
            this.label7.TabIndex = 9;
            this.label7.Text = "Add a Quote";
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(179, 156);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 29);
            this.depth.TabIndex = 3;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Width (in.):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Depth (in.):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "# of Drawers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Surface Material:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Delivery Time";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.width);
            this.Controls.Add(this.deliveryTime);
            this.Controls.Add(this.SurfaceMaterial);
            this.Controls.Add(this.drawerCount);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.DeliveryDays);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.NumericUpDown drawerCount;
        private System.Windows.Forms.ComboBox SurfaceMaterial;
        private System.Windows.Forms.ComboBox deliveryTime;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.TextBox DeliveryDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}