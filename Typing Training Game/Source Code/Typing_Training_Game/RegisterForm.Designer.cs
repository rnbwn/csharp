/*
 * Created by SharpDevelop.
 * User: Stefan
 * Date: 06/02/2019
 * Time: 09:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Typing_Training_Game
{
	partial class RegisterForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button return_button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox username_input;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox password_input;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox confirm_password_input;
		private System.Windows.Forms.RichTextBox details_textBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button register_button;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.username_input = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.password_input = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.confirm_password_input = new System.Windows.Forms.TextBox();
			this.details_textBox = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.register_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// return_button
			// 
			this.return_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.return_button.Location = new System.Drawing.Point(12, 412);
			this.return_button.Name = "return_button";
			this.return_button.Size = new System.Drawing.Size(252, 46);
			this.return_button.TabIndex = 1;
			this.return_button.Text = "Back";
			this.return_button.UseVisualStyleBackColor = true;
			this.return_button.Click += new System.EventHandler(this.Return_buttonClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(254, 38);
			this.label3.TabIndex = 7;
			this.label3.Text = "Register";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 22);
			this.label1.TabIndex = 9;
			this.label1.Text = "Username:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// username_input
			// 
			this.username_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_input.Location = new System.Drawing.Point(12, 71);
			this.username_input.Name = "username_input";
			this.username_input.Size = new System.Drawing.Size(252, 30);
			this.username_input.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 22);
			this.label2.TabIndex = 11;
			this.label2.Text = "Password:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// password_input
			// 
			this.password_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_input.Location = new System.Drawing.Point(12, 129);
			this.password_input.Name = "password_input";
			this.password_input.Size = new System.Drawing.Size(252, 30);
			this.password_input.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 22);
			this.label4.TabIndex = 13;
			this.label4.Text = "Confirm Password:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// confirm_password_input
			// 
			this.confirm_password_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirm_password_input.Location = new System.Drawing.Point(10, 187);
			this.confirm_password_input.Name = "confirm_password_input";
			this.confirm_password_input.Size = new System.Drawing.Size(252, 30);
			this.confirm_password_input.TabIndex = 12;
			// 
			// details_textBox
			// 
			this.details_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.details_textBox.Location = new System.Drawing.Point(10, 245);
			this.details_textBox.Name = "details_textBox";
			this.details_textBox.Size = new System.Drawing.Size(250, 96);
			this.details_textBox.TabIndex = 14;
			this.details_textBox.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 22);
			this.label5.TabIndex = 15;
			this.label5.Text = "Details:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// register_button
			// 
			this.register_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_button.Location = new System.Drawing.Point(12, 360);
			this.register_button.Name = "register_button";
			this.register_button.Size = new System.Drawing.Size(252, 46);
			this.register_button.TabIndex = 16;
			this.register_button.Text = "Register";
			this.register_button.UseVisualStyleBackColor = true;
			this.register_button.Click += new System.EventHandler(this.Register_buttonClick);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 475);
			this.Controls.Add(this.register_button);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.details_textBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.confirm_password_input);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.password_input);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.username_input);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.return_button);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "RegisterForm";
			this.ShowIcon = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterFormFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
