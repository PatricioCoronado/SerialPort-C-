/*
 * Created by SharpDevelop.
 * User: PC.5014885
 * Date: 18/02/2019
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq;


namespace PuertoSerie2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Objetos globales
		delegate void SeriealReceived();
		int contador;
		
		public MainForm()
		{
			contador =0;
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
				serialPort1.BaudRate=115200;
				serialPort1.DataBits=8;
				serialPort1.Parity=Parity.None;
				serialPort1.Open();
				serialPort1.Handshake=0;
				serialPort1.ReadTimeout=200;

				
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
			txtAviso.Text=contador.ToString();
			rB.Checked=false;
			try
			{
				if(serialPort1.IsOpen)
				{
					serialPort1.Write(txtMessage.Text+'\r');
					rB.Checked=true;
					//txtMessage.Clear();
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
		void SerialPort1DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			SeriealReceived callOnReceived = new SeriealReceived(notificationDataReceived);
            this.Invoke(callOnReceived);
		}
		private void notificationDataReceived()
        {
            txtReceive.Text=serialPort1.ReadExisting();
        }
	}//public partial class MainForm : Form
}//namespace Puerto_Serie
