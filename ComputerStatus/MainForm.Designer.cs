/*
 * Created by SharpDevelop.
 * User: alex.meyer
 * Date: 3/11/2013
 * Time: 8:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 using System;
 using System.Net;
 using System.Net.Sockets;
 using System.Windows.Forms;
 using System.Net.NetworkInformation;
 using System.Management;


 
namespace ComputerStatus
{
	partial class MainForm
	{
		 int physRAM = 0;
         int freeRAM = 0;
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(385, 209);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.textBox8);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.textBox7);
			this.tabPage1.Controls.Add(this.textBox6);
			this.tabPage1.Controls.Add(this.progressBar2);
			this.tabPage1.Controls.Add(this.progressBar1);
			this.tabPage1.Controls.Add(this.textBox5);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(377, 183);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Local Computer";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(118, 154);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(98, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "Percentage Used:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(118, 97);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 23);
			this.label9.TabIndex = 10;
			this.label9.Text = "In Use / Total:";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(118, 41);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(220, 20);
			this.textBox8.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(22, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Current User:";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(215, 151);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(123, 20);
			this.textBox7.TabIndex = 7;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(195, 97);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(143, 20);
			this.textBox6.TabIndex = 6;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(118, 124);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(220, 23);
			this.progressBar2.TabIndex = 5;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(118, 67);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(220, 23);
			this.progressBar1.TabIndex = 4;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(118, 12);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(220, 20);
			this.textBox5.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(22, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "CPU Usage:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(22, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "RAM Usage:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(22, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Computer Name:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.textBox4);
			this.tabPage2.Controls.Add(this.textBox3);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(377, 183);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Network";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(219, 154);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Network Test";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(117, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Refresh";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(117, 117);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(228, 20);
			this.textBox4.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(117, 81);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(228, 20);
			this.textBox3.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(117, 52);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(228, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(117, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(228, 20);
			this.textBox1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Current Interface:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Primary DNS:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "MAC Address:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP Address:";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.WorkerReportsProgress = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 231);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "ComputerStatus";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			
			setLocal();
			setNetwork();
		}
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		
		//Refresh Button
		void Button1Click(object sender, System.EventArgs e)
		{
			setNetwork();
		}
		
		void setNetwork(){
			textBox1.Text = getCurrentInterface();
			textBox2.Text = getIP();
			textBox3.Text = getMAC();
			textBox4.Text = getDNS();
		}
		
		void setLocal(){
			textBox5.Text = getComputerName();
			textBox8.Text = getCurrentUser();
			getTotalRAM();
		}
		
		void getTotalRAM(){
			ObjectQuery winQuery = new ObjectQuery("SELECT * FROM CIM_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);
            ManagementObjectCollection collect = searcher.Get();
              foreach (ManagementObject item in collect)
            {
                physRAM = Convert.ToInt32(item["TotalVisibleMemorySize"]);
               
            }
            physRAM /= 1024;
		}
		
		int getFreeRAM(){
			ObjectQuery winQuery = new ObjectQuery("SELECT * FROM CIM_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);
            ManagementObjectCollection collect = searcher.Get();
              foreach (ManagementObject item in collect)
            {
                freeRAM = Convert.ToInt32(item["FreePhysicalMemory"]);
            }
            freeRAM /= 1024;
            double used = physRAM-freeRAM;
			double all = physRAM;
			double dub = (used/all)*100;
			int ratio = (int)dub;
            string ramString = (physRAM-freeRAM)+@" MB / "+physRAM+" MB -> "+ratio+"%";
            textBox6.Text = ramString;
            getCPUUsage();
            return ratio;
		}
		
		
		string getCurrentUser(){
			string full = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
			string[] split = full.Split('\\');
			return split[1];
		}
		
		string getComputerName(){
			return System.Windows.Forms.SystemInformation.ComputerName;
		}
		
		string getCurrentInterface(){
			string internet = "";
			NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface nic in interfaces){
				if(nic.OperationalStatus == OperationalStatus.Up){
					internet = nic.Name;
					break;
				}
			}
			return internet;
		}
		
		string getIP(){
			IPHostEntry host;
			string ip = "";
			host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress addr in host.AddressList){
				if(addr.AddressFamily == AddressFamily.InterNetwork){
					ip = addr.ToString();
					break;
					}
				}
			return ip;
		}
		
		string getMAC(){
			string mac = "";
			NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface nic in interfaces){
				if(nic.OperationalStatus == OperationalStatus.Up){
					mac = nic.GetPhysicalAddress().ToString();
					break;
				}
			}
			string sepMAC = "";
			for(int i = 0; i < 12; i++){
				sepMAC = sepMAC+mac[i];
				if(i%2==1 && i != 11)
					sepMAC = sepMAC+":";
			}
			return sepMAC;
		}
		
		string getDNS(){
			NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
			string dnsServers = "";
			IPInterfaceProperties ipProps = null;
			foreach (NetworkInterface nic in interfaces){
				if(nic.OperationalStatus == OperationalStatus.Up){
					ipProps = nic.GetIPProperties();
					break;
					}
			}
				IPAddressCollection dnsAddr = ipProps.DnsAddresses;
				int numDNS = dnsAddr.Count;
				int i = 0;
				while(i < numDNS-1){
					IPAddress addr = dnsAddr[i];
					dnsServers = dnsServers+addr.ToString()+", ";
					i++;
				}
				dnsServers = dnsServers+dnsAddr[i].ToString();
			return dnsServers;
		}
		
		//Network test
		void Button2Click(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			PingReply reply = ping.Send("www.google.com");
			if(reply.Status == IPStatus.Success){
				MessageBox.Show("Ping response received\nInternet is Working!");
			}
			else{
				MessageBox.Show("No ping response...,\nNo Network Connectivity!");
			}
		}
	}
}
