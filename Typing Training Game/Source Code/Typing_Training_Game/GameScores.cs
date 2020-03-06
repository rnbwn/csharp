/*
 * User: Stefan Batricevic
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace Typing_Training_Game
{
	public partial class GameSettings : Form
	{
		public GameSettings()
		{
			InitializeComponent();
			showScores();
		}
		//procedure to display the scores
		public void showScores()
		{
			//username from temp file is collected 
			const string usernamePath = "TempUser.txt";
			var readUserFile = new System.IO.StreamReader(usernamePath);
			string username = readUserFile.ReadLine();			
			//path to the csv that holds all the game scores
			const string allDetailsPath = "GameScores.csv";
			var readAllDetails = new System.IO.StreamReader(allDetailsPath);
			//Lists to hold the csv information to be manipulated
			var listA = new List<string>();
			var allScores = new List<Scores>();
			//Stores each line in the csv into listA
			while(!readAllDetails.EndOfStream)
			{			
				var line = readAllDetails.ReadLine();
				listA.Add(line);
			}
			//Each value is split and the data is set to the score in integer,
			//username in string and date played in string within a cs called Scores
			//which uses getters and setters to assign the data for sorting
			foreach(string value in listA)
			{
				string[] data = value.Split(',');
				var score = new Scores(Convert.ToInt32(data[0]), data[1], data[2]);
				allScores.Add(score);
			}
			//Uses the object Linq to order the scores in Descending by getting them from Scores.cs
			var sortedList = allScores.OrderByDescending(a => a.score).ThenBy(a=>a.username).ThenBy(a=>a.playDate);
			//Title of the data within the text box
			leaderBoardTextBox.AppendText("Username, Score, Date Played\n");
			
			//Each value within the sorted list is assigned to the leaderboard text box to be viewed
			foreach(Scores value in sortedList)
			{
				leaderBoardTextBox.AppendText(value.username +" , " + value.score + " , "+ value.playDate + "\n");
				leaderBoardTextBox.Font = new Font("Times New Roman", 16);
			}
			//Title of the data within the text box
			personalScoreTextBox.AppendText("Username, Score, Date Played\n");
			
			//Each value within the sorted list is assigned to the personal text box to be viewed
			foreach(Scores value in sortedList)
			{
				//username value is checked and the information corresponding to the user allows for
				//personal scores to be displayed
				if(value.username == username)
				{
					personalScoreTextBox.AppendText(value.username + " , "+ value.score + " , "+ value.playDate + "\n");
					personalScoreTextBox.Font = new Font("Times New Roman", 16);
				}
			}
			//Closes all the files opened
			readUserFile.Close();
			readAllDetails.Close();
		}
	}
}
