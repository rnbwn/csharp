/*
 * User: Stefan Batricevic
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Typing_Training_Game
{
	public partial class ColourBlindMode : Form
	{
		public ColourBlindMode()
		{
			InitializeComponent();
			displayedPictures();
		}
		//allows for the temp colour mode to be opened
		public const string colourModePath = "ColourMode.txt";
		//display the pictures of the colours
		public void displayedPictures()
		{
			//Normal
			pictureBox1.ImageLocation = "Data\\Normal.gif";
			pictureBox1.SizeMode =PictureBoxSizeMode.StretchImage;
			
			//Protanopia
			pictureBox2.ImageLocation = "Data\\Protanopia.gif";
			pictureBox2.SizeMode =PictureBoxSizeMode.StretchImage;
			
			//Tritanopia
			pictureBox3.ImageLocation = "Data\\Tritanopia.gif";
			pictureBox3.SizeMode =PictureBoxSizeMode.StretchImage;
			
			//Deuteranopia
			pictureBox4.ImageLocation = "Data\\Deuteranopia.gif";
			pictureBox4.SizeMode =PictureBoxSizeMode.StretchImage;
		}
		//Buttons that change the text file to whatever button pressed
		public void NormalChangeButtonClick(object sender, EventArgs e)
		{
			var saveColourModeFile = new System.IO.StreamWriter(colourModePath);
			saveColourModeFile.WriteLine("Normal");
			saveColourModeFile.Close();
			
			label9.Text = "Normal";
			label9.Refresh();
		}
		public void ProtanopiaChangeButtonClick(object sender, EventArgs e)
		{
			var saveColourModeFile = new System.IO.StreamWriter(colourModePath);
			saveColourModeFile.WriteLine("Protanopia");
			saveColourModeFile.Close();
			
			label9.Text = "Protanopia";
			label9.Refresh();
		}
		public void TritanopiaChangeButtonClick(object sender, EventArgs e)
		{
			var saveColourModeFile = new System.IO.StreamWriter(colourModePath);
			saveColourModeFile.WriteLine("Tritanopia");
			saveColourModeFile.Close();
			
			label9.Text = "Tritanopia";
			label9.Refresh();
		}
		public void DeuteranopiaChangeButtonClick(object sender, EventArgs e)
		{
			var saveColourModeFile = new System.IO.StreamWriter(colourModePath);
			saveColourModeFile.WriteLine("Deuteranopia");
			saveColourModeFile.Close();
			
			label9.Text = "Deuteranopia";
			label9.Refresh();
		}
	}
}
