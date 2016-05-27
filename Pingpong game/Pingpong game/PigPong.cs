using System;

using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace Pingpong_game
{
    public partial class PingPong : Form
    {
        public PingPong()
        {
            InitializeComponent();
        }

        


        Boolean Player_Up = false;
        Boolean Player_Down = false;
        Boolean BallGoingLeft = true;
        Boolean GameOn = false;

        TimeSpan time;
        int Speed_Player;
        int Speed_Enemy;
        int BallSpeed;
        int BallForce;
        int Round = 0;
        PictureBox[] Score_Player = new PictureBox[5];
        PictureBox[] Score_Enemy = new PictureBox[5];
        Color ScoreColor = Color.Silver;
        Random rng = new Random();
        string str;


        private void PigPong_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                switch (e.KeyCode)
                {
                    case Keys.W:
                    case Keys.Up:
                        Player_Down = false;
                        Player_Up = true;
                        break;
                    case Keys.S:
                    case Keys.Down:
                        Player_Up = false;
                        Player_Down = true;
                        break;
                    case Keys.Space:
                        GameOn = true;

                        label_Start.Visible = false;
                        break;

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        public Boolean Collision_Left(PictureBox obj)
        {
            if (obj.Location.X <= 0)
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Right(PictureBox obj)
        {
            if (obj.Location.X + obj.Width >= WorldFrame.Width)
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Up(PictureBox obj)
        {
            if (obj.Location.Y <= 0)
            {
                return true;
            }
            return false;
        }

        public Boolean Collision_Down(PictureBox obj)
        {
            if (obj.Location.Y + obj.Height >= WorldFrame.Height)
            {
                return true;
            }
            return false;
        }

        private void playSimpleSound()
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"c:\bse5\mnb.wav");
            simpleSound.Play();
        }
        
        

        public Boolean Collision_Enemy(PictureBox tar)
        {
            PictureBox temp1 = new PictureBox();
            temp1.Bounds = pb_Enemy.Bounds;

            temp1.SetBounds(temp1.Location.X , temp1.Location.Y, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                BallForce = 3;
                playSimpleSound();
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 5, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                BallForce = 2;
                playSimpleSound();
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                BallForce = 1;
                playSimpleSound();
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                BallForce = 0;
                playSimpleSound();
                return true;

            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                BallForce = -1;
                playSimpleSound();
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                BallForce = -2;
                playSimpleSound();
                return true;
            }
            temp1.SetBounds(temp1.Location.X, temp1.Location.Y + 10, 1, 10);
            if (tar.Bounds.IntersectsWith(temp1.Bounds))
            {
                BallForce = -3;
                playSimpleSound();
                return true;
            }
            return false;
        }



        

        public Boolean Collision_Player(PictureBox tar)
        {
            
                PictureBox temp1 = new PictureBox();
                temp1.Bounds = pb_Player.Bounds;
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y, 1, 30);

                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = 3;
                    pb_Ball.BackColor = Color.Purple;
                    playSimpleSound();
                    return true;
                }
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y + 5, 1, 30);

                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = 2;
                    pb_Ball.BackColor = Color.Red;
                    playSimpleSound();
                    return true;
                }
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y + 10, 1, 30);

                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = 1;
                    pb_Ball.BackColor = Color.Orange;
                    playSimpleSound();
                    return true;
                }
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y + 10, 1, 30);

                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = 0;
                    pb_Ball.BackColor = Color.Brown;
                    playSimpleSound();
                    return true;
                }
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y + 10, 1, 30);

                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = -1;
                    pb_Ball.BackColor = Color.Chocolate;
                    playSimpleSound();
                    return true;
                }
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y + 10, 1, 30);

                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = -2;
                    pb_Ball.BackColor = Color.Yellow;
                    playSimpleSound();
                    return true;
                }
                temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y + 10, 1, 30);

                if (tar.Bounds.IntersectsWith(temp1.Bounds))
                {
                    BallForce = -3;
                    playSimpleSound();
                    pb_Ball.BackColor = Color.LightBlue;
                    return true;
                }
           
            return false;
        }


        
        public void ApplySettings()
        {

            BallSpeed = 4;
            timer_Moveball.Interval = 1;
            timer_Enemy.Interval = 1;
            Speed_Enemy = 3;
            Speed_Player = 3;

        }

        //function to reverse ball direction if it strikes with top or bottom.
        
        public int ReverseInt(int x, Boolean Force = false)
        {
            
                if (Force)
                {

                    if (x > 0)
                    {
                        x = ~x + 1;    //20,-21
                    }

                    else
                    {
                        x = ~x + 1; //-20,19
                    }
                }
                 return x;
            }
            
        


        //Timer to move the ball and player

        private void timer_Moveball_Tick(object sender, EventArgs e)
        {
            ApplySettings();
            

                if (GameOn)
                {
                    if (Player_Up && !Collision_Up(pb_Player))
                    {
                        pb_Player.Top -= Speed_Player;     //moves player up
                    }
                    if (Player_Down && !Collision_Down(pb_Player))
                    {
                        pb_Player.Top += Speed_Player; //moves player down
                    }


                    if (BallGoingLeft)
                    {
                        if (Collision_Left(pb_Ball))
                        {
                            AddScore(Score_Player);

                            Thread.Sleep(200);

                            pb_Ball.Location = new Point(400, rng.Next(10, 190));

                            pb_Player.Location = new Point(0, 68);
                            BallForce = 0;

                        }
                        if (Collision_Player(pb_Ball) == false)
                        {
                            pb_Ball.Left -= BallSpeed;  //moves ball to left
                        }
                        else
                        {
                            BallGoingLeft = false;
                        }
                    }
                    else
                    {
                        if (Collision_Right(pb_Ball))
                        {

                            AddScore(Score_Enemy);
                            Thread.Sleep(200);

                            pb_Ball.Location = new Point(206, 67);
                            BallForce = 0;
                        }
                        if (!Collision_Enemy(pb_Ball))
                        {
                            pb_Ball.Left += BallSpeed;   //moves ball to right
                        }
                        else
                        {
                            BallGoingLeft = true;
                        }
                    }
                    if (BallForce > 0)
                    {
                        pb_Ball.Top -= BallForce;
                    }
                    if (BallForce < 0)
                    {
                        pb_Ball.Top -= BallForce;
                    }

                    if (pb_Ball.Location.Y <= 1)
                    {
                        BallForce = ReverseInt(BallForce, true);  //reverses direction of ball if it hits the top
                    }
                    if (pb_Ball.Location.Y + pb_Ball.Height >= WorldFrame.Height)
                    {
                        BallForce = ReverseInt(BallForce, true); //reverses direction of ball if it hits the floor
                    }
                }
            }
            
            
            

       


        
        
        private void PigPong_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Score_Player[i] = PicID(i+1);
                Score_Enemy[i] = PicID(i+1 , true);
            }
            CircleThis(pb_Ball);
            CircleRackets(pb_Enemy);
            CircleRackets(pb_Player);
            ApplySettings();
            pb_Ball.Location = new Point(208, rng.Next(10, 190));
            
        }

        //Timer to move enemy

        private void timer_Enemy_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (pb_Enemy.Location.Y + 28 < pb_Ball.Location.Y)
                {
                    pb_Enemy.Top += Speed_Enemy;
                }
                else
                {
                    pb_Enemy.Top -= Speed_Enemy;
                }
                
            }
        }

        
        
        
        //Adds score if player or enemy loses.

        public void AddScore(PictureBox[] Arr)
        {
            try {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].BackColor == ScoreColor)
                    {
                        Arr[i].BackColor = Color.OrangeRed;
                        break;
                    }
                }
                if (enemy_5.BackColor == Color.OrangeRed)
                {
                    this.Hide();
                    dialoguebox obj = new dialoguebox(str);
                    obj.Show();
                }
                if (player_5.BackColor == Color.OrangeRed)
                {

                    this.Hide();
                    looser obj = new looser(str);
                    obj.Show();
                }

                if (Arr[4].BackColor == Color.OrangeRed)
                {

                    GameOn = false;
                    label_Start.Visible = true;
                    RestoreScore();
                    pb_Ball.Location = new Point(208, rng.Next(10, 190));
                    pb_Player.Location = new Point(0, 127);
                    pb_Enemy.Location = new Point(673, 127);

                    timer_lbl.Visible = false;

                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        public PictureBox PicID(int i, Boolean Enemy = false)
        {
            if (Enemy)
            {
                switch (i)
                {
                    case 1:
                        return enemy_1;
                    case 2:
                        return enemy_2;
                    case 3:
                        return enemy_3;
                    case 4:
                        return enemy_4;
                    case 5:
                        return enemy_5;
                }
            }
            else
            {
                switch (i)
                {
                    case 1:
                        return player_1;
                    case 2:
                        return player_2;
                    case 3:
                        return player_3;
                    case 4:
                        return player_4;
                    case 5:
                        return player_5;
                }
            }
            return pb_Ball;
        }

        public void RestoreScore()
        {
            for (int i = 0; i <= 5; i++)
            {
                PicID(i).BackColor = ScoreColor;
                PicID(i, true).BackColor = ScoreColor;
            }
        }

        //Function to make bal ellipse

        public void CircleThis(PictureBox pic)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pic.Width - 3, pic.Height - 3);

            Region rg = new Region(gp);
            pic.Region = rg;
        }

        //Function to make vertical bars ellipse

        public void CircleRackets(PictureBox pic)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pic.Width - 1, pic.Height - 1);
            Region rg = new Region(gp);
            pic.Region = rg;
        }

       

        //Function used for timer.

        private void timer_Sec_Tick(object sender, EventArgs e)
        {
             if (GameOn)
            {
                
                timer_lbl.Visible = true;
                Round++;
                time = TimeSpan.FromSeconds(Round);

                str = time.ToString(@"mm\:ss");
                timer_lbl.Text = "Time: " + str;
            }
        }
    }
}
