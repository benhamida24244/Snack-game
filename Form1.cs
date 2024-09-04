using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Snake_Project
{
    public partial class Form1 : Form
    {
        private List<Point> Snake = new List<Point>();
        private Point food = new Point();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        string direction = "left";

        Timer gameTimer = new Timer();

        private SoundPlayer gameOverSound;
        private SoundPlayer eatAppleSound;
        private SoundPlayer movementSound;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(KeyIsDown);
            this.FullPanel.Paint += UpdatePictureBoxGraphics;

            // Add this line to connect the button click event
            this.btnNewGame.Click += new EventHandler(btnNewGame_Click);

            new Settings();
            LoadHighScore();
            StartNewGame();
            gameOverSound = new SoundPlayer(@"GameOver.wav");
            eatAppleSound = new SoundPlayer(@"EatApple.wav");
            movementSound = new SoundPlayer(@"Movemment.wav");
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            MoveSnake();

            if (CheckCollision())
            {
                GameOver();
                return;
            }

            if (Snake[0] == food)
            {
                EatFood();
            }

            FullPanel.Invalidate();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (direction != "right") direction = "left";
                    break;
                case Keys.D:
                    if (direction != "left") direction = "right";
                    break;
                case Keys.W:
                    if (direction != "down") direction = "up";
                    break;
                case Keys.S:
                    if (direction != "up") direction = "down";
                    break;
            }
            PlayMovementSound();
            Console.WriteLine($"Direction changed to: {direction}");
        }

        private void MoveSnake()
        {
            Point newHead = Snake[0];
            switch (direction)
            {
                case "left":
                    newHead.X--;
                    break;
                case "right":
                    newHead.X++;
                    break;
                case "up":
                    newHead.Y--;
                    break;
                case "down":
                    newHead.Y++;
                    break;
            }

            if (newHead.X < 0)
                newHead.X = maxWidth;
            if (newHead.X > maxWidth)
                newHead.X = 0;
            if (newHead.Y < 0)
                newHead.Y = maxHeight;
            if (newHead.Y > maxHeight)
                newHead.Y = 0;

            Snake.Insert(0, newHead);
            Snake.RemoveAt(Snake.Count - 1);

            Console.WriteLine($"New snake head: X={newHead.X}, Y={newHead.Y}");
        }
        private void PlayMovementSound()
        {
            try
            {
                movementSound.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing movement sound: {ex.Message}");
            }
        }

        private bool CheckCollision()
        {
            for (int i = 1; i < Snake.Count; i++)
            {
                if (Snake[0] == Snake[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            for (int i = 0; i < Snake.Count; i++)
            {
                Brush snakeColour = (i == 0) ? Brushes.Black : Brushes.DarkGreen;
                canvas.FillRectangle(snakeColour, new Rectangle(
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height));
            }

            canvas.FillEllipse(Brushes.Red, new Rectangle(
                food.X * Settings.Width,
                food.Y * Settings.Height,
                Settings.Width, Settings.Height));

            canvas.DrawString($"Direction: {direction}", new Font("Arial", 12), Brushes.Black, 10, 10);
        }

        private void StartNewGame()
        {
            maxWidth = FullPanel.Width / Settings.Width - 1;
            maxHeight = FullPanel.Height / Settings.Height - 1;

            Snake.Clear();
            score = 0;
            LbResult.Text = "0";

            Point startPoint = new Point(maxWidth / 2, maxHeight / 2);
            Snake.Add(startPoint);
            Snake.Add(new Point(startPoint.X + 1, startPoint.Y));
            Snake.Add(new Point(startPoint.X + 2, startPoint.Y));

            direction = "left";

            GenerateFood();

            gameTimer.Stop();
            gameTimer.Interval = 200;
            gameTimer.Tick -= GameTimerEvent;  // Remove previous event handler
            gameTimer.Tick += GameTimerEvent;  // Add new event handler
            gameTimer.Start();

            Console.WriteLine("New game started");
        }

        private void EatFood()
        {
            score += 1;
            LbResult.Text = score.ToString();

            Snake.Add(new Point(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y));

            GenerateFood();
            PlayEatAppleSound();
            Console.WriteLine("Food eaten! Score: " + score);

            if (score > highScore)
            {
                highScore = score;
                lbHighScore.Text = highScore.ToString();
                SaveHighScore();
            }
        }

        private void GenerateFood()
        {
            do
            {
                food.X = rand.Next(0, maxWidth + 1);
                food.Y = rand.Next(0, maxHeight + 1);
            } while (Snake.Contains(food));

            Console.WriteLine($"New food generated at: X={food.X}, Y={food.Y}");
        }
        private void PlayEatAppleSound()
        {
            try
            {
                eatAppleSound.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing eat apple sound: {ex.Message}");
            }
        }
        private void GameOver()
        {
            gameTimer.Stop();

            // تشغيل صوت Game Over
            try
            {
                gameOverSound.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing sound: {ex.Message}");
            }

            MessageBox.Show($"Game Over! Your score: {score}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadHighScore()
        {
            if (File.Exists("highscore.txt"))
            {
                highScore = int.Parse(File.ReadAllText("highscore.txt"));
                lbHighScore.Text = highScore.ToString();
            }
        }

        private void SaveHighScore()
        {
            File.WriteAllText("highscore.txt", highScore.ToString());
        }
    }

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public Settings()
        {
            Width = 20;
            Height = 20;
        }
    }
}