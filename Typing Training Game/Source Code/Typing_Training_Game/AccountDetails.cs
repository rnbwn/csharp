/*
 * User: Stefan Batricevic
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Typing_Training_Game
{
	public partial class AccountDetails : Form
	{
		public AccountDetails()
		{
			InitializeComponent();
			displayAccountDetails();
		}
		//holds the pasword and recovery of the account
		public string password;
		public string recovery;
		//procedure to display the account within the text boxes.
		public void displayAccountDetails()
		{
			//All the connections to the temporary files
			const string usernamePath = "TempUser.txt";
			var readUserFile = new System.IO.StreamReader(usernamePath);
			string username = readUserFile.ReadLine();			
			//gathers the details from the csv
			const string allDetailsPath = "UserDetails.csv";
			var readAllDetails = new System.IO.StreamReader(allDetailsPath);
			//all details stored in list to be split and checked
			var listA = new List<string>();
			while(!readAllDetails.EndOfStream)
			{
				var line = readAllDetails.ReadLine();				
				listA.Add(line);
				Console.WriteLine(line);
			}
			//checks each value within the list to display the correct data of user
			foreach(string value in listA)
			{
				string[] data = value.Split(',');
				//matches all the usernames to the temp user to gather correct details
				if(data[0] == username)
				{
					password = data[1];
					recovery = data[2];
				}
			}
			//The text boxes having the details displayed
			usernameTextBox.AppendText(username);
			usernameTextBox.Font = new Font("Times New Roman", 20);
			passwordTextBox.AppendText(password);
			passwordTextBox.Font = new Font("Times New Roman", 20);
			recoveryTextBox.AppendText(recovery);
			recoveryTextBox.Font = new Font("Times New Roman", 20);
			//closes the open files
			readAllDetails.Close();
			readUserFile.Close();
		}
	}
}
