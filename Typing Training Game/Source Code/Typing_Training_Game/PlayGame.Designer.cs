/*
 * Created by SharpDevelop.
 * User: Stefan
 * Date: 03/03/2019
 * Time: 22:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Typing_Training_Game
{
	partial class PlayGame
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label opportunitiesLabel;
		private System.Windows.Forms.Label opportunitiesIntLabel;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Label scoreIntLabel;
		private System.Windows.Forms.Label countdownLabel;
		private System.Windows.Forms.Label coverLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
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
			this.opportunitiesLabel = new System.Windows.Forms.Label();
			this.opportunitiesIntLabel = new System.Windows.Forms.Label();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.scoreIntLabel = new System.Windows.Forms.Label();
			this.countdownLabel = new System.Windows.Forms.Label();
			this.coverLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// opportunitiesLabel
			// 
			this.opportunitiesLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.opportunitiesLabel.Location = new System.Drawing.Point(13, 13);
			this.opportunitiesLabel.Name = "opportunitiesLabel";
			this.opportunitiesLabel.Size = new System.Drawing.Size(159, 34);
			this.opportunitiesLabel.TabIndex = 0;
			this.opportunitiesLabel.Text = "Opportunities:";
			this.opportunitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// opportunitiesIntLabel
			// 
			this.opportunitiesIntLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.opportunitiesIntLabel.Location = new System.Drawing.Point(159, 13);
			this.opportunitiesIntLabel.Name = "opportunitiesIntLabel";
			this.opportunitiesIntLabel.Size = new System.Drawing.Size(36, 34);
			this.opportunitiesIntLabel.TabIndex = 1;
			this.opportunitiesIntLabel.Text = "5";
			this.opportunitiesIntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// scoreLabel
			// 
			this.scoreLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreLabel.Location = new System.Drawing.Point(201, 13);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(138, 34);
			this.scoreLabel.TabIndex = 2;
			this.scoreLabel.Text = "Score:";
			this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// scoreIntLabel
			// 
			this.scoreIntLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreIntLabel.Location = new System.Drawing.Point(269, 13);
			this.scoreIntLabel.Name = "scoreIntLabel";
			this.scoreIntLabel.Size = new System.Drawing.Size(158, 34);
			this.scoreIntLabel.TabIndex = 3;
			this.scoreIntLabel.Text = "0";
			this.scoreIntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// countdownLabel
			// 
			this.countdownLabel.Location = new System.Drawing.Point(13, 13);
			this.countdownLabel.Name = "countdownLabel";
			this.countdownLabel.Size = new System.Drawing.Size(1194, 520);
			this.countdownLabel.TabIndex = 4;
			this.countdownLabel.Text = "0";
			// 
			// coverLabel
			// 
			this.coverLabel.Location = new System.Drawing.Point(12, 13);
			this.coverLabel.Name = "coverLabel";
			this.coverLabel.Size = new System.Drawing.Size(284, 34);
			this.coverLabel.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(779, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(103, 69);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(908, 64);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(103, 69);
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(1041, 64);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(103, 69);
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 40);
			this.label1.TabIndex = 9;
			this.label1.Text = "End Score:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(159, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(358, 44);
			this.label2.TabIndex = 10;
			// 
			// PlayGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1219, 542);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.coverLabel);
			this.Controls.Add(this.scoreIntLabel);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.opportunitiesIntLabel);
			this.Controls.Add(this.opportunitiesLabel);
			this.Controls.Add(this.countdownLabel);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PlayGame";
			this.ShowIcon = false;
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayGameKeyPress);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
