namespace Prototype
{
    partial class Welcome_form
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
            this.play_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_btn
            // 
            this.play_btn.Location = new System.Drawing.Point(108, 100);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(75, 23);
            this.play_btn.TabIndex = 0;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(108, 139);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(75, 23);
            this.settings_btn.TabIndex = 1;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // Welcome_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prototype.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 279);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.play_btn);
            this.Name = "Welcome_form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button settings_btn;
    }
}

