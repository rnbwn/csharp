/*
 * User: Stefan Batricevic
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace Typing_Training_Game
{
	//
	//User creates an account from this form
	//
	public partial class RegisterForm : Form
	{
		public RegisterForm()
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
		
		//The user will have to go through each procedure to generate an account with the register button
		void Register_buttonClick(object sender, EventArgs e)
		{
			//Stores the users username, password and recovery ID
			var username_list = new List<string>();
			var password_list = new List<string>();
			var recovery_list = new List<string>();
			
			//Stores the users inputs from the textboxes
			string checkUsername, checkPassword, checkConfirmPassword;
			checkUsername = username_input.Text;
			checkPassword = password_input.Text;
			checkConfirmPassword = confirm_password_input.Text;
			
			//Goes through each textbox checking if they are filled before creating an account.
			if(string.IsNullOrWhiteSpace(username_input.Text))
			{
				MessageBox.Show("Username field is empty.");
			}else
			{
				if(string.IsNullOrWhiteSpace(password_input.Text))
				{
					MessageBox.Show("Password field is empty.");
				}else
				{
					while(checkConfirmPassword != checkPassword)
					{
						MessageBox.Show("Confirm Password does not match password.");
						break;
					}
					
					if(checkPassword == checkConfirmPassword)
					{
						//Data is aded to the lists to be removed externally
						username_list.Add(checkUsername.Trim());
						password_list.Add(checkPassword.Trim());
						
						//Used to generate a recovery code for each user account generated
						int assign = 0;
						while(assign <1)
						{
							var r = new Random();
							var recoveryCode = ("R" + r.Next(0,9) + r.Next(0,9) + r.Next(0,9) 
                                + "-" + r.Next(0,9) + r.Next(0,9) + r.Next(0,9));
							recovery_list.Add(recoveryCode);
							assign++;
						}
						//Checks if username exists already
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
						readAllDetails.Close();
						//Used to check the recovery code from the user input
						bool matched = false;
						foreach(string value in listA)
						{
							string[] data = value.Split(',');
							//when the recovery code is correct the corresponding data is stored
							//and the data is displayed to the user when appended
							if(data[0] == username_input.Text)
							{
								matched = true;
							}
						}
						
						if(matched)
						{
							MessageBox.Show("Username already exists, use another one.");
						}else
						{
							
							//A check that goes through each item in the list to display within the details_textBox
							foreach(string userDetails in username_list)
							{
								details_textBox.AppendText("Username: " + userDetails);
							}
							foreach(string passDetails in password_list)
							{
								details_textBox.AppendText("\nPassword: " + passDetails);
							}
							foreach(string recoveryDetails in recovery_list)
							{
								details_textBox.AppendText("\nRecovery Code: " + recoveryDetails);
							}
							//Opens the connection to the csv file and stores the registered account into the csv accordingly
							//Will only store the account if all the fields are correct
							var newLine = string.Format("{0},{1},{2}", username_list[0], password_list[0], recovery_list[0]);
							var csv = new StringBuilder();
							csv.AppendLine(newLine);
							System.IO.File.AppendAllText("UserDetails.csv", csv.ToString());
							//Displayes to the user that the account was created 
							MessageBox.Show("Account registered go back and Login.");
							//Disables the register password to prevent double clicking.
							register_button.Enabled = false;
						}
					}
				}
			}
		}
		//ends process when application is exited
		void RegisterFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
