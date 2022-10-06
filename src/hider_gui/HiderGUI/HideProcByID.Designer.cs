
namespace HiderGUI
{
    partial class HideProcByID
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HideProc = new System.Windows.Forms.TextBox();
            this.hide_proc_by_id = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(91)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 129);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Write Process Name";
            // 
            // HideProc
            // 
            this.HideProc.BackColor = System.Drawing.Color.Yellow;
            this.HideProc.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideProc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(135)))), ((int)(((byte)(41)))));
            this.HideProc.Location = new System.Drawing.Point(82, 159);
            this.HideProc.Multiline = true;
            this.HideProc.Name = "HideProc";
            this.HideProc.Size = new System.Drawing.Size(202, 40);
            this.HideProc.TabIndex = 1;
            // 
            // hide_proc_by_id
            // 
            this.hide_proc_by_id.BackColor = System.Drawing.Color.Black;
            this.hide_proc_by_id.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide_proc_by_id.ForeColor = System.Drawing.Color.Linen;
            this.hide_proc_by_id.Location = new System.Drawing.Point(107, 205);
            this.hide_proc_by_id.Name = "hide_proc_by_id";
            this.hide_proc_by_id.Size = new System.Drawing.Size(137, 38);
            this.hide_proc_by_id.TabIndex = 2;
            this.hide_proc_by_id.Text = "Hide";
            this.hide_proc_by_id.UseVisualStyleBackColor = false;
            this.hide_proc_by_id.Click += new System.EventHandler(this.hide_proc_by_id_Click);
            // 
            // HideProcByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(371, 256);
            this.Controls.Add(this.hide_proc_by_id);
            this.Controls.Add(this.HideProc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HideProcByID";
            this.ShowIcon = false;
            this.Text = "ProcID Hide";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HideProc;
        private System.Windows.Forms.Button hide_proc_by_id;
    }
}