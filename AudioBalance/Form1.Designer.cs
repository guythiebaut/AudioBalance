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
            this.valMaster = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.volMaster = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // valLeft
            // 
            this.valLeft.BackColor = System.Drawing.SystemColors.Control;
            this.valLeft.Location = new System.Drawing.Point(25, 181);
            this.valLeft.Maximum = 100;
            this.valLeft.Name = "valLeft";
            this.valLeft.Size = new System.Drawing.Size(263, 45);
            this.valLeft.TabIndex = 0;
            this.valLeft.Scroll += new System.EventHandler(this.valLeft_Scroll);
            // 
            // valRight
            // 
            this.valRight.Location = new System.Drawing.Point(353, 181);
            this.valRight.Maximum = 100;
            this.valRight.Name = "valRight";
            this.valRight.Size = new System.Drawing.Size(263, 45);
            this.valRight.TabIndex = 1;
            this.valRight.Scroll += new System.EventHandler(this.valRight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Right:";
            // 
            // volLeft
            // 
            this.volLeft.AutoSize = true;
            this.volLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volLeft.Location = new System.Drawing.Point(123, 139);
            this.volLeft.Name = "volLeft";
            this.volLeft.Size = new System.Drawing.Size(84, 39);
            this.volLeft.TabIndex = 4;
            this.volLeft.Text = "0.00";
            // 
            // volRight
            // 
            this.volRight.AutoSize = true;
            this.volRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volRight.Location = new System.Drawing.Point(467, 139);
            this.volRight.Name = "volRight";
            this.volRight.Size = new System.Drawing.Size(84, 39);
            this.volRight.TabIndex = 5;
            this.volRight.Text = "0.00";
            // 
            // valMaster
            // 
            this.valMaster.BackColor = System.Drawing.SystemColors.Control;
            this.valMaster.Location = new System.Drawing.Point(353, 62);
            this.valMaster.Maximum = 100;
            this.valMaster.Name = "valMaster";
            this.valMaster.Size = new System.Drawing.Size(263, 45);
            this.valMaster.TabIndex = 6;
            this.valMaster.Scroll += new System.EventHandler(this.valMaster_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Master:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "Audio Balance";
            // 
            // volMaster
            // 
            this.volMaster.AutoSize = true;
            this.volMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volMaster.Location = new System.Drawing.Point(500, 11);
            this.volMaster.Name = "volMaster";
            this.volMaster.Size = new System.Drawing.Size(84, 39);
            this.volMaster.TabIndex = 9;
            this.volMaster.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(681, 256);
            this.Controls.Add(this.volMaster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valMaster);
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
            ((System.ComponentModel.ISupportInitialize)(this.valMaster)).EndInit();
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
        private System.Windows.Forms.TrackBar valMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label volMaster;
    }
}

