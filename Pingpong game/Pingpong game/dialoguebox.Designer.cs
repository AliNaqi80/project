namespace Pingpong_game
{
    partial class dialoguebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialoguebox));
            this.dialogue_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.replay_button = new System.Windows.Forms.Button();
            this.labeltime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogue_label
            // 
            this.dialogue_label.AutoSize = true;
            this.dialogue_label.BackColor = System.Drawing.Color.Transparent;
            this.dialogue_label.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogue_label.ForeColor = System.Drawing.Color.Navy;
            this.dialogue_label.Location = new System.Drawing.Point(114, 160);
            this.dialogue_label.Name = "dialogue_label";
            this.dialogue_label.Size = new System.Drawing.Size(175, 33);
            this.dialogue_label.TabIndex = 1;
            this.dialogue_label.Text = "You Won!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pingpong_game.Properties.Resources.gold_star_clipart_no_background_MiLL8zB9T;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(83, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Pingpong_game.Properties.Resources.gold_star_clipart_no_background_MiLL8zB9T;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(239, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Pingpong_game.Properties.Resources.gold_star_clipart_no_background_MiLL8zB9T;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(164, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // replay_button
            // 
            this.replay_button.BackColor = System.Drawing.Color.Transparent;
            this.replay_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replay_button.Image = global::Pingpong_game.Properties.Resources.Hopstarter_Button_Button_Play;
            this.replay_button.Location = new System.Drawing.Point(164, 249);
            this.replay_button.Name = "replay_button";
            this.replay_button.Size = new System.Drawing.Size(52, 42);
            this.replay_button.TabIndex = 7;
            this.replay_button.UseVisualStyleBackColor = false;
            this.replay_button.Click += new System.EventHandler(this.replay_button_Click);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.BackColor = System.Drawing.Color.Transparent;
            this.labeltime.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.labeltime.ForeColor = System.Drawing.Color.Navy;
            this.labeltime.Location = new System.Drawing.Point(68, 202);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(0, 33);
            this.labeltime.TabIndex = 8;
            // 
            // dialoguebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pingpong_game.Properties.Resources.download__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 303);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.replay_button);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dialogue_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dialoguebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pingPong";
            this.Load += new System.EventHandler(this.dialoguebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dialogue_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button replay_button;
        private System.Windows.Forms.Label labeltime;
    }
}