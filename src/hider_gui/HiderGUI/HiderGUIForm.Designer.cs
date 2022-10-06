
namespace HiderGUI
{
    partial class HiderGUIForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiderGUIForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clicker_dsd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.supportme_on_patreon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.installdependencies = new System.Windows.Forms.Button();
            this.readme = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hidedll_files = new System.Windows.Forms.Button();
            this.hidefiles = new System.Windows.Forms.Button();
            this.hide_dir = new System.Windows.Forms.Button();
            this.hide_process_by_pid = new System.Windows.Forms.Button();
            this.unhide_all = new System.Windows.Forms.Button();
            this.prot_image = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportme_on_patreon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(188)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.clicker_dsd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.supportme_on_patreon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 90);
            this.panel1.TabIndex = 0;
            // 
            // clicker_dsd
            // 
            this.clicker_dsd.AutoSize = true;
            this.clicker_dsd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clicker_dsd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clicker_dsd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clicker_dsd.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clicker_dsd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clicker_dsd.Location = new System.Drawing.Point(550, 6);
            this.clicker_dsd.Name = "clicker_dsd";
            this.clicker_dsd.Size = new System.Drawing.Size(116, 69);
            this.clicker_dsd.TabIndex = 3;
            this.clicker_dsd.Text = "Driver\r\nSignature\r\nDisabler\r\n";
            this.clicker_dsd.Click += new System.EventHandler(this.clicker_dsd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(154)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(406, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "It\'s program to \r\nhide anyone \r\nwhat you want";
            // 
            // supportme_on_patreon
            // 
            this.supportme_on_patreon.Image = ((System.Drawing.Image)(resources.GetObject("supportme_on_patreon.Image")));
            this.supportme_on_patreon.Location = new System.Drawing.Point(28, 14);
            this.supportme_on_patreon.Name = "supportme_on_patreon";
            this.supportme_on_patreon.Size = new System.Drawing.Size(189, 61);
            this.supportme_on_patreon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.supportme_on_patreon.TabIndex = 1;
            this.supportme_on_patreon.TabStop = false;
            this.supportme_on_patreon.Click += new System.EventHandler(this.supportme_on_patreon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(260, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hider";
            // 
            // installdependencies
            // 
            this.installdependencies.BackColor = System.Drawing.Color.PaleTurquoise;
            this.installdependencies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.installdependencies.FlatAppearance.BorderSize = 3;
            this.installdependencies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.installdependencies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.installdependencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installdependencies.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installdependencies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(118)))), ((int)(((byte)(90)))));
            this.installdependencies.Location = new System.Drawing.Point(25, 138);
            this.installdependencies.Name = "installdependencies";
            this.installdependencies.Size = new System.Drawing.Size(160, 77);
            this.installdependencies.TabIndex = 1;
            this.installdependencies.Text = "Install Dependencies";
            this.installdependencies.UseVisualStyleBackColor = false;
            this.installdependencies.Click += new System.EventHandler(this.installdependencies_Click);
            // 
            // readme
            // 
            this.readme.BackColor = System.Drawing.Color.Sienna;
            this.readme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readme.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.readme.Location = new System.Drawing.Point(25, 21);
            this.readme.Name = "readme";
            this.readme.Size = new System.Drawing.Size(160, 85);
            this.readme.TabIndex = 2;
            this.readme.Text = "ReadMe";
            this.readme.UseVisualStyleBackColor = false;
            this.readme.Click += new System.EventHandler(this.readme_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(104)))), ((int)(((byte)(164)))));
            this.panel2.Controls.Add(this.readme);
            this.panel2.Controls.Add(this.installdependencies);
            this.panel2.Location = new System.Drawing.Point(478, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 231);
            this.panel2.TabIndex = 3;
            // 
            // hidedll_files
            // 
            this.hidedll_files.BackColor = System.Drawing.Color.Green;
            this.hidedll_files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidedll_files.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hidedll_files.ForeColor = System.Drawing.Color.Fuchsia;
            this.hidedll_files.Location = new System.Drawing.Point(233, 94);
            this.hidedll_files.Name = "hidedll_files";
            this.hidedll_files.Size = new System.Drawing.Size(169, 65);
            this.hidedll_files.TabIndex = 4;
            this.hidedll_files.Text = "Hide DLL File";
            this.hidedll_files.UseVisualStyleBackColor = false;
            this.hidedll_files.Click += new System.EventHandler(this.hidedll_files_Click);
            // 
            // hidefiles
            // 
            this.hidefiles.BackColor = System.Drawing.Color.Gold;
            this.hidefiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidefiles.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidefiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hidefiles.Location = new System.Drawing.Point(233, 175);
            this.hidefiles.Name = "hidefiles";
            this.hidefiles.Size = new System.Drawing.Size(169, 50);
            this.hidefiles.TabIndex = 5;
            this.hidefiles.Text = "Hide File";
            this.hidefiles.UseVisualStyleBackColor = false;
            this.hidefiles.Click += new System.EventHandler(this.hidefiles_Click);
            // 
            // hide_dir
            // 
            this.hide_dir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hide_dir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hide_dir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide_dir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(194)))), ((int)(((byte)(61)))));
            this.hide_dir.Location = new System.Drawing.Point(12, 94);
            this.hide_dir.Name = "hide_dir";
            this.hide_dir.Size = new System.Drawing.Size(130, 68);
            this.hide_dir.TabIndex = 6;
            this.hide_dir.Text = "Hide Directory";
            this.hide_dir.UseVisualStyleBackColor = false;
            // 
            // hide_process_by_pid
            // 
            this.hide_process_by_pid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hide_process_by_pid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hide_process_by_pid.FlatAppearance.BorderSize = 3;
            this.hide_process_by_pid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_process_by_pid.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide_process_by_pid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(194)))), ((int)(((byte)(61)))));
            this.hide_process_by_pid.Location = new System.Drawing.Point(12, 175);
            this.hide_process_by_pid.Name = "hide_process_by_pid";
            this.hide_process_by_pid.Size = new System.Drawing.Size(151, 90);
            this.hide_process_by_pid.TabIndex = 7;
            this.hide_process_by_pid.Text = "Hide Process By PID";
            this.hide_process_by_pid.UseVisualStyleBackColor = false;
            this.hide_process_by_pid.Click += new System.EventHandler(this.hide_process_by_pid_Click);
            // 
            // unhide_all
            // 
            this.unhide_all.BackColor = System.Drawing.Color.Green;
            this.unhide_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unhide_all.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unhide_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(48)))));
            this.unhide_all.Location = new System.Drawing.Point(170, 260);
            this.unhide_all.Name = "unhide_all";
            this.unhide_all.Size = new System.Drawing.Size(131, 42);
            this.unhide_all.TabIndex = 8;
            this.unhide_all.Text = "Unhide All";
            this.unhide_all.UseVisualStyleBackColor = false;
            // 
            // prot_image
            // 
            this.prot_image.BackColor = System.Drawing.Color.Red;
            this.prot_image.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prot_image.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prot_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prot_image.Location = new System.Drawing.Point(334, 231);
            this.prot_image.Name = "prot_image";
            this.prot_image.Size = new System.Drawing.Size(138, 71);
            this.prot_image.TabIndex = 9;
            this.prot_image.Text = "Protect Image";
            this.prot_image.UseVisualStyleBackColor = false;
            this.prot_image.Click += new System.EventHandler(this.prot_image_Click);
            // 
            // HiderGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(675, 314);
            this.Controls.Add(this.prot_image);
            this.Controls.Add(this.unhide_all);
            this.Controls.Add(this.hide_process_by_pid);
            this.Controls.Add(this.hide_dir);
            this.Controls.Add(this.hidefiles);
            this.Controls.Add(this.hidedll_files);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HiderGUIForm";
            this.Text = "Hider";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportme_on_patreon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button installdependencies;
        private System.Windows.Forms.Button readme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hidedll_files;
        private System.Windows.Forms.Button hidefiles;
        private System.Windows.Forms.Button hide_dir;
        private System.Windows.Forms.Button hide_process_by_pid;
        private System.Windows.Forms.Button unhide_all;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox supportme_on_patreon;
        private System.Windows.Forms.Label clicker_dsd;
        private System.Windows.Forms.Button prot_image;
    }
}

