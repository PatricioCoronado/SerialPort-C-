/*
 * Created by SharpDevelop.
 * User: PC.5014885
 * Date: 17/02/2019
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Puerto_Serie
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cboPort;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.TextBox txtReceive;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnReceive;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.IO.Ports.SerialPort serialPort1;
		
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
			this.components = new System.ComponentModel.Container();
			this.cboPort = new System.Windows.Forms.ComboBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.txtReceive = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnReceive = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.SuspendLayout();
			// 
			// cboPort
			// 
			this.cboPort.FormattingEnabled = true;
			this.cboPort.Location = new System.Drawing.Point(69, 33);
			this.cboPort.Name = "cboPort";
			this.cboPort.Size = new System.Drawing.Size(121, 21);
			this.cboPort.TabIndex = 0;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(209, 33);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(299, 33);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(75, 79);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(298, 73);
			this.txtMessage.TabIndex = 3;
			// 
			// txtReceive
			// 
			this.txtReceive.Location = new System.Drawing.Point(76, 196);
			this.txtReceive.Multiline = true;
			this.txtReceive.Name = "txtReceive";
			this.txtReceive.Size = new System.Drawing.Size(298, 73);
			this.txtReceive.TabIndex = 4;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(298, 158);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 5;
			this.btnSend.Text = "send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.BtnSendClick);
			// 
			// btnReceive
			// 
			this.btnReceive.Location = new System.Drawing.Point(298, 275);
			this.btnReceive.Name = "btnReceive";
			this.btnReceive.Size = new System.Drawing.Size(75, 23);
			this.btnReceive.TabIndex = 6;
			this.btnReceive.Text = "receive";
			this.btnReceive.UseVisualStyleBackColor = true;
			this.btnReceive.Click += new System.EventHandler(this.BtnReceiveClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(26, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "port:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "send:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(26, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "receive:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 351);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnReceive);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtReceive);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.cboPort);
			this.Name = "MainForm";
			this.Text = "Puerto Serie";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
