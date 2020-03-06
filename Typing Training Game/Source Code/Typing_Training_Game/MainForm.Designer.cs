/*
 * Created by SharpDevelop.
 * User: Stefan
 * Date: 06/02/2019
 * Time: 09:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Typing_Training_Game
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label menuText;
		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.Button register_button;
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
			this.menuText = new System.Windows.Forms.Label();
			this.login_button = new System.Windows.Forms.Button();
			this.register_button = new System.Windows.Forms.Button();
			this.recovery_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// menuText
			// 
			this.menuText.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuText.Location = new System.Drawing.Point(12, 25);
			this.menuText.Name = "menuText";
			this.menuText.Size = new System.Drawing.Size(284, 78);
			this.menuText.TabIndex = 0;
			this.menuText.Text = "Typing Training Game";
			this.menuText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// login_button
			// 
			this.login_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_button.Location = new System.Drawing.Point(10, 142);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(286, 46);
			this.login_button.TabIndex = 1;
			this.login_button.Text = "Login";
			this.login_button.UseVisualStyleBackColor = true;
			this.login_button.Click += new System.EventHandler(this.Login_buttonClick);
			// 
			// register_button
			// 
			this.register_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_button.Location = new System.Drawing.Point(10, 194);
			this.register_button.Name = "register_button";
			this.register_button.Size = new System.Drawing.Size(286, 46);
			this.register_button.TabIndex = 2;
			this.register_button.Text = "Register";
			this.register_button.UseVisualStyleBackColor = true;
			this.register_button.Click += new System.EventHandler(this.Register_buttonClick);
			// 
			// recovery_button
			// 
			this.recovery_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.recovery_button.Location = new System.Drawing.Point(10, 246);
			this.recovery_button.Name = "recovery_button";
			this.recovery_button.Size = new System.Drawing.Size(286, 46);
			this.recovery_button.TabIndex = 3;
			this.recovery_button.Text = "Recovery";
			this.recovery_button.UseVisualStyleBackColor = true;
			this.recovery_button.Click += new System.EventHandler(this.Recovery_buttonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 341);
			this.Controls.Add(this.recovery_button);
			this.Controls.Add(this.register_button);
			this.Controls.Add(this.login_button);
			this.Controls.Add(this.menuText);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ResumeLayout(false);

		}
	}
}
