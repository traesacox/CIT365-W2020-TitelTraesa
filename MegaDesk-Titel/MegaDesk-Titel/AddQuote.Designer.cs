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
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.DeliveryDays = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(369, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width in Inches: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depth in Inches";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surface Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Requested Delivery Time:";
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(157, 25);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(126, 20);
            this.custName.TabIndex = 1;
            // 
            // drawerCount
            // 
            this.drawerCount.Location = new System.Drawing.Point(107, 182);
            this.drawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerCount.Name = "drawerCount";
            this.drawerCount.Size = new System.Drawing.Size(120, 20);
            this.drawerCount.TabIndex = 4;
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.FormattingEnabled = true;
            this.SurfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.SurfaceMaterial.Location = new System.Drawing.Point(107, 250);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(262, 21);
            this.SurfaceMaterial.TabIndex = 5;
            // 
            // deliveryTime
            // 
            this.deliveryTime.FormattingEnabled = true;
            this.deliveryTime.Items.AddRange(new object[] {
            "Rush Order - 3 Days (extra charge)",
            "Rush Order - 5 Days (extra charge)",
            "Rush Order - 7 Days (extra charge)",
            "Normal Order - 14 Days (No extra Charge)"});
            this.deliveryTime.Location = new System.Drawing.Point(142, 304);
            this.deliveryTime.Name = "deliveryTime";
            this.deliveryTime.Size = new System.Drawing.Size(227, 21);
            this.deliveryTime.TabIndex = 6;
            this.deliveryTime.ValueMemberChanged += new System.EventHandler(this.deliveryTime_ValueMemberChanged);
            this.deliveryTime.TextChanged += new System.EventHandler(this.deliveryTime_TextChanged);
            this.deliveryTime.Leave += new System.EventHandler(this.deliveryTime_Leave);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(157, 76);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(120, 20);
            this.width.TabIndex = 2;
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.width_Validating);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(157, 130);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(120, 20);
            this.depth.TabIndex = 3;
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(107, 405);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(75, 23);
            this.btnGetQuote.TabIndex = 7;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // DeliveryDays
            // 
            this.DeliveryDays.Location = new System.Drawing.Point(142, 331);
            this.DeliveryDays.Name = "DeliveryDays";
            this.DeliveryDays.Size = new System.Drawing.Size(100, 20);
            this.DeliveryDays.TabIndex = 8;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeliveryDays);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.depth);
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
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
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
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.TextBox DeliveryDays;
    }
}