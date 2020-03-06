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
	//The main form of the program where the user can access the login, register, recovery frames.
	//
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			setColourMode();
		}
		
		//Takes user to login frame
		public void Login_buttonClick(object sender, EventArgs e)
		{
			var login_form = new LoginForm();
			this.Hide();
			login_form.Show(this);
		}
		
		//Takes user to register frame
		public void Register_buttonClick(object sender, EventArgs e)
		{
			var register_form = new RegisterForm();
			this.Hide();
			register_form.Show(this);
		}
		
		//Takes user to recovery frame
		public void Recovery_buttonClick(object sender, EventArgs e)
		{
			var recovery_form = new RecoveryForm();
			this.Hide();
			recovery_form.Show(this);
		}
		//sets the default colour mode to normal on launch for the colour blind settings
		public void setColourMode()
		{
			const string colourModePath = "ColourMode.txt";
			var defaultColourModeSet = new System.IO.StreamWriter(colourModePath);
			defaultColourModeSet.WriteLine("Normal");
			defaultColourModeSet.Close();
		}
	}
}
