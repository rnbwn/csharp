 /*
 * Created by SharpDevelop.
 * User: Stefan
 * Date: 06/02/2019
 * Time: 11:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Typing_Training_Game
{
	partial class Game
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel overallPanel;
		private System.Windows.Forms.Button gameSettingsButton;
		private System.Windows.Forms.Button accountDetailsButton;
		private System.Windows.Forms.Button colourBlindButton;
		private System.Windows.Forms.Button playGameButton;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.overallPanel = new System.Windows.Forms.Panel();
			this.gameSettingsButton = new System.Windows.Forms.Button();
			this.accountDetailsButton = new System.Windows.Forms.Button();
			this.colourBlindButton = new System.Windows.Forms.Button();
			this.playGameButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// overallPanel
			// 
			this.overallPanel.Location = new System.Drawing.Point(13, 72);
			this.overallPanel.Name = "overallPanel";
			this.overallPanel.Size = new System.Drawing.Size(1237, 589);
			this.overallPanel.TabIndex = 11;
			// 
			// gameSettingsButton
			// 
			this.gameSettingsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gameSettingsButton.Location = new System.Drawing.Point(1023, 12);
			this.gameSettingsButton.Name = "gameSettingsButton";
			this.gameSettingsButton.Size = new System.Drawing.Size(178, 56);
			this.gameSettingsButton.TabIndex = 10;
			this.gameSettingsButton.Text = "Game Scores";
			this.gameSettingsButton.UseVisualStyleBackColor = true;
			this.gameSettingsButton.Click += new System.EventHandler(this.GameSettingsButtonClick);
			// 
			// accountDetailsButton
			// 
			this.accountDetailsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.accountDetailsButton.Location = new System.Drawing.Point(839, 12);
			this.accountDetailsButton.Name = "accountDetailsButton";
			this.accountDetailsButton.Size = new System.Drawing.Size(178, 56);
			this.accountDetailsButton.TabIndex = 9;
			this.accountDetailsButton.Text = "Account Details";
			this.accountDetailsButton.UseVisualStyleBackColor = true;
			this.accountDetailsButton.Click += new System.EventHandler(this.AccountDetailsButtonClick);
			// 
			// colourBlindButton
			// 
			this.colourBlindButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colourBlindButton.Location = new System.Drawing.Point(655, 12);
			this.colourBlindButton.Name = "colourBlindButton";
			this.colourBlindButton.Size = new System.Drawing.Size(178, 56);
			this.colourBlindButton.TabIndex = 8;
			this.colourBlindButton.Text = "Colour-Blind Mode";
			this.colourBlindButton.UseVisualStyleBackColor = true;
			this.colourBlindButton.Click += new System.EventHandler(this.ColourBlindButtonClick);
			// 
			// playGameButton
			// 
			this.playGameButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playGameButton.Location = new System.Drawing.Point(471, 12);
			this.playGameButton.Name = "playGameButton";
			this.playGameButton.Size = new System.Drawing.Size(178, 56);
			this.playGameButton.TabIndex = 7;
			this.playGameButton.Text = "Play Game";
			this.playGameButton.UseVisualStyleBackColor = true;
			this.playGameButton.Click += new System.EventHandler(this.PlayGameButtonClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(411, 56);
			this.label1.TabIndex = 6;
			this.label1.Text = "Typing Training Game";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.overallPanel);
			this.Controls.Add(this.gameSettingsButton);
			this.Controls.Add(this.accountDetailsButton);
			this.Controls.Add(this.colourBlindButton);
			this.Controls.Add(this.playGameButton);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Game";
			this.ShowIcon = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameFormClosing);
			this.ResumeLayout(false);

		}
	}
}
