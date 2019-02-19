/*
 * Created by SharpDevelop.
 * User: PC.5014885
 * Date: 18/02/2019
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuertoSerie2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReceive;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtReceive;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.ComboBox cboPort;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.TextBox txtAviso;
		private System.Windows.Forms.TextBox textAviso2;
		private System.Windows.Forms.RadioButton rB;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReceive = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtReceive = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.cboPort = new System.Windows.Forms.ComboBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.txtAviso = new System.Windows.Forms.TextBox();
			this.textAviso2 = new System.Windows.Forms.TextBox();
			this.rB = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(30, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "receive:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "send:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "port:";
			// 
			// btnReceive
			// 
			this.btnReceive.Location = new System.Drawing.Point(302, 268);
			this.btnReceive.Name = "btnReceive";
			this.btnReceive.Size = new System.Drawing.Size(75, 23);
			this.btnReceive.TabIndex = 16;
			this.btnReceive.Text = "receive";
			this.btnReceive.UseVisualStyleBackColor = true;
			this.btnReceive.Click += new System.EventHandler(this.BtnReceiveClick);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(302, 151);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 15;
			this.btnSend.Text = "send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.BtnSendClick);
			// 
			// txtReceive
			// 
			this.txtReceive.Location = new System.Drawing.Point(80, 189);
			this.txtReceive.Multiline = true;
			this.txtReceive.Name = "txtReceive";
			this.txtReceive.Size = new System.Drawing.Size(298, 73);
			this.txtReceive.TabIndex = 14;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(79, 72);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(298, 73);
			this.txtMessage.TabIndex = 13;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(303, 26);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(213, 26);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 11;
			this.btnOpen.Text = "open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// cboPort
			// 
			this.cboPort.FormattingEnabled = true;
			this.cboPort.Location = new System.Drawing.Point(73, 26);
			this.cboPort.Name = "cboPort";
			this.cboPort.Size = new System.Drawing.Size(121, 21);
			this.cboPort.TabIndex = 10;
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// txtAviso
			// 
			this.txtAviso.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtAviso.Location = new System.Drawing.Point(73, 301);
			this.txtAviso.Name = "txtAviso";
			this.txtAviso.Size = new System.Drawing.Size(136, 20);
			this.txtAviso.TabIndex = 20;
			// 
			// textAviso2
			// 
			this.textAviso2.Location = new System.Drawing.Point(231, 301);
			this.textAviso2.Name = "textAviso2";
			this.textAviso2.Size = new System.Drawing.Size(136, 20);
			this.textAviso2.TabIndex = 21;
			// 
			// rB
			// 
			this.rB.Location = new System.Drawing.Point(117, 159);
			this.rB.Name = "rB";
			this.rB.Size = new System.Drawing.Size(104, 24);
			this.rB.TabIndex = 22;
			this.rB.TabStop = true;
			this.rB.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 333);
			this.Controls.Add(this.rB);
			this.Controls.Add(this.textAviso2);
			this.Controls.Add(this.txtAviso);
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
			this.Text = "PuertoSerie2";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
