
namespace IKEADB
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListOFRoooms = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Serieses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListOFRoooms
            // 
            this.ListOFRoooms.FormattingEnabled = true;
            this.ListOFRoooms.ItemHeight = 16;
            this.ListOFRoooms.Location = new System.Drawing.Point(69, 160);
            this.ListOFRoooms.Name = "ListOFRoooms";
            this.ListOFRoooms.Size = new System.Drawing.Size(120, 84);
            this.ListOFRoooms.TabIndex = 1;
            this.ListOFRoooms.SelectedIndexChanged += new System.EventHandler(this.ListOFRoooms_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Series names";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Serieses
            // 
            this.Serieses.FormattingEnabled = true;
            this.Serieses.ItemHeight = 16;
            this.Serieses.Location = new System.Drawing.Point(503, 160);
            this.Serieses.Name = "Serieses";
            this.Serieses.Size = new System.Drawing.Size(120, 84);
            this.Serieses.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Serieses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListOFRoooms);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListOFRoooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Serieses;
    }
}

