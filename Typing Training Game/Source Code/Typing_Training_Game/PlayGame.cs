/*
 * User: Stefan Batricevic
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;

namespace Typing_Training_Game
{	
	public partial class PlayGame : Form
	{
		
		private Game gamePanel;
		
		public PlayGame(Game game)
		{
			InitializeComponent();
			gamePanel = game;
			resetOpportunities();
			countdownVisual();
			
		}
		//Timer designated for the countdown of the game.
		//counter used for the countdown display
		public System.Windows.Forms.Timer timer1;
		public int counter = 3;
		//Stopwatch for each individual key to be checked when the game is running
		public Stopwatch keyTimer1 = new System.Diagnostics.Stopwatch();
		public Stopwatch keyTimer2 = new System.Diagnostics.Stopwatch();
		public Stopwatch keyTimer3 = new System.Diagnostics.Stopwatch();
		public Stopwatch keyTimer4 = new System.Diagnostics.Stopwatch();
		//Generates the letters to press and change
		public char letterToPress = Letter.GetLetter();
		public char letterToPress2 = Letter.GetLetter();
		public char letterToPress3 = Letter.GetLetter();
		//The locations of where the picture box can move
		public Random randomGenerator = new Random();
		public int xBounds = 1090;
		public int yBounds = 414;
		//variables for the score and opportunities preview
		public int score = 0;
		public int opportunities = 7;
		//the delay for when the next animation is to be displayed
		public int delay = 1500;
		public int currentDelayIncrement = 500;
		
		//procedure to reset the opportunities when they run out
		public void resetOpportunities(){
			opportunities = 7;
		}
		//Stores the score and username and the time played when the games over
		public void saveWhenGameOver()
		{
			//path to the username
			const string usernamePath = "TempUser.txt";
			var storeUserFile = new System.IO.StreamReader(usernamePath);
			string username = storeUserFile.ReadLine();
			//csv format for storing the new line in the correct format of
			//score, username, date played for other cs files to access in the same format
			var newLine = string.Format("{0},{1},{2}", score, username, DateTime.Today.ToString("dd/MM/yyyy"));
			var csv = new StringBuilder();
			csv.AppendLine(newLine);
			System.IO.File.AppendAllText("GameScores.csv", csv.ToString());
			storeUserFile.Close();
		}
		//this is the display of the countdown for the user
		public void countdownVisual()
		{
			timer1= new System.Windows.Forms.Timer();
			timer1.Tick += new EventHandler(timer1_tick);
			timer1.Interval = 1000;
			timer1.Start();
			countdownLabel.Text = counter.ToString();
			countdownLabel.Font = new Font ("Arial", 325);
			label1.Visible = false;
			label2.Visible = false;
		}
		//the main loop of the program
		public void timer1_tick(object sender, EventArgs e)
		{
			counter --;
			if (counter == 0)
			{
				//Starts the timer when the game is starting
				keyTimer1.Start();
				keyTimer2.Start();
				keyTimer3.Start();
				//Removing the countdown label once it finishes
				countdownLabel.Visible = false;
				//Uses an individual label to cover and show the labels
				coverLabel.SendToBack();
				//Implements the change image procedure once the timers done
				changeImage();
			}
			//Displays the countdown timer on the frame
			countdownLabel.Text = counter.ToString();
			//Label settings that refresh the score and opportunities
			scoreIntLabel.Text = score.ToString();
			scoreIntLabel.Refresh();
			opportunitiesIntLabel.Text = opportunities.ToString();
			opportunitiesIntLabel.Refresh();
			//Ends the game when there are no more chances
			if(opportunities <= 0)
			{	
				//Removes the timers that are running and covers the score and opportunities
				keyTimer1.Stop();
				keyTimer2.Stop();
				keyTimer3.Stop();
				pictureBox1.Hide();
				timer1.Stop();
				//covers the labels to display gameover
				coverLabel.Visible = true;
				coverLabel.BringToFront();
				//Displays the Game Over label to the user 
				countdownLabel.Visible = true;
				countdownLabel.BringToFront();
				countdownLabel.Text = "Game Over";
				countdownLabel.Font = new Font("Arial", 75);
				//displays the score to the user
				label1.Visible = true;
				label1.BringToFront();
				label2.Text = score.ToString();
				label2.Visible = true;
				label2.BringToFront();
				//enables the buttons once the game is over
				gamePanel.enableButtons();				
				resetOpportunities();
				saveWhenGameOver();	
			}
			//The delay of images decreases at certain sections of the score
			if (score > currentDelayIncrement)
			{
				delay = delay -125;
				currentDelayIncrement = currentDelayIncrement+2500;
			}
			//After 2.5 seconds the image will change and rmeove an opportunity
			if(keyTimer1.Elapsed.TotalMilliseconds>2500 | keyTimer2.Elapsed.TotalMilliseconds>2500 
				| keyTimer3.Elapsed.TotalMilliseconds>2500)
			{
				//this delays the image for the value set/changed
				if(keyTimer1.Elapsed.TotalMilliseconds>2100+delay)
				{
					opportunities--;
					changeImage();
				}
				if(keyTimer2.Elapsed.TotalMilliseconds>2100+delay && score> 5000)
				{
					opportunities--;
					//Change letter generated if the same as other two
					if(letterToPress2 == letterToPress | letterToPress2 == letterToPress3)
					{
        				letterToPress2 = Letter.GetLetter();
        				changeImage2();
					}else
					{
						changeImage2();
					}
				}
				if(keyTimer3.Elapsed.TotalMilliseconds>2100+delay && score> 10000)
				{
					opportunities--;
					if(letterToPress3 == letterToPress | letterToPress3 == letterToPress2)
					{
        				letterToPress3 = Letter.GetLetter();
        				changeImage3();
					}else
					{
						changeImage3();
					}
				}
			}
		}
		
		//This would generate a random letter to be used
		//to be selected from the folder full of animations.
		public static class Letter
		{
		    static Random _random = new Random();
		    public static char GetLetter()
		    {
		        int num = _random.Next(0, 26);
		        /*
		        By the use of a random letter and the flow of
		        characters within c# a simple alignment of both can 
		        select the random letter
		        */
		        char let = (char)('a' + num);
		        return let;
		    }
		}
		//Generates the random locations of where the picture box should be
		public int[] GenerateRandomNumbers()
        {
            var RandomNumbers = new int[2];
            RandomNumbers[0] = randomGenerator.Next(103, xBounds);
            RandomNumbers[1] = randomGenerator.Next(69, yBounds);
            return RandomNumbers;
        }
		//Used to move the location of the picture boxes
		//Generates and checkes the location and if there is an intersection,
		//new location numbers are generated till there is no intersection of images
		public void MoveThePictureBox1()
        {
            int[] numbers = GenerateRandomNumbers();
            pictureBox1.Location = new Point(numbers[0], numbers[1]);
            while(pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) 
                  | pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
            	numbers = GenerateRandomNumbers();
            	pictureBox1.Location = new Point(numbers[0], numbers[1]);
            }
        }
		public void MoveThePictureBox2()
        {
            int[] numbers = GenerateRandomNumbers();
            pictureBox2.Location = new Point(numbers[0], numbers[1]);
            while(pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds) 
                  | pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
            	numbers = GenerateRandomNumbers();
            	pictureBox2.Location = new Point(numbers[0], numbers[1]);
            }
        }
		public void MoveThePictureBox3()
        {
            int[] numbers = GenerateRandomNumbers();
            pictureBox3.Location = new Point(numbers[0], numbers[1]);
            while(pictureBox3.Bounds.IntersectsWith(pictureBox1.Bounds) 
                  | pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
            	numbers = GenerateRandomNumbers();
            	pictureBox3.Location = new Point(numbers[0], numbers[1]);
            }
        }
		//Where the image is changed and gathered from the folders
		public void changeImage()
		{
			//Reads the temporary file of the colour mode to use in the program
			const string colourModePath = "ColourMode.txt";
			var readColourModeFile = new System.IO.StreamReader(colourModePath);
			string colourMode = readColourModeFile.ReadLine();
			
			//Gathers the next letter of the program to use
			letterToPress = Letter.GetLetter();
			//file path of the images
			pictureBox1.ImageLocation = "Data\\" + colourMode + "\\" + letterToPress + ".gif";   
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			//procedure called to move the image around the page
			MoveThePictureBox1();
			//Restarts the timer that is used to check each animation for change
			keyTimer1.Restart();
		}
		public void changeImage2()
		{
			//Reads the temporary file of the colour mode to use in the program
			const string colourModePath = "ColourMode.txt";
			var readColourModeFile = new System.IO.StreamReader(colourModePath);
			string colourMode = readColourModeFile.ReadLine();
			//Gathers the next letter of the program to use
			letterToPress2 = Letter.GetLetter();
			//file path of the images
			pictureBox2.ImageLocation = "Data\\" + colourMode + "\\" + letterToPress2 + ".gif";   
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			//procedure called to move the image around the page
			MoveThePictureBox2();
			//Restarts the timer that is used to check each animation for change
			keyTimer2.Restart();
		}
		public void changeImage3()
		{
			//Reads the temporary file of the colour mode to use in the program
			const string colourModePath = "ColourMode.txt";
			var readColourModeFile = new System.IO.StreamReader(colourModePath);
			string colourMode = readColourModeFile.ReadLine();
			//Gathers the next letter of the program to use
			letterToPress3 = Letter.GetLetter();
			//file path of the images
			pictureBox3.ImageLocation = "Data\\" + colourMode + "\\" + letterToPress3 + ".gif";   
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			//procedure called to move the image around the page
			MoveThePictureBox3();
			//Restarts the timer that is used to check each animation for change
			keyTimer3.Restart();
		}
		//Uses the frame to analyse the key press events handled on the frame 
		public void PlayGameKeyPress(object sender, KeyPressEventArgs e)
		{
			
			//Checks the characters pressed on the frame
			char keyPressed = e.KeyChar;
			//Checks if the user has pressed the same displayed key
			//Score added when the correct letter is pressed
			if(letterToPress == keyPressed | letterToPress2 == keyPressed | letterToPress3 == keyPressed)
			{
				if(keyTimer1.Elapsed.TotalMilliseconds <= 100 | keyTimer2.Elapsed.TotalMilliseconds <= 100
				         | keyTimer3.Elapsed.TotalMilliseconds <= 100)
				{
					score += 240;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 200 | keyTimer2.Elapsed.TotalMilliseconds <= 200
				         | keyTimer3.Elapsed.TotalMilliseconds <= 200)
				{
					score += 230;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 300 | keyTimer2.Elapsed.TotalMilliseconds <= 300
				         | keyTimer3.Elapsed.TotalMilliseconds <= 300)
				{
					score += 220;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 400 | keyTimer2.Elapsed.TotalMilliseconds <= 400
				         | keyTimer3.Elapsed.TotalMilliseconds <= 400)
				{
					score += 210;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 500 | keyTimer2.Elapsed.TotalMilliseconds <= 500
				         | keyTimer3.Elapsed.TotalMilliseconds <= 500)
				{
					score += 200;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 600 | keyTimer2.Elapsed.TotalMilliseconds <= 600
				         | keyTimer3.Elapsed.TotalMilliseconds <= 600)
				{
					score += 190;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 700 | keyTimer2.Elapsed.TotalMilliseconds <= 700
				         | keyTimer3.Elapsed.TotalMilliseconds <= 700)
				{
					score += 180;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 800 | keyTimer2.Elapsed.TotalMilliseconds <= 800
				         | keyTimer3.Elapsed.TotalMilliseconds <= 800)
				{
					score += 170;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 900 | keyTimer2.Elapsed.TotalMilliseconds <= 900
				         | keyTimer3.Elapsed.TotalMilliseconds <= 900)
				{
					score += 160;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1000 | keyTimer2.Elapsed.TotalMilliseconds <= 1000
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1000)
				{
					score += 150;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1100 | keyTimer2.Elapsed.TotalMilliseconds <= 1100
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1100)
				{
					score += 140;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1200 | keyTimer2.Elapsed.TotalMilliseconds <= 1200
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1200)
				{
					score += 130;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1300 | keyTimer2.Elapsed.TotalMilliseconds <= 1300
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1300)
				{
					score += 120;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1400 | keyTimer2.Elapsed.TotalMilliseconds <= 1400
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1400)
				{
					score += 110;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1500 | keyTimer2.Elapsed.TotalMilliseconds <= 1500
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1500)
				{
					score += 100;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1600 | keyTimer2.Elapsed.TotalMilliseconds <= 1600
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1600)
				{
					score += 90;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1700 | keyTimer2.Elapsed.TotalMilliseconds <= 1700
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1700)
				{
					score += 80;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1800 | keyTimer2.Elapsed.TotalMilliseconds <= 1800
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1800)
				{
					score += 70;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 1900 | keyTimer2.Elapsed.TotalMilliseconds <= 1900
				         | keyTimer3.Elapsed.TotalMilliseconds <= 1900)
				{
					score += 60;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 2000 | keyTimer2.Elapsed.TotalMilliseconds <= 2000
				         | keyTimer3.Elapsed.TotalMilliseconds <= 2000)
				{
					score += 50;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 2100 | keyTimer2.Elapsed.TotalMilliseconds <= 2100
				         | keyTimer3.Elapsed.TotalMilliseconds <= 2100)
				{
					score += 40;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 2200 | keyTimer2.Elapsed.TotalMilliseconds <= 2200
				         | keyTimer3.Elapsed.TotalMilliseconds <= 2200)
				{
					score += 30;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 2300 | keyTimer2.Elapsed.TotalMilliseconds <= 2300
				         | keyTimer3.Elapsed.TotalMilliseconds <= 2300)
				{
					score += 20;
				}else if(keyTimer1.Elapsed.TotalMilliseconds <= 2400 | keyTimer2.Elapsed.TotalMilliseconds <= 2400
				         | keyTimer3.Elapsed.TotalMilliseconds <= 2400)
				{
					score += 10;
				}
				//Changes the images when the correct one is pressed
				if(letterToPress == keyPressed)
				{
					changeImage();
				}
				if(letterToPress2 == keyPressed && score>5000)
				{
					changeImage2();
				}
				if(letterToPress3 == keyPressed && score>10000)
				{
					changeImage3();
				}
			}	
		}
	}
}
