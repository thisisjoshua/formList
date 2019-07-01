namespace jcravenAS7
{
    partial class program16
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCH = new System.Windows.Forms.NumericUpDown();
            this.cboYS = new System.Windows.Forms.ComboBox();
            this.cboYT = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnAddCharter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYachtSize = new System.Windows.Forms.Label();
            this.lblYachtType = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allChartersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfChartersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartersSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetForNextCharterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCH)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Developed by Josh Craven";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCH);
            this.groupBox1.Controls.Add(this.cboYS);
            this.groupBox1.Controls.Add(this.cboYT);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.btnAddCharter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblYachtSize);
            this.groupBox1.Controls.Add(this.lblYachtType);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 283);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charter Info:";
            // 
            // nudCH
            // 
            this.nudCH.DecimalPlaces = 2;
            this.nudCH.Location = new System.Drawing.Point(150, 191);
            this.nudCH.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCH.Name = "nudCH";
            this.nudCH.Size = new System.Drawing.Size(270, 29);
            this.nudCH.TabIndex = 8;
            this.nudCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboYS
            // 
            this.cboYS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboYS.FormattingEnabled = true;
            this.cboYS.Items.AddRange(new object[] {
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45"});
            this.cboYS.Location = new System.Drawing.Point(150, 135);
            this.cboYS.Name = "cboYS";
            this.cboYS.Size = new System.Drawing.Size(270, 32);
            this.cboYS.TabIndex = 7;
            // 
            // cboYT
            // 
            this.cboYT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboYT.ContextMenuStrip = this.contextMenuStrip1;
            this.cboYT.FormattingEnabled = true;
            this.cboYT.Items.AddRange(new object[] {
            "Express Cruiser",
            "Flybridge",
            "Sedan Bridge",
            "Motor Yacht",
            "Tri-Deck",
            "Sportfish",
            "Skylounge",
            "Mega Yacht"});
            this.cboYT.Location = new System.Drawing.Point(150, 83);
            this.cboYT.Name = "cboYT";
            this.cboYT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboYT.Size = new System.Drawing.Size(270, 32);
            this.cboYT.TabIndex = 6;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(150, 36);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(270, 29);
            this.txtCustomer.TabIndex = 5;
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddCharter
            // 
            this.btnAddCharter.Location = new System.Drawing.Point(150, 226);
            this.btnAddCharter.Name = "btnAddCharter";
            this.btnAddCharter.Size = new System.Drawing.Size(270, 32);
            this.btnAddCharter.TabIndex = 4;
            this.btnAddCharter.Text = "Add Charter";
            this.btnAddCharter.UseVisualStyleBackColor = true;
            this.btnAddCharter.Click += new System.EventHandler(this.btnAddCharter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "C&harter Hours:";
            // 
            // lblYachtSize
            // 
            this.lblYachtSize.AutoSize = true;
            this.lblYachtSize.Location = new System.Drawing.Point(6, 138);
            this.lblYachtSize.Name = "lblYachtSize";
            this.lblYachtSize.Size = new System.Drawing.Size(103, 24);
            this.lblYachtSize.TabIndex = 2;
            this.lblYachtSize.Text = "Y&acht Size:";
            // 
            // lblYachtType
            // 
            this.lblYachtType.AutoSize = true;
            this.lblYachtType.Location = new System.Drawing.Point(6, 86);
            this.lblYachtType.Name = "lblYachtType";
            this.lblYachtType.Size = new System.Drawing.Size(110, 24);
            this.lblYachtType.TabIndex = 1;
            this.lblYachtType.Text = "&Yacht Type:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(6, 36);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(96, 24);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "&Customer:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allChartersToolStripMenuItem,
            this.numberOfChartersToolStripMenuItem,
            this.chartersSummaryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.displayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // allChartersToolStripMenuItem
            // 
            this.allChartersToolStripMenuItem.Enabled = false;
            this.allChartersToolStripMenuItem.Name = "allChartersToolStripMenuItem";
            this.allChartersToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.allChartersToolStripMenuItem.Text = "All Charters";
            this.allChartersToolStripMenuItem.Click += new System.EventHandler(this.allChartersToolStripMenuItem_Click);
            // 
            // numberOfChartersToolStripMenuItem
            // 
            this.numberOfChartersToolStripMenuItem.Enabled = false;
            this.numberOfChartersToolStripMenuItem.Name = "numberOfChartersToolStripMenuItem";
            this.numberOfChartersToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.numberOfChartersToolStripMenuItem.Text = "Number of Charters for Selected Yacht Size";
            this.numberOfChartersToolStripMenuItem.Click += new System.EventHandler(this.numberOfChartersToolStripMenuItem_Click_1);
            // 
            // chartersSummaryToolStripMenuItem
            // 
            this.chartersSummaryToolStripMenuItem.Enabled = false;
            this.chartersSummaryToolStripMenuItem.Name = "chartersSummaryToolStripMenuItem";
            this.chartersSummaryToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.chartersSummaryToolStripMenuItem.Text = "Charters Summary";
            this.chartersSummaryToolStripMenuItem.Click += new System.EventHandler(this.chartersSummaryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(375, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addYachtTypeToolStripMenuItem,
            this.removeYachtTypeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.resetForNextCharterToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addYachtTypeToolStripMenuItem
            // 
            this.addYachtTypeToolStripMenuItem.Name = "addYachtTypeToolStripMenuItem";
            this.addYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.addYachtTypeToolStripMenuItem.Text = "Add Yacht Type";
            this.addYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.addYachtTypeToolStripMenuItem_Click);
            // 
            // removeYachtTypeToolStripMenuItem
            // 
            this.removeYachtTypeToolStripMenuItem.Name = "removeYachtTypeToolStripMenuItem";
            this.removeYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.removeYachtTypeToolStripMenuItem.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(231, 6);
            // 
            // resetForNextCharterToolStripMenuItem
            // 
            this.resetForNextCharterToolStripMenuItem.Name = "resetForNextCharterToolStripMenuItem";
            this.resetForNextCharterToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.resetForNextCharterToolStripMenuItem.Text = "Reset for Next Charter";
            this.resetForNextCharterToolStripMenuItem.Click += new System.EventHandler(this.resetForNextCharterToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.removeYachtTypeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Add Yacht Type";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // removeYachtTypeToolStripMenuItem1
            // 
            this.removeYachtTypeToolStripMenuItem1.Name = "removeYachtTypeToolStripMenuItem1";
            this.removeYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.removeYachtTypeToolStripMenuItem1.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem1.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem1_Click);
            // 
            // program16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "program16";
            this.Text = "program16";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCH)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboYS;
        private System.Windows.Forms.ComboBox cboYT;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnAddCharter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYachtSize;
        private System.Windows.Forms.Label lblYachtType;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allChartersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfChartersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartersSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetForNextCharterToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudCH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem1;
    }
}