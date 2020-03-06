/*
 * Created by SharpDevelop.
 * User: Stefan
 * Date: 04/03/2019
 * Time: 00:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Typing_Training_Game
{
	partial class GameSettings
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox leaderBoardTextBox;
		private System.Windows.Forms.RichTextBox personalScoreTextBox;
		private System.Windows.Forms.Label label3;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.leaderBoardTextBox = new System.Windows.Forms.RichTextBox();
			this.personalScoreTextBox = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(411, 56);
			this.label1.TabIndex = 8;
			this.label1.Text = "Game Settings";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(302, 56);
			this.label2.TabIndex = 9;
			this.label2.Text = "Leader Board:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// leaderBoardTextBox
			// 
			this.leaderBoardTextBox.Location = new System.Drawing.Point(13, 147);
			this.leaderBoardTextBox.Name = "leaderBoardTextBox";
			this.leaderBoardTextBox.Size = new System.Drawing.Size(586, 561);
			this.leaderBoardTextBox.TabIndex = 10;
			this.leaderBoardTextBox.Text = "";
			// 
			// personalScoreTextBox
			// 
			this.personalScoreTextBox.Location = new System.Drawing.Point(621, 147);
			this.personalScoreTextBox.Name = "personalScoreTextBox";
			this.personalScoreTextBox.Size = new System.Drawing.Size(586, 561);
			this.personalScoreTextBox.TabIndex = 12;
			this.personalScoreTextBox.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(620, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(302, 56);
			this.label3.TabIndex = 11;
			this.label3.Text = "Personal Scores:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GameSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.personalScoreTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.leaderBoardTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GameSettings";
			this.ShowIcon = false;
			this.ResumeLayout(false);

		}
	}
}
