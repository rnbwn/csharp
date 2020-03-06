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
	partial class AccountDetails
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox usernameTextBox;
		private System.Windows.Forms.RichTextBox passwordTextBox;
		private System.Windows.Forms.RichTextBox recoveryTextBox;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.RichTextBox();
			this.passwordTextBox = new System.Windows.Forms.RichTextBox();
			this.recoveryTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(411, 56);
			this.label1.TabIndex = 7;
			this.label1.Text = "Account Details";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(12, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(411, 56);
			this.label2.TabIndex = 8;
			this.label2.Text = "Username:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(411, 56);
			this.label3.TabIndex = 9;
			this.label3.Text = "Password:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 230);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(411, 56);
			this.label4.TabIndex = 10;
			this.label4.Text = "Recovery Code:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Location = new System.Drawing.Point(343, 109);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(497, 56);
			this.usernameTextBox.TabIndex = 11;
			this.usernameTextBox.Text = "";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(343, 171);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(497, 56);
			this.passwordTextBox.TabIndex = 12;
			this.passwordTextBox.Text = "";
			// 
			// recoveryTextBox
			// 
			this.recoveryTextBox.Location = new System.Drawing.Point(343, 230);
			this.recoveryTextBox.Name = "recoveryTextBox";
			this.recoveryTextBox.Size = new System.Drawing.Size(497, 56);
			this.recoveryTextBox.TabIndex = 13;
			this.recoveryTextBox.Text = "";
			// 
			// AccountDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.recoveryTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AccountDetails";
			this.ShowIcon = false;
			this.ResumeLayout(false);

		}
	}
}
