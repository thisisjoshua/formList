namespace jcravenAS7
{
    partial class ChartersSummary
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
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblLowest1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblAverage1 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.lblLowest1);
            this.gbHeader.Controls.Add(this.lblTotal);
            this.gbHeader.Controls.Add(this.lblLowest);
            this.gbHeader.Controls.Add(this.lblAverage1);
            this.gbHeader.Controls.Add(this.lblTotal1);
            this.gbHeader.Controls.Add(this.lblAverage);
            this.gbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHeader.Location = new System.Drawing.Point(11, 13);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(652, 373);
            this.gbHeader.TabIndex = 1;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Charter Summary";
            // 
            // lblLowest1
            // 
            this.lblLowest1.AutoSize = true;
            this.lblLowest1.Location = new System.Drawing.Point(6, 76);
            this.lblLowest1.Name = "lblLowest1";
            this.lblLowest1.Size = new System.Drawing.Size(179, 24);
            this.lblLowest1.TabIndex = 5;
            this.lblLowest1.Text = "Lowest Charter Fee:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(223, 161);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(326, 47);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLowest
            // 
            this.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowest.Location = new System.Drawing.Point(223, 65);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(326, 47);
            this.lblLowest.TabIndex = 3;
            this.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverage1
            // 
            this.lblAverage1.AutoSize = true;
            this.lblAverage1.Location = new System.Drawing.Point(6, 289);
            this.lblAverage1.Name = "lblAverage1";
            this.lblAverage1.Size = new System.Drawing.Size(200, 24);
            this.lblAverage1.TabIndex = 2;
            this.lblAverage1.Text = "Average Charter Fees:";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(6, 184);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(170, 24);
            this.lblTotal1.TabIndex = 1;
            this.lblTotal1.Text = "Total Charter Fees:";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(223, 278);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(326, 47);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // charterManagerBindingSource
            // 
            this.charterManagerBindingSource.DataSource = typeof(jcravenAS7.CharterManager);
            // 
            // ChartersSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 399);
            this.Controls.Add(this.gbHeader);
            this.Name = "ChartersSummary";
            this.Text = "ChartersSummary";
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.BindingSource charterManagerBindingSource;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.Label lblLowest1;
        private System.Windows.Forms.Label lblAverage1;
        private System.Windows.Forms.Label lblTotal1;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label lblLowest;
        internal System.Windows.Forms.Label lblAverage;
    }
}