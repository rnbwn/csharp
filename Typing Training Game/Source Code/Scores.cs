/*
 * User: Stefan Batricevic
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Typing_Training_Game
{
	//Gets and sets the scores for each line within the csv file when called for
	public partial class Scores
	{
		public virtual int score {get;set;}
		public virtual string username {get;set;}
		public virtual string playDate {get;set;}
	
	
		public Scores(int newScore, string uName, string date){
			score = newScore;
			username = uName;
			playDate = date;
		}
	}
	public partial class Scores : Form
	{
		public Scores()
		{
			InitializeComponent();
		}
	}
}

