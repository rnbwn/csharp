/*
 * User: Stefan Batricevic
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Typing_Training_Game
{
	//
	//User accesses game from this form
	//
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		//Returns user to the menu
		void Return_buttonClick(object sender, EventArgs e)
		{
			var back = new MainForm();
			this.Hide();
			back.Show(this);
		}
		//stores the username of the field logged in with
		public string storeUsername;
		//Checks the user information to access the next frame
		void Login_buttonClick(object sender, EventArgs e)
		{
			//Login details are retrieved from text files
			const string usernamePath = "TempUser.txt";
			var storeUserFile = new System.IO.StreamWriter(usernamePath);
			//accesses the csv file to store the details within
			const string allDetailsPath = "UserDetails.csv";
			var readAllDetails = new System.IO.StreamReader(allDetailsPath);
			//Adds all the items from the csv into ListA to be checked
			bool matched = false;
			var listA = new List<string>();
			while(!readAllDetails.EndOfStream)
			{
				//reads each line within the csv and saves it for checking
				var line = readAllDetails.ReadLine();				
				listA.Add(line);
				Console.WriteLine(line);
			}
			//Goes through each vlaue within the list and splits the
			//parts to be checked for logging in
			foreach(string value in listA)
			{
				//each element is split, checked and matched to allow the login
				string[] data = value.Split(',');
				if(data[0] == username_input.Text.Trim() &&
				   data[1] == password_input.Text.Trim())
				{
					matched = true;
					storeUserFile.WriteLine(data[0]);
				}
			}
			//if the information inputted is correct the game starts
			if(matched)
			{
					//Once the details are correct the user is taken to the game menu
					var game_form = new Game();
					this.Hide();
					game_form.Show(this);
			}else
				{
					MessageBox.Show("Access Denied");
				}
			//Closes the files opened
			readAllDetails.Close();
			storeUserFile.Close();
		}
		//ends the program when the frame is closed
		void LoginFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}	
	}
}
