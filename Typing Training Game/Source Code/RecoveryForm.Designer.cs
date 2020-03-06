/*
 * Created by SharpDevelop.
 * User: Stefan
 * Date: 06/02/2019
 * Time: 09:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Typing_Training_Game
{
	partial class RecoveryForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button return_button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox details_textBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox recovery_input;
		private System.Windows.Forms.Button login_page;
		private System.Windows.Forms.Button recovery_button;
		
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
			this.label5 = new System.Windows.Forms.Label();
			this.details_textBox = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.recovery_input = new System.Windows.Forms.TextBox();
			this.login_page = new System.Windows.Forms.Button();
			this.recovery_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// return_button
			// 
			this.return_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.return_button.Location = new System.Drawing.Point(10, 355);
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
			this.label3.Location = new System.Drawing.Point(10, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(252, 40);
			this.label3.TabIndex = 8;
			this.label3.Text = "Recovery";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 22);
			this.label5.TabIndex = 19;
			this.label5.Text = "Details:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// details_textBox
			// 
			this.details_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.details_textBox.Location = new System.Drawing.Point(8, 132);
			this.details_textBox.Name = "details_textBox";
			this.details_textBox.Size = new System.Drawing.Size(250, 96);
			this.details_textBox.TabIndex = 18;
			this.details_textBox.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(161, 22);
			this.label4.TabIndex = 17;
			this.label4.Text = "Recovery Code:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// recovery_input
			// 
			this.recovery_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.recovery_input.Location = new System.Drawing.Point(8, 74);
			this.recovery_input.Name = "recovery_input";
			this.recovery_input.Size = new System.Drawing.Size(252, 30);
			this.recovery_input.TabIndex = 16;
			// 
			// login_page
			// 
			this.login_page.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_page.Location = new System.Drawing.Point(10, 303);
			this.login_page.Name = "login_page";
			this.login_page.Size = new System.Drawing.Size(252, 46);
			this.login_page.TabIndex = 20;
			this.login_page.Text = "Go to Login Page";
			this.login_page.UseVisualStyleBackColor = true;
			this.login_page.Click += new System.EventHandler(this.Login_pageClick);
			// 
			// recovery_button
			// 
			this.recovery_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.recovery_button.Location = new System.Drawing.Point(10, 251);
			this.recovery_button.Name = "recovery_button";
			this.recovery_button.Size = new System.Drawing.Size(252, 46);
			this.recovery_button.TabIndex = 21;
			this.recovery_button.Text = "Recover Account";
			this.recovery_button.UseVisualStyleBackColor = true;
			this.recovery_button.Click += new System.EventHandler(this.Recovery_buttonClick);
			// 
			// RecoveryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 421);
			this.Controls.Add(this.recovery_button);
			this.Controls.Add(this.login_page);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.details_textBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.recovery_input);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.return_button);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "RecoveryForm";
			this.ShowIcon = false;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecoveryFormFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
