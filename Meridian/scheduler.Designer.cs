namespace Meridian
{
    partial class scheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scheduler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timePicker0 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 310);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timePicker0
            // 
            this.timePicker0.CustomFormat = "dd/MM/yy - HH:mm:ss";
            this.timePicker0.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker0.Location = new System.Drawing.Point(23, 56);
            this.timePicker0.Name = "timePicker0";
            this.timePicker0.Size = new System.Drawing.Size(188, 20);
            this.timePicker0.TabIndex = 3;
            // 
            // scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 752);
            this.Controls.Add(this.timePicker0);
            this.Controls.Add(this.pictureBox1);
            this.Name = "scheduler";
            this.Text = "scheduler";
            this.Load += new System.EventHandler(this.scheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker timePicker0;
    }
}