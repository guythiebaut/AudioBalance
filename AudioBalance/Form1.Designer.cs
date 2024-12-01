namespace AudioBalance
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
            this.valLeft = new System.Windows.Forms.TrackBar();
            this.valRight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volLeft = new System.Windows.Forms.Label();
            this.volRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRight)).BeginInit();
            this.SuspendLayout();
            // 
            // valLeft
            // 
            this.valLeft.BackColor = System.Drawing.SystemColors.Control;
            this.valLeft.Location = new System.Drawing.Point(25, 51);
            this.valLeft.Maximum = 100;
            this.valLeft.Name = "valLeft";
            this.valLeft.Size = new System.Drawing.Size(263, 45);
            this.valLeft.TabIndex = 0;
            this.valLeft.ValueChanged += new System.EventHandler(this.valLeft_ValueChanged);
            // 
            // valRight
            // 
            this.valRight.Location = new System.Drawing.Point(310, 51);
            this.valRight.Maximum = 100;
            this.valRight.Name = "valRight";
            this.valRight.Size = new System.Drawing.Size(263, 45);
            this.valRight.TabIndex = 1;
            this.valRight.ValueChanged += new System.EventHandler(this.valRight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Right:";
            // 
            // volLeft
            // 
            this.volLeft.AutoSize = true;
            this.volLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volLeft.Location = new System.Drawing.Point(123, 9);
            this.volLeft.Name = "volLeft";
            this.volLeft.Size = new System.Drawing.Size(84, 39);
            this.volLeft.TabIndex = 4;
            this.volLeft.Text = "0.00";
            // 
            // volRight
            // 
            this.volRight.AutoSize = true;
            this.volRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volRight.Location = new System.Drawing.Point(424, 9);
            this.volRight.Name = "volRight";
            this.volRight.Size = new System.Drawing.Size(84, 39);
            this.volRight.TabIndex = 5;
            this.volRight.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(595, 107);
            this.Controls.Add(this.volRight);
            this.Controls.Add(this.volLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valRight);
            this.Controls.Add(this.valLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio balance";
            ((System.ComponentModel.ISupportInitialize)(this.valLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar valLeft;
        private System.Windows.Forms.TrackBar valRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label volLeft;
        private System.Windows.Forms.Label volRight;
    }
}

