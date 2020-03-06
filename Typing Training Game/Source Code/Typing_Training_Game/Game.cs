/*
 * User: Stefan Batricevic
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Typing_Training_Game
{
	//
	//The main section of the game that consists of all the form movement and dislpays
	//
	public partial class Game : Form
	{
		//sets the game from as the parent form to pass into the play form
		private PlayGame gameDisplay;
		public Game()
		{
			InitializeComponent();
		}
		//procedure to enable the buttons
		public void enableButtons()
		{
			playGameButton.Enabled = true;
			colourBlindButton.Enabled = true;
			accountDetailsButton.Enabled = true;
			gameSettingsButton.Enabled = true;
		}
		//The play game button that loads the PlayGame frame
		public void PlayGameButtonClick(object sender, EventArgs e)
		{
			overallPanel.Controls.Clear();
			gameDisplay = new PlayGame(this);
			gameDisplay.TopLevel = false;
			overallPanel.Controls.Add(gameDisplay);
			gameDisplay.Show();
			//On play button press all the other buttons are disabled
			playGameButton.Enabled = false;
			colourBlindButton.Enabled = false;
			accountDetailsButton.Enabled = false;
			gameSettingsButton.Enabled = false;
		}
		//The colour blind button that loads the ColourBlindModes frame
		public void ColourBlindButtonClick(object sender, EventArgs e)
		{
			overallPanel.Controls.Clear();
			var colourBlindDisplay = new ColourBlindMode();
			colourBlindDisplay.TopLevel = false;
			overallPanel.Controls.Add(colourBlindDisplay);
			colourBlindDisplay.Show();
		}
		//the account details button that loads the AccountDetails frame 
		public void AccountDetailsButtonClick(object sender, EventArgs e)
		{
			overallPanel.Controls.Clear();
			var accountDisplay = new AccountDetails();
			accountDisplay.TopLevel = false;
			overallPanel.Controls.Add(accountDisplay);
			accountDisplay.Show();
		}
		//The game setting button that loads the GameSettings frame
		public void GameSettingsButtonClick(object sender, EventArgs e)
		{
			overallPanel.Controls.Clear();
			var gameSettingsDisplay = new GameSettings();
			gameSettingsDisplay.TopLevel = false;
			overallPanel.Controls.Add(gameSettingsDisplay);
			gameSettingsDisplay.Show();
		}
		//ends the process when the application is closed
		void GameFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
