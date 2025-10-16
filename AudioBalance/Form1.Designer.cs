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
            this.trackBarLeft = new System.Windows.Forms.TrackBar();
            this.trackBarRight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volLeft = new System.Windows.Forms.Label();
            this.volRight = new System.Windows.Forms.Label();
            this.trackBarMaster = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.volMaster = new System.Windows.Forms.Label();
            this.trackBarMax = new System.Windows.Forms.TrackBar();
            this.volMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarLeft
            // 
            this.trackBarLeft.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarLeft.LargeChange = 1;
            this.trackBarLeft.Location = new System.Drawing.Point(42, 67);
            this.trackBarLeft.Maximum = 30;
            this.trackBarLeft.Name = "trackBarLeft";
            this.trackBarLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarLeft.Size = new System.Drawing.Size(45, 172);
            this.trackBarLeft.TabIndex = 2;
            this.trackBarLeft.Scroll += new System.EventHandler(this.valLeft_Scroll);
            // 
            // trackBarRight
            // 
            this.trackBarRight.LargeChange = 1;
            this.trackBarRight.Location = new System.Drawing.Point(151, 67);
            this.trackBarRight.Maximum = 30;
            this.trackBarRight.Name = "trackBarRight";
            this.trackBarRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRight.Size = new System.Drawing.Size(45, 172);
            this.trackBarRight.TabIndex = 3;
            this.trackBarRight.Scroll += new System.EventHandler(this.valRight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "L:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "R:";
            // 
            // volLeft
            // 
            this.volLeft.AutoSize = true;
            this.volLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volLeft.Location = new System.Drawing.Point(65, 33);
            this.volLeft.Name = "volLeft";
            this.volLeft.Size = new System.Drawing.Size(26, 29);
            this.volLeft.TabIndex = 4;
            this.volLeft.Text = "0";
            // 
            // volRight
            // 
            this.volRight.AutoSize = true;
            this.volRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volRight.Location = new System.Drawing.Point(170, 33);
            this.volRight.Name = "volRight";
            this.volRight.Size = new System.Drawing.Size(26, 29);
            this.volRight.TabIndex = 5;
            this.volRight.Text = "0";
            // 
            // trackBarMaster
            // 
            this.trackBarMaster.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarMaster.LargeChange = 1;
            this.trackBarMaster.Location = new System.Drawing.Point(8, 90);
            this.trackBarMaster.Maximum = 30;
            this.trackBarMaster.Name = "trackBarMaster";
            this.trackBarMaster.Size = new System.Drawing.Size(263, 45);
            this.trackBarMaster.TabIndex = 0;
            this.trackBarMaster.Scroll += new System.EventHandler(this.valMaster_Scroll);
            this.trackBarMaster.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trackBarMaster_KeyUp);
            this.trackBarMaster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarMaster_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Master:";
            // 
            // volMaster
            // 
            this.volMaster.AutoSize = true;
            this.volMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volMaster.Location = new System.Drawing.Point(144, 38);
            this.volMaster.Name = "volMaster";
            this.volMaster.Size = new System.Drawing.Size(26, 29);
            this.volMaster.TabIndex = 9;
            this.volMaster.Text = "0";
            // 
            // trackBarMax
            // 
            this.trackBarMax.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarMax.LargeChange = 1;
            this.trackBarMax.Location = new System.Drawing.Point(8, 208);
            this.trackBarMax.Maximum = 100;
            this.trackBarMax.Name = "trackBarMax";
            this.trackBarMax.Size = new System.Drawing.Size(263, 45);
            this.trackBarMax.TabIndex = 1;
            this.trackBarMax.Scroll += new System.EventHandler(this.valMax_Scroll);
            // 
            // volMax
            // 
            this.volMax.AutoSize = true;
            this.volMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volMax.Location = new System.Drawing.Point(105, 155);
            this.volMax.Name = "volMax";
            this.volMax.Size = new System.Drawing.Size(26, 29);
            this.volMax.TabIndex = 12;
            this.volMax.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.volMax);
            this.groupBox1.Controls.Add(this.trackBarMaster);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.volMaster);
            this.groupBox1.Controls.Add(this.trackBarMax);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(263, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 266);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBarLeft);
            this.groupBox2.Controls.Add(this.volRight);
            this.groupBox2.Controls.Add(this.trackBarRight);
            this.groupBox2.Controls.Add(this.volLeft);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(19, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 266);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio balance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarLeft;
        private System.Windows.Forms.TrackBar trackBarRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label volLeft;
        private System.Windows.Forms.Label volRight;
        private System.Windows.Forms.TrackBar trackBarMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label volMaster;
        private System.Windows.Forms.TrackBar trackBarMax;
        private System.Windows.Forms.Label volMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

