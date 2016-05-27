namespace Pingpong_game
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_label = new System.Windows.Forms.Label();
            this.play_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pingpong_game.Properties.Resources.ping_pong_table_tennis_racket_ball_grunge_background_rackets_eps_illustration_isolated_white_40609487;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.exit_label);
            this.panel1.Controls.Add(this.play_label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 393);
            this.panel1.TabIndex = 4;
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.BackColor = System.Drawing.Color.Transparent;
            this.exit_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_label.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_label.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.exit_label.Location = new System.Drawing.Point(544, 343);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(95, 42);
            this.exit_label.TabIndex = 1;
            this.exit_label.Text = "Exit";
            this.exit_label.Click += new System.EventHandler(this.exit_label_Click);
            // 
            // play_label
            // 
            this.play_label.AutoSize = true;
            this.play_label.BackColor = System.Drawing.Color.Transparent;
            this.play_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_label.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_label.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.play_label.Location = new System.Drawing.Point(12, 343);
            this.play_label.Name = "play_label";
            this.play_label.Size = new System.Drawing.Size(99, 42);
            this.play_label.TabIndex = 0;
            this.play_label.Text = "Play";
            this.play_label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.play_label_MouseClick);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 394);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pingPong";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label play_label;
        private System.Windows.Forms.Label exit_label;
    }
}

