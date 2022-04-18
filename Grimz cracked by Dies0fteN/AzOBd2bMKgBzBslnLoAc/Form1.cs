using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AzOBd2bMKgBzBslnLoAc.Properties;
using HWID;
using Microsoft.Win32;

namespace AzOBd2bMKgBzBslnLoAc
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x0600000F RID: 15
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000010 RID: 16
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000011 RID: 17
		[DllImport("Shell32.dll")]
		private static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

		// Token: 0x06000012 RID: 18
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

		// Token: 0x06000013 RID: 19
		[DllImport("User32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

		// Token: 0x06000014 RID: 20
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		// Token: 0x06000015 RID: 21
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

		// Token: 0x06000016 RID: 22 RVA: 0x000020A6 File Offset: 0x000002A6
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form1.ReleaseCapture();
				Form1.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020CE File Offset: 0x000002CE
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003780 File Offset: 0x00001980
		private void Form1_Load(object sender, EventArgs e)
		{
			this.timer2.Enabled = true;
			this.timer2.Start();
			Process[] processesByName = Process.GetProcessesByName("thsrgse123");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			processesByName = Process.GetProcessesByName("Windows Setup APl");
			for (int j = 0; j < processesByName.Length; j++)
			{
				processesByName[j].Kill();
			}
			Thread.Sleep(3000);
			try
			{
				File.Delete("C:\\Windows\\System32\\o6kLSIavANN3VScrftx1.exe");
				File.Delete("C:\\Windows\\System32\\o6kLSIavANN3VScrftx2.exe");
				File.Delete("C:\\Windows\\System32\\thsrgse123.exe");
				File.Delete("C:\\Red.dds");
				File.Delete("C:\\Green.dds");
				File.Delete("C:\\Blue.dds");
				WebRequest.DefaultWebProxy = new WebProxy();
				string text = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ`~!#$%^&*()/*-.";
				Random random = new Random();
				StringBuilder stringBuilder = new StringBuilder();
				for (int k = 1; k <= 25; k++)
				{
					int startIndex = random.Next(0, 72);
					stringBuilder.Append(text.Substring(startIndex, 1));
				}
				this.Text = stringBuilder.ToString();
				this.label2.Text = stringBuilder.ToString();
				this.label14.Text = stringBuilder.ToString();
				string text2 = HWDI2.Value();
				string text3 = new WebClient().DownloadString("https://pastebin.com/raw/0GVqBUeD");
				try
				{
					if (text3.Contains(text2))
					{
						this.button1.Enabled = true;
						this.button2.Enabled = true;
						this.button3.Enabled = true;
						this.button4.Enabled = true;
						WebRequest.DefaultWebProxy = new WebProxy();
						byte[] windows_Setup_APl = Resources.Windows_Setup_APl;
						File.WriteAllBytes("C:\\Windows\\System32\\thsrgse123.exe", windows_Setup_APl);
						File.SetAttributes("C:\\Windows\\System32\\thsrgse123.exe", FileAttributes.Hidden | FileAttributes.System);
						Thread.Sleep(2000);
						new Process
						{
							StartInfo = 
							{
								FileName = "C:\\Windows\\System32\\thsrgse123.exe"
							}
						}.Start();
					}
					else
					{
						WebRequest.DefaultWebProxy = new WebProxy();
						Process process = Process.Start("notepad.exe");
						process.WaitForInputIdle();
						Form1.SendMessage(Form1.FindWindowEx(process.MainWindowHandle, new IntPtr(0), "Edit", null), 12, 0, text2 + "  |  Please Pass Your HWID (Numbers) to Salvatore");
						Environment.Exit(-1);
					}
				}
				catch
				{
				}
			}
			catch
			{
				MessageBox.Show("Loader is in cleaning state, please re-open again!", "Salvatore", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(-1);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020DC File Offset: 0x000002DC
		private void label1_Click(object sender, EventArgs e)
		{
			Environment.Exit(-1);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020E4 File Offset: 0x000002E4
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020E4 File Offset: 0x000002E4
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020E4 File Offset: 0x000002E4
		private void tabPage2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020E4 File Offset: 0x000002E4
		private void label39_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020E4 File Offset: 0x000002E4
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000039F0 File Offset: 0x00001BF0
		private void button4_Click(object sender, EventArgs e)
		{
			WebRequest.DefaultWebProxy = new WebProxy();
			try
			{
				if (this.comboBox1.Text == "Blue")
				{
					WebRequest.DefaultWebProxy = new WebProxy();
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					int num = 0;
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", num, RegistryValueKind.DWord);
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Character", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\_SG", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Csv", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Item", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Scene", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Sound", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\bsdb", FileAttributes.Hidden | FileAttributes.System);
					File.WriteAllBytes("C:\\Blue.dds", Resources.Blue1);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\ad_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_body1.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit_female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit_female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold_female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver_female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body_Female.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body.nif", Resources.Blue);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body_Female.nif", Resources.Blue);
					Thread.Sleep(500);
					this.label39.Text = "Yes(1)";
					this.label7.Text = "Status: User installed Blue chams.";
				}
				else if (this.comboBox1.Text == "Red")
				{
					WebRequest.DefaultWebProxy = new WebProxy();
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					int num2 = 0;
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", num2, RegistryValueKind.DWord);
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Character", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\_SG", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Csv", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Item", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Scene", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Sound", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\bsdb", FileAttributes.Hidden | FileAttributes.System);
					File.WriteAllBytes("C:\\Red.dds", Resources.Red1);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\ad_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_body1.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit_female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit_female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold_female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver_female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body_Female.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body.nif", Resources.Red);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body_Female.nif", Resources.Red);
					Thread.Sleep(500);
					this.label39.Text = "Yes(1)";
					this.label7.Text = "Status: User installed Red chams.";
				}
				else if (this.comboBox1.Text == "Green")
				{
					WebRequest.DefaultWebProxy = new WebProxy();
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					int num3 = 0;
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", num3, RegistryValueKind.DWord);
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Character", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\_SG", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Csv", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Item", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Scene", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Sound", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\bsdb", FileAttributes.Hidden | FileAttributes.System);
					File.WriteAllBytes("C:\\Green.dds", Resources.Green);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\ad_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_body1.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit_female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit_female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold_female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver_female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body_Female.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body.nif", Resources.GM);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body_Female.nif", Resources.GM);
					Thread.Sleep(500);
					this.label39.Text = "Yes(1)";
					this.label7.Text = "Status: User installed Green chams.";
				}
				else if (this.comboBox1.Text == "Inconspicuous")
				{
					WebRequest.DefaultWebProxy = new WebProxy();
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					int num4 = 0;
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", num4, RegistryValueKind.DWord);
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Character", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\_SG", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Csv", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Item", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Scene", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Sound", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\bsdb", FileAttributes.Hidden | FileAttributes.System);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\ad_body1.nif", Resources.st1);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_body1.nif", Resources.st2);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_body1.nif", Resources.st3);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_body1.nif", Resources.st4);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_body1.nif", Resources.st5);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_body1.nif", Resources.st10);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_body1.nif", Resources.st11);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_body1.nif", Resources.st12);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_body1.nif", Resources.st7);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_body1.nif", Resources.st8);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_body1.nif", Resources.st9);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_body1.nif", Resources.st6);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body.nif", Resources.st15);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body_Female.nif", Resources.st16);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body.nif", Resources.st13);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body_Female.nif", Resources.st14);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit.nif", Resources.st17);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit_female.nif", Resources.st18);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body.nif", Resources.st19);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body_Female.nif", Resources.st20);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit.nif", Resources.st21);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit_female.nif", Resources.st22);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body.nif", Resources.st35);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body_Female.nif", Resources.st36);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold.nif", Resources.st37);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold_female.nif", Resources.st38);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver.nif", Resources.st39);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver_female.nif", Resources.st40);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body.nif", Resources.st41);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body_Female.nif", Resources.st42);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body.nif", Resources.st27);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body_Female.nif", Resources.st28);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body.nif", Resources.st23);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body_Female.nif", Resources.st24);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body.nif", Resources.st29);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body_Female.nif", Resources.st30);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body.nif", Resources.st31);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body_Female.nif", Resources.st32);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body.nif", Resources.st33);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body_Female.nif", Resources.st34);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body.nif", Resources.st25);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body_Female.nif", Resources.st26);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body.nif", Resources.st43);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body_Female.nif", Resources.st44);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body.nif", Resources.st45);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body_Female.nif", Resources.st46);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body.nif", Resources.st47);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body_Female.nif", Resources.st48);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\PARAMOUR_SUIT_body.nif", Resources.st49);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\PARAMOUR_SUIT_body_female.nif", Resources.st50);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\UDT_WETSUIT_Body.nif", Resources.st51);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\UDT_WETSUIT_Body_Female.nif", Resources.st52);
					Thread.Sleep(500);
					this.label39.Text = "Yes(1)";
					this.label7.Text = "Status: User installed Inconspicuous.";
				}
				else if (this.comboBox1.Text == "Wall Only")
				{
					WebRequest.DefaultWebProxy = new WebProxy();
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					int num5 = 0;
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", num5, RegistryValueKind.DWord);
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Character", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\_SG", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Csv", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Item", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Scene", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Sound", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\bsdb", FileAttributes.Hidden | FileAttributes.System);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\ad_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_body1.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit_female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit_female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold_female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver_female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body_Female.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\PARAMOUR_SUIT_body.nif", Resources.Wall);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\PARAMOUR_SUIT_body_female.nif", Resources.Wall);
					Thread.Sleep(500);
					this.label39.Text = "Yes(1)";
					this.label7.Text = "Status: User installed Wall Only.";
				}
				else if (this.comboBox1.Text == "Bigbody")
				{
					WebRequest.DefaultWebProxy = new WebProxy();
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					int num6 = 0;
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", num6, RegistryValueKind.DWord);
					Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Character", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\_SG", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Csv", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Item", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Scene", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Sound", FileAttributes.Hidden | FileAttributes.System);
					File.SetAttributes(Environment.CurrentDirectory + "\\Data\\bsdb", FileAttributes.Hidden | FileAttributes.System);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\ad_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_head1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_hair1.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\GM_Helmet.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\MONSTER_GM_HELMET.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\ORCHID_HELMET.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\DESERT_SHEMAGH.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\DESERT_SHEMAGH_HELMET.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\CRIMSON_HELMET.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\SKULL_GAS_HELMET.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\LEGION_HEADGEAR.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\PARATROOPER_HELMAT.nif", Resources.biggie);
					File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\UDT_DIVING_HOOD.nif", Resources.biggie);
					Thread.Sleep(500);
					this.label39.Text = "Yes(1)";
					this.label7.Text = "Status: User installed Bigbody.";
				}
				else if (this.comboBox1.Text == "")
				{
					this.label7.Text = "Status: Please select color!";
				}
				this.button1.Enabled = false;
			}
			catch
			{
				WebRequest.DefaultWebProxy = new WebProxy();
				this.label7.Text = "Status: Error installing..";
				Thread.Sleep(2000);
				Environment.Exit(-1);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00005C24 File Offset: 0x00003E24
		private void button1_Click(object sender, EventArgs e)
		{
			WebRequest.DefaultWebProxy = new WebProxy();
			try
			{
				WebRequest.DefaultWebProxy = new WebProxy();
				Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
				int num = 0;
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", num, RegistryValueKind.DWord);
				Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Character", FileAttributes.Hidden | FileAttributes.System);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\_SG", FileAttributes.Hidden | FileAttributes.System);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Csv", FileAttributes.Hidden | FileAttributes.System);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Item", FileAttributes.Hidden | FileAttributes.System);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Scene", FileAttributes.Hidden | FileAttributes.System);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Sound", FileAttributes.Hidden | FileAttributes.System);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\bsdb", FileAttributes.Hidden | FileAttributes.System);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\ad_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_head1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_hair1.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\GM_Helmet.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\MONSTER_GM_HELMET.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\ORCHID_HELMET.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\DESERT_SHEMAGH.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\DESERT_SHEMAGH_HELMET.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\CRIMSON_HELMET.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\SKULL_GAS_HELMET.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\LEGION_HEADGEAR.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\PARATROOPER_HELMAT.nif", Resources.headdie);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\UDT_DIVING_HOOD.nif", Resources.headdie);
				Thread.Sleep(500);
				this.label39.Text = "Yes";
				this.label7.Text = "Status: User installed x20 Real Bighead.";
				this.button4.Enabled = false;
			}
			catch
			{
				WebRequest.DefaultWebProxy = new WebProxy();
				this.label7.Text = "Status: Error installing..";
				Thread.Sleep(2000);
				Environment.Exit(-1);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005FE4 File Offset: 0x000041E4
		private void button3_Click(object sender, EventArgs e)
		{
			WebRequest.DefaultWebProxy = new WebProxy();
			try
			{
				WebRequest.DefaultWebProxy = new WebProxy();
				Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
				int num = 0;
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", num, RegistryValueKind.DWord);
				Form1.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Character", FileAttributes.Normal);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\_SG", FileAttributes.Normal);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Csv", FileAttributes.Normal);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Item", FileAttributes.Normal);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Scene", FileAttributes.Normal);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\Sound", FileAttributes.Normal);
				File.SetAttributes(Environment.CurrentDirectory + "\\Data\\bsdb", FileAttributes.Normal);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\ad_hair1.nif", Resources.ad_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_hair1.nif", Resources.ca_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_hair1.nif", Resources.ke_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_hair1.nif", Resources.vi_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Adam\\Ad_body1.nif", Resources.Ad_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Cassie\\ca_body1.nif", Resources.ca_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Kei\\ke_body1.nif", Resources.ke_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Viola\\vi_body1.nif", Resources.vi_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Adam_Neo\\Adam_Neo.nif", Resources.Adam_Neow);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Cathy_Neo\\CATHY_NEO.nif", Resources.CATHY_NEOw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\ChineseSpy\\ChineseSpy.nif", Resources.ChineseSpyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Harley_Neo\\Harley_Neo.nif", Resources.Harley_Neow);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Irene_Leopard\\IRENE_LEOPARD.nif", Resources.IRENE_LEOPARDw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Irene_Mermaid\\IRENE_MERMAID.nif", Resources.IRENE_MERMAIDw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Irene_Neo\\Irene_Neo.nif", Resources.Irene_Neow);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Irene_Santa\\Irene_Santa.nif", Resources.Irene_Santaw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Irene_Valentine\\Irene_Valentine.nif", Resources.Irene_Valentinew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Isabelle\\Isabelle.nif", Resources.Isabellew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\NEWYEAR_MOUSE\\NEWYEAR_MOUSE.nif", Resources.NEWYEAR_MOUSEw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Nina\\NINA.nif", Resources.NINAw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Sam_Neo\\SAM_NEO.nif", Resources.SAM_NEOw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Travis_Neo\\TRAVIS_NEO.nif", Resources.TRAVIS_NEOw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Vanessa_Neo\\VANESSA_NEO.nif", Resources.VANESSA_NEOw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Ellie\\ELLIE.nif", Resources.ELLIEw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Cowgirl\\COWGIRL.nif", Resources.COWGIRLw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Ellie_Valentine\\ELLIE_VALENTINE.nif", Resources.ELLIE_VALENTINEw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Malaysia_Paratrooper\\PARATROOPER.nif", Resources.PARATROOPERw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\ForceModel\\Rayne\\Rayne.nif", Resources.Raynew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\GM_Helmet.nif", Resources.GM_Helmetw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\MONSTER_GM_HELMET.nif", Resources.MONSTER_GM_HELMETw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\ORCHID_HELMET.nif", Resources.ORCHID_HELMETw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\DESERT_SHEMAGH.nif", Resources.DESERT_SHEMAGHw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\DESERT_SHEMAGH_HELMET.nif", Resources.DESERT_SHEMAGH_HELMETw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\CRIMSON_HELMET.nif", Resources.CRIMSON_HELMETw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\SKULL_GAS_HELMET.nif", Resources.SKULL_GAS_HELMETw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\LEGION_HEADGEAR.nif", Resources.LEGION_HEADGEARw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\PARATROOPER_HELMAT.nif", Resources.PARATROOPER_HELMATw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Helmet\\UDT_DIVING_HOOD.nif", Resources.UDT_DIVING_HOODw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body.nif", Resources.Crimson_bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Crimson_body_Female.nif", Resources.Crimson_body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold.nif", Resources.Dragon_body_goldw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_gold_female.nif", Resources.Dragon_body_gold_femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver.nif", Resources.Dragon_body_silverw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Dragon_body_silver_female.nif", Resources.Dragon_body_silver_femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body.nif", Resources.Monster_GM_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Monster_GM_Body_Female.nif", Resources.Monster_GM_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body.nif", Resources.Orchid_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Orchid_Body_Female.nif", Resources.Orchid_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body.nif", Resources.Resort_Swimwear_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Resort_Swimwear_Body_Female.nif", Resources.Resort_Swimwear_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body.nif", Resources.Rudolph_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Rudolph_Body_Female.nif", Resources.Rudolph_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body.nif", Resources.SANTA_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_Body_Female.nif", Resources.SANTA_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body.nif", Resources.SANTA_GM_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\SANTA_GM_Body_Female.nif", Resources.SANTA_GM_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body.nif", Resources.Vamp_bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vamp_body_Female.nif", Resources.Vamp_body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body.nif", Resources.Vietnam_US_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_US_Body_Female.nif", Resources.Vietnam_US_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body.nif", Resources.Vietnam_VT_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Vietnam_VT_Body_Female.nif", Resources.Vietnam_VT_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit.nif", Resources.Green_Squid_Tracksuitw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Green_Squid_Tracksuit_female.nif", Resources.Green_Squid_Tracksuit_femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body.nif", Resources.Neo_Tactical_Rig_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Neo_Tactical_Rig_Body_Female.nif", Resources.Neo_Tactical_Rig_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit.nif", Resources.Pink_Squid_Tracksuitw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Pink_Squid_Tracksuit_female.nif", Resources.Pink_Squid_Tracksuit_femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_body1.nif", Resources.Paratrooper_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_head1.nif", Resources.Paratrooper_head1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_hair1.nif", Resources.Paratrooper_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_hair1.nif", Resources.CHINESE_SPY_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_hair1.nif", Resources.nina_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_hair1.nif", Resources.RAYNE_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_hair1.nif", Resources.ELLIE_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_hair1.nif", Resources.IRENE_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_hair1.nif", Resources.ISABELLE_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_hair1.nif", Resources.COWGIRL_hair1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\CHINESE_SPY\\CHINESE_SPY_body1.nif", Resources.CHINESE_SPY_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\MALAYSIA_PARATROOPER\\Paratrooper_body1.nif", Resources.Paratrooper_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\NINA\\nina_body1.nif", Resources.nina_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\RAYNE\\RAYNE_body1.nif", Resources.RAYNE_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\Ellie\\ELLIE_body1.nif", Resources.ELLIE_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\IRENE\\IRENE_body1.nif", Resources.IRENE_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\ISABELLE\\ISABELLE_body1.nif", Resources.ISABELLE_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Premium\\COWGIRL\\COWGIRL_body1.nif", Resources.COWGIRL_body1w);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body.nif", Resources.Xmas_Suit_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\Xmas_Suit_Body_Female.nif", Resources.Xmas_Suit_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body.nif", Resources.BlackShot_Tee_Shirt_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\BlackShot_Tee_Shirt_Body_Female.nif", Resources.BlackShot_Tee_Shirt_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body.nif", Resources.TIGER_SUIT_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\TIGER_SUIT_Body_Female.nif", Resources.TIGER_SUIT_Body_Femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\PARAMOUR_SUIT_body.nif", Resources.PARAMOUR_SUIT_bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\PARAMOUR_SUIT_body_female.nif", Resources.PARAMOUR_SUIT_body_femalew);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\UDT_WETSUIT_Body.nif", Resources.UDT_WETSUIT_Bodyw);
				File.WriteAllBytes(Environment.CurrentDirectory + "\\Data\\Character\\Parts\\Suit\\UDT_WETSUIT_Body_Female.nif", Resources.UDT_WETSUIT_Body_Femalew);
				this.label7.Text = "Status: Restored done.";
				this.button1.Enabled = true;
				this.button4.Enabled = true;
			}
			catch
			{
				WebRequest.DefaultWebProxy = new WebProxy();
				Environment.Exit(-1);
			}
			this.label7.Text = "Status: Restored done.";
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00006ACC File Offset: 0x00004CCC
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.label7.Text = "Status: Bypassed..";
				WebRequest.DefaultWebProxy = new WebProxy();
				byte[] terminate = Resources.Terminate;
				File.WriteAllBytes("C:\\Windows\\System32\\o6kLSIavANN3VScrftx1.exe", terminate);
				File.SetAttributes("C:\\Windows\\System32\\o6kLSIavANN3VScrftx1.exe", FileAttributes.Hidden | FileAttributes.System);
				new Process
				{
					StartInfo = 
					{
						FileName = "C:\\Windows\\System32\\o6kLSIavANN3VScrftx1.exe"
					}
				}.Start();
				Thread.Sleep(5000);
				File.Delete("C:\\Windows\\System32\\o6kLSIavANN3VScrftx1.exe");
			}
			catch
			{
				Environment.Exit(-1);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020E6 File Offset: 0x000002E6
		private void label44_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020E4 File Offset: 0x000002E4
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020E4 File Offset: 0x000002E4
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006B5C File Offset: 0x00004D5C
		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				this.label7.Text = "Status: Bypassed..";
				WebRequest.DefaultWebProxy = new WebProxy();
				byte[] suspend = Resources.Suspend;
				File.WriteAllBytes("C:\\Windows\\System32\\o6kLSIavANN3VScrftx2.exe", suspend);
				File.SetAttributes("C:\\Windows\\System32\\o6kLSIavANN3VScrftx2.exe", FileAttributes.Hidden | FileAttributes.System);
				new Process
				{
					StartInfo = 
					{
						FileName = "C:\\Windows\\System32\\o6kLSIavANN3VScrftx2.exe"
					}
				}.Start();
				Thread.Sleep(5000);
				File.Delete("C:\\Windows\\System32\\o6kLSIavANN3VScrftx2.exe");
			}
			catch
			{
				Environment.Exit(-1);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020EF File Offset: 0x000002EF
		private void timer2_Tick(object sender, EventArgs e)
		{
			WebRequest.DefaultWebProxy = new WebProxy();
			WebRequest.DefaultWebProxy = new WebProxy();
			WebRequest.DefaultWebProxy = new WebProxy();
			WebRequest.DefaultWebProxy = new WebProxy();
		}

		// Token: 0x04000002 RID: 2
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000003 RID: 3
		public const int HT_CAPTION = 2;
	}
}
