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
	//User accesses account data from this form
	//
	public partial class RecoveryForm : Form
	{
		public RecoveryForm()
		{
			InitializeComponent();
		}
		//holds the username and password for display to user
		public string username;
		public string password;
		//Returns user to the menu
		void Return_buttonClick(object sender, EventArgs e)
		{
			var back = new MainForm();
			this.Hide();
			back.Show(this);
		}
		//User is taken to the login form 
		void Login_pageClick(object sender, EventArgs e)
		{
			var go_to_login_form = new LoginForm();
			this.Hide();
			go_to_login_form.Show(this);
		}
		//User will go through recovery procedures to gather the details of the account
		void Recovery_buttonClick(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(recovery_input.Text))
			{
				MessageBox.Show("Recovery field is empty.");
			}else
			{
				//Opens the path towards the csv
				const string allDetailsPath = "UserDetails.csv";
				var readAllDetails = new System.IO.StreamReader(allDetailsPath);
				//Goes through each line of the csv and stores into listA
				var listA = new List<string>();
				while(!readAllDetails.EndOfStream)
				{
					var line = readAllDetails.ReadLine();				
					listA.Add(line);
					Console.WriteLine(line);
				}
				//Used to check the recovery code from the user input
				
				bool matched = false;
				foreach(string value in listA)
				{
					string[] data = value.Split(',');
					//when the recovery code is correct the corresponding data is stored
					//and the data is displayed to the user when appended
					if(data[2] == recovery_input.Text.Trim())
					{
						matched = true;
						username = data[0];
						password = data[1];
					}
				}
				//When matched the details are displayed to the user 
				if(matched){
					//Shows the details into the details box
					details_textBox.AppendText("Username: "+username);
					details_textBox.AppendText("\nPassword: "+password);
					recovery_button.Enabled = false;
				}else
				{
					MessageBox.Show("Recovery code is incorrect. Check hyphens and spacing.");
				}
				//Closes the open files
				readAllDetails.Close();
			}
		}
		//ends the process when the application is closed
		void RecoveryFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}		
	}
}
