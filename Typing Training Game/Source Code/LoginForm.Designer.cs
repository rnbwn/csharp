/*
 * Created by SharpDevelop.
 * User: Stefan
 * Date: 06/02/2019
 * Time: 09:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Typing_Training_Game
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button return_button;
		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.TextBox username_input;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox password_input;
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
			this.return_button = new System.Windows.Forms.Button();
			this.login_button = new System.Windows.Forms.Button();
			this.username_input = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.password_input = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// return_button
			// 
			this.return_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.return_button.Location = new System.Drawing.Point(12, 271);
			this.return_button.Name = "return_button";
			this.return_button.Size = new System.Drawing.Size(390, 46);
			this.return_button.TabIndex = 0;
			this.return_button.Text = "Back";
			this.return_button.UseVisualStyleBackColor = true;
			this.return_button.Click += new System.EventHandler(this.Return_buttonClick);
			// 
			// login_button
			// 
			this.login_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_button.Location = new System.Drawing.Point(12, 219);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(390, 46);
			this.login_button.TabIndex = 1;
			this.login_button.Text = "Login";
			this.login_button.UseVisualStyleBackColor = true;
			this.login_button.Click += new System.EventHandler(this.Login_buttonClick);
			// 
			// username_input
			// 
			this.username_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_input.Location = new System.Drawing.Point(12, 85);
			this.username_input.Name = "username_input";
			this.username_input.Size = new System.Drawing.Size(390, 30);
			this.username_input.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 36);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 36);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// password_input
			// 
			this.password_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_input.Location = new System.Drawing.Point(12, 155);
			this.password_input.Name = "password_input";
			this.password_input.Size = new System.Drawing.Size(390, 30);
			this.password_input.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(390, 44);
			this.label3.TabIndex = 6;
			this.label3.Text = "Login";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 330);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.password_input);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.username_input);
			this.Controls.Add(this.login_button);
			this.Controls.Add(this.return_button);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.ShowIcon = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
