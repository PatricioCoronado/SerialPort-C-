/*
 * Created by SharpDevelop.
 * User: PC.5014885
 * Date: 17/02/2019
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace Puerto_Serie
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			string[] ports=SerialPort.GetPortNames();
			cboPort.Items.AddRange(ports);
			cboPort.SelectedIndex=0;
			btnClose.Enabled=false;
			
		}
		void BtnOpenClick(object sender, EventArgs e)
		{
			btnOpen.Enabled=false;
			btnClose.Enabled=true;
			try
			{
				serialPort1.PortName=cboPort.Text;
				serialPort1.Open();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			btnOpen.Enabled=true;
			btnClose.Enabled=false;
			try
			{
				serialPort1.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		void BtnSendClick(object sender, EventArgs e)
		{
			try
			{
				if(serialPort1.IsOpen)
				{
					serialPort1.Write(txtMessage.Text+"\r");
					txtMessage.Clear();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		void BtnReceiveClick(object sender, EventArgs e)
		{
			try
			{
				if(serialPort1.IsOpen)
				{
					txtReceive.Text=serialPort1.ReadExisting();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(serialPort1.IsOpen)
			{
				serialPort1.Close();
			}
		}
		
	}//public partial class MainForm : Form
}//namespace Puerto_Serie
