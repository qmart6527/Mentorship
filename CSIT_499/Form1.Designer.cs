
namespace CSIT_499
{
     partial class Form1
     {
          /// <summary>
          ///  Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          ///  Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.menu = new System.Windows.Forms.TabControl();
               this.Home = new System.Windows.Forms.TabPage();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.hlpBtn = new System.Windows.Forms.Button();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.Mentor = new System.Windows.Forms.TabPage();
               this.MntrMjrTxtBx = new System.Windows.Forms.TextBox();
               this.MntrMjrLbl = new System.Windows.Forms.Label();
               this.mntrFstNmTxtBx = new System.Windows.Forms.TextBox();
               this.mntrFstNm = new System.Windows.Forms.Label();
               this.mntrLbl = new System.Windows.Forms.Label();
               this.mntrCmbBx = new System.Windows.Forms.ComboBox();
               this.hlpBtn2 = new System.Windows.Forms.Button();
               this.Mentee = new System.Windows.Forms.TabPage();
               this.mnteMjrTxtBx = new System.Windows.Forms.TextBox();
               this.mnteMjrLbl = new System.Windows.Forms.Label();
               this.mnteNmTxtBx = new System.Windows.Forms.TextBox();
               this.mnteNmLbl = new System.Windows.Forms.Label();
               this.mnteLbl = new System.Windows.Forms.Label();
               this.mnteCmbBx = new System.Windows.Forms.ComboBox();
               this.hlpBtn3 = new System.Windows.Forms.Button();
               this.Activity = new System.Windows.Forms.TabPage();
               this.mnteLstBxNm = new System.Windows.Forms.ListBox();
               this.mntrLstBxNm = new System.Windows.Forms.ListBox();
               this.hrsSpnt = new System.Windows.Forms.Label();
               this.dscrbActvt = new System.Windows.Forms.Label();
               this.mnteSlct = new System.Windows.Forms.Label();
               this.mtnrSlct = new System.Windows.Forms.Label();
               this.sbmtBtn = new System.Windows.Forms.Button();
               this.hrLstBx = new System.Windows.Forms.ListBox();
               this.actvtTxtBx = new System.Windows.Forms.TextBox();
               this.hlpBtn4 = new System.Windows.Forms.Button();
               this.Reports = new System.Windows.Forms.TabPage();
               this.rptLstBx = new System.Windows.Forms.ListBox();
               this.hlpBtn5 = new System.Windows.Forms.Button();
               this.mnteMjrCntBtn = new System.Windows.Forms.Button();
               this.actvtCntBtn = new System.Windows.Forms.Button();
               this.menu.SuspendLayout();
               this.Home.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.Mentor.SuspendLayout();
               this.Mentee.SuspendLayout();
               this.Activity.SuspendLayout();
               this.Reports.SuspendLayout();
               this.SuspendLayout();
               // 
               // menu
               // 
               this.menu.Controls.Add(this.Home);
               this.menu.Controls.Add(this.Mentor);
               this.menu.Controls.Add(this.Mentee);
               this.menu.Controls.Add(this.Activity);
               this.menu.Controls.Add(this.Reports);
               this.menu.ItemSize = new System.Drawing.Size(159, 30);
               this.menu.Location = new System.Drawing.Point(0, 0);
               this.menu.Name = "menu";
               this.menu.SelectedIndex = 0;
               this.menu.Size = new System.Drawing.Size(800, 450);
               this.menu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
               this.menu.TabIndex = 0;
               // 
               // Home
               // 
               this.Home.BackColor = System.Drawing.Color.DarkGray;
               this.Home.Controls.Add(this.pictureBox1);
               this.Home.Controls.Add(this.hlpBtn);
               this.Home.Controls.Add(this.textBox1);
               this.Home.Location = new System.Drawing.Point(4, 34);
               this.Home.Name = "Home";
               this.Home.Padding = new System.Windows.Forms.Padding(3);
               this.Home.Size = new System.Drawing.Size(792, 412);
               this.Home.TabIndex = 0;
               this.Home.Text = "Home";
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::CSIT_499.Properties.Resources.th;
               this.pictureBox1.Location = new System.Drawing.Point(142, 183);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(473, 221);
               this.pictureBox1.TabIndex = 2;
               this.pictureBox1.TabStop = false;
               // 
               // hlpBtn
               // 
               this.hlpBtn.Location = new System.Drawing.Point(690, 375);
               this.hlpBtn.Name = "hlpBtn";
               this.hlpBtn.Size = new System.Drawing.Size(94, 29);
               this.hlpBtn.TabIndex = 1;
               this.hlpBtn.Text = "Help";
               this.hlpBtn.UseVisualStyleBackColor = true;
               this.hlpBtn.Click += new System.EventHandler(this.hlpBtn_Click);
               // 
               // textBox1
               // 
               this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
               this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.textBox1.Location = new System.Drawing.Point(102, 15);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(558, 201);
               this.textBox1.TabIndex = 0;
               this.textBox1.Text = "Fredonia Mentor/Mentee Application";
               this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // Mentor
               // 
               this.Mentor.BackColor = System.Drawing.Color.DarkGray;
               this.Mentor.Controls.Add(this.MntrMjrTxtBx);
               this.Mentor.Controls.Add(this.MntrMjrLbl);
               this.Mentor.Controls.Add(this.mntrFstNmTxtBx);
               this.Mentor.Controls.Add(this.mntrFstNm);
               this.Mentor.Controls.Add(this.mntrLbl);
               this.Mentor.Controls.Add(this.mntrCmbBx);
               this.Mentor.Controls.Add(this.hlpBtn2);
               this.Mentor.Location = new System.Drawing.Point(4, 34);
               this.Mentor.Name = "Mentor";
               this.Mentor.Padding = new System.Windows.Forms.Padding(3);
               this.Mentor.Size = new System.Drawing.Size(792, 412);
               this.Mentor.TabIndex = 1;
               this.Mentor.Text = "Mentor";
               // 
               // MntrMjrTxtBx
               // 
               this.MntrMjrTxtBx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.MntrMjrTxtBx.Location = new System.Drawing.Point(515, 202);
               this.MntrMjrTxtBx.Name = "MntrMjrTxtBx";
               this.MntrMjrTxtBx.ReadOnly = true;
               this.MntrMjrTxtBx.Size = new System.Drawing.Size(254, 47);
               this.MntrMjrTxtBx.TabIndex = 9;
               // 
               // MntrMjrLbl
               // 
               this.MntrMjrLbl.AutoSize = true;
               this.MntrMjrLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.MntrMjrLbl.Location = new System.Drawing.Point(359, 205);
               this.MntrMjrLbl.Name = "MntrMjrLbl";
               this.MntrMjrLbl.Size = new System.Drawing.Size(110, 41);
               this.MntrMjrLbl.TabIndex = 8;
               this.MntrMjrLbl.Text = "Major: ";
               // 
               // mntrFstNmTxtBx
               // 
               this.mntrFstNmTxtBx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mntrFstNmTxtBx.Location = new System.Drawing.Point(515, 105);
               this.mntrFstNmTxtBx.Name = "mntrFstNmTxtBx";
               this.mntrFstNmTxtBx.ReadOnly = true;
               this.mntrFstNmTxtBx.Size = new System.Drawing.Size(254, 47);
               this.mntrFstNmTxtBx.TabIndex = 7;
               // 
               // mntrFstNm
               // 
               this.mntrFstNm.AutoSize = true;
               this.mntrFstNm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mntrFstNm.Location = new System.Drawing.Point(359, 108);
               this.mntrFstNm.Name = "mntrFstNm";
               this.mntrFstNm.Size = new System.Drawing.Size(166, 41);
               this.mntrFstNm.TabIndex = 6;
               this.mntrFstNm.Text = "Full Name: ";
               // 
               // mntrLbl
               // 
               this.mntrLbl.AutoSize = true;
               this.mntrLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mntrLbl.Location = new System.Drawing.Point(88, 108);
               this.mntrLbl.Name = "mntrLbl";
               this.mntrLbl.Size = new System.Drawing.Size(116, 41);
               this.mntrLbl.TabIndex = 5;
               this.mntrLbl.Text = "Mentor";
               // 
               // mntrCmbBx
               // 
               this.mntrCmbBx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mntrCmbBx.FormattingEnabled = true;
               this.mntrCmbBx.Location = new System.Drawing.Point(51, 164);
               this.mntrCmbBx.Name = "mntrCmbBx";
               this.mntrCmbBx.Size = new System.Drawing.Size(191, 49);
               this.mntrCmbBx.TabIndex = 4;
               this.mntrCmbBx.SelectedIndexChanged += new System.EventHandler(this.mntrCmbBx_SelectedIndexChanged);
               // 
               // hlpBtn2
               // 
               this.hlpBtn2.Location = new System.Drawing.Point(690, 375);
               this.hlpBtn2.Name = "hlpBtn2";
               this.hlpBtn2.Size = new System.Drawing.Size(94, 29);
               this.hlpBtn2.TabIndex = 2;
               this.hlpBtn2.Text = "Help";
               this.hlpBtn2.UseVisualStyleBackColor = true;
               this.hlpBtn2.Click += new System.EventHandler(this.hlpBtn2_Click);
               // 
               // Mentee
               // 
               this.Mentee.BackColor = System.Drawing.Color.DarkGray;
               this.Mentee.Controls.Add(this.mnteMjrTxtBx);
               this.Mentee.Controls.Add(this.mnteMjrLbl);
               this.Mentee.Controls.Add(this.mnteNmTxtBx);
               this.Mentee.Controls.Add(this.mnteNmLbl);
               this.Mentee.Controls.Add(this.mnteLbl);
               this.Mentee.Controls.Add(this.mnteCmbBx);
               this.Mentee.Controls.Add(this.hlpBtn3);
               this.Mentee.Location = new System.Drawing.Point(4, 34);
               this.Mentee.Name = "Mentee";
               this.Mentee.Size = new System.Drawing.Size(792, 412);
               this.Mentee.TabIndex = 2;
               this.Mentee.Text = "Mentee";
               // 
               // mnteMjrTxtBx
               // 
               this.mnteMjrTxtBx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mnteMjrTxtBx.Location = new System.Drawing.Point(511, 200);
               this.mnteMjrTxtBx.Name = "mnteMjrTxtBx";
               this.mnteMjrTxtBx.ReadOnly = true;
               this.mnteMjrTxtBx.Size = new System.Drawing.Size(254, 47);
               this.mnteMjrTxtBx.TabIndex = 15;
               // 
               // mnteMjrLbl
               // 
               this.mnteMjrLbl.AutoSize = true;
               this.mnteMjrLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mnteMjrLbl.Location = new System.Drawing.Point(355, 203);
               this.mnteMjrLbl.Name = "mnteMjrLbl";
               this.mnteMjrLbl.Size = new System.Drawing.Size(110, 41);
               this.mnteMjrLbl.TabIndex = 14;
               this.mnteMjrLbl.Text = "Major: ";
               // 
               // mnteNmTxtBx
               // 
               this.mnteNmTxtBx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mnteNmTxtBx.Location = new System.Drawing.Point(511, 103);
               this.mnteNmTxtBx.Name = "mnteNmTxtBx";
               this.mnteNmTxtBx.ReadOnly = true;
               this.mnteNmTxtBx.Size = new System.Drawing.Size(254, 47);
               this.mnteNmTxtBx.TabIndex = 13;
               // 
               // mnteNmLbl
               // 
               this.mnteNmLbl.AutoSize = true;
               this.mnteNmLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mnteNmLbl.Location = new System.Drawing.Point(355, 106);
               this.mnteNmLbl.Name = "mnteNmLbl";
               this.mnteNmLbl.Size = new System.Drawing.Size(166, 41);
               this.mnteNmLbl.TabIndex = 12;
               this.mnteNmLbl.Text = "Full Name: ";
               // 
               // mnteLbl
               // 
               this.mnteLbl.AutoSize = true;
               this.mnteLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mnteLbl.Location = new System.Drawing.Point(84, 106);
               this.mnteLbl.Name = "mnteLbl";
               this.mnteLbl.Size = new System.Drawing.Size(120, 41);
               this.mnteLbl.TabIndex = 11;
               this.mnteLbl.Text = "Mentee";
               // 
               // mnteCmbBx
               // 
               this.mnteCmbBx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mnteCmbBx.FormattingEnabled = true;
               this.mnteCmbBx.Location = new System.Drawing.Point(52, 159);
               this.mnteCmbBx.Name = "mnteCmbBx";
               this.mnteCmbBx.Size = new System.Drawing.Size(188, 49);
               this.mnteCmbBx.TabIndex = 10;
               this.mnteCmbBx.SelectedIndexChanged += new System.EventHandler(this.mnteCmbBx_SelectedIndexChanged);
               // 
               // hlpBtn3
               // 
               this.hlpBtn3.Location = new System.Drawing.Point(690, 375);
               this.hlpBtn3.Name = "hlpBtn3";
               this.hlpBtn3.Size = new System.Drawing.Size(94, 29);
               this.hlpBtn3.TabIndex = 2;
               this.hlpBtn3.Text = "Help";
               this.hlpBtn3.UseVisualStyleBackColor = true;
               this.hlpBtn3.Click += new System.EventHandler(this.hlpBtn3_Click);
               // 
               // Activity
               // 
               this.Activity.BackColor = System.Drawing.Color.DarkGray;
               this.Activity.Controls.Add(this.mnteLstBxNm);
               this.Activity.Controls.Add(this.mntrLstBxNm);
               this.Activity.Controls.Add(this.hrsSpnt);
               this.Activity.Controls.Add(this.dscrbActvt);
               this.Activity.Controls.Add(this.mnteSlct);
               this.Activity.Controls.Add(this.mtnrSlct);
               this.Activity.Controls.Add(this.sbmtBtn);
               this.Activity.Controls.Add(this.hrLstBx);
               this.Activity.Controls.Add(this.actvtTxtBx);
               this.Activity.Controls.Add(this.hlpBtn4);
               this.Activity.Location = new System.Drawing.Point(4, 34);
               this.Activity.Name = "Activity";
               this.Activity.Size = new System.Drawing.Size(792, 412);
               this.Activity.TabIndex = 3;
               this.Activity.Text = "Activity";
               // 
               // mnteLstBxNm
               // 
               this.mnteLstBxNm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mnteLstBxNm.FormattingEnabled = true;
               this.mnteLstBxNm.ItemHeight = 37;
               this.mnteLstBxNm.Location = new System.Drawing.Point(476, 69);
               this.mnteLstBxNm.Name = "mnteLstBxNm";
               this.mnteLstBxNm.ScrollAlwaysVisible = true;
               this.mnteLstBxNm.Size = new System.Drawing.Size(297, 78);
               this.mnteLstBxNm.TabIndex = 13;
               // 
               // mntrLstBxNm
               // 
               this.mntrLstBxNm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mntrLstBxNm.FormattingEnabled = true;
               this.mntrLstBxNm.ItemHeight = 37;
               this.mntrLstBxNm.Location = new System.Drawing.Point(41, 69);
               this.mntrLstBxNm.Name = "mntrLstBxNm";
               this.mntrLstBxNm.ScrollAlwaysVisible = true;
               this.mntrLstBxNm.Size = new System.Drawing.Size(297, 78);
               this.mntrLstBxNm.TabIndex = 12;
               // 
               // hrsSpnt
               // 
               this.hrsSpnt.AutoSize = true;
               this.hrsSpnt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
               this.hrsSpnt.Location = new System.Drawing.Point(488, 211);
               this.hrsSpnt.Name = "hrsSpnt";
               this.hrsSpnt.Size = new System.Drawing.Size(189, 41);
               this.hrsSpnt.TabIndex = 11;
               this.hrsSpnt.Text = "Hours Spent:";
               // 
               // dscrbActvt
               // 
               this.dscrbActvt.AutoSize = true;
               this.dscrbActvt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
               this.dscrbActvt.Location = new System.Drawing.Point(55, 167);
               this.dscrbActvt.Name = "dscrbActvt";
               this.dscrbActvt.Size = new System.Drawing.Size(244, 41);
               this.dscrbActvt.TabIndex = 10;
               this.dscrbActvt.Text = "Describe Activity:";
               // 
               // mnteSlct
               // 
               this.mnteSlct.AutoSize = true;
               this.mnteSlct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
               this.mnteSlct.Location = new System.Drawing.Point(488, 25);
               this.mnteSlct.Name = "mnteSlct";
               this.mnteSlct.Size = new System.Drawing.Size(245, 41);
               this.mnteSlct.TabIndex = 9;
               this.mnteSlct.Text = "Select Mentee(s):";
               // 
               // mtnrSlct
               // 
               this.mtnrSlct.AutoSize = true;
               this.mtnrSlct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
               this.mtnrSlct.Location = new System.Drawing.Point(55, 25);
               this.mtnrSlct.Name = "mtnrSlct";
               this.mtnrSlct.Size = new System.Drawing.Size(241, 41);
               this.mtnrSlct.TabIndex = 8;
               this.mtnrSlct.Text = "Select Mentor(s):";
               // 
               // sbmtBtn
               // 
               this.sbmtBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.sbmtBtn.Location = new System.Drawing.Point(539, 306);
               this.sbmtBtn.Name = "sbmtBtn";
               this.sbmtBtn.Size = new System.Drawing.Size(155, 49);
               this.sbmtBtn.TabIndex = 7;
               this.sbmtBtn.Text = "Submit";
               this.sbmtBtn.UseVisualStyleBackColor = true;
               this.sbmtBtn.Click += new System.EventHandler(this.sbmtBtn_Click);
               // 
               // hrLstBx
               // 
               this.hrLstBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.hrLstBx.FormattingEnabled = true;
               this.hrLstBx.ItemHeight = 31;
               this.hrLstBx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
               this.hrLstBx.Location = new System.Drawing.Point(685, 211);
               this.hrLstBx.Name = "hrLstBx";
               this.hrLstBx.ScrollAlwaysVisible = true;
               this.hrLstBx.Size = new System.Drawing.Size(54, 66);
               this.hrLstBx.TabIndex = 6;
               // 
               // actvtTxtBx
               // 
               this.actvtTxtBx.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.actvtTxtBx.Location = new System.Drawing.Point(41, 211);
               this.actvtTxtBx.Multiline = true;
               this.actvtTxtBx.Name = "actvtTxtBx";
               this.actvtTxtBx.Size = new System.Drawing.Size(393, 165);
               this.actvtTxtBx.TabIndex = 5;
               // 
               // hlpBtn4
               // 
               this.hlpBtn4.Location = new System.Drawing.Point(690, 375);
               this.hlpBtn4.Name = "hlpBtn4";
               this.hlpBtn4.Size = new System.Drawing.Size(94, 29);
               this.hlpBtn4.TabIndex = 2;
               this.hlpBtn4.Text = "Help";
               this.hlpBtn4.UseVisualStyleBackColor = true;
               this.hlpBtn4.Click += new System.EventHandler(this.hlpBtn4_Click_1);
               // 
               // Reports
               // 
               this.Reports.BackColor = System.Drawing.Color.DarkGray;
               this.Reports.Controls.Add(this.rptLstBx);
               this.Reports.Controls.Add(this.hlpBtn5);
               this.Reports.Controls.Add(this.mnteMjrCntBtn);
               this.Reports.Controls.Add(this.actvtCntBtn);
               this.Reports.Location = new System.Drawing.Point(4, 34);
               this.Reports.Name = "Reports";
               this.Reports.Size = new System.Drawing.Size(792, 412);
               this.Reports.TabIndex = 4;
               this.Reports.Text = "Reports";
               // 
               // rptLstBx
               // 
               this.rptLstBx.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.rptLstBx.FormattingEnabled = true;
               this.rptLstBx.ItemHeight = 23;
               this.rptLstBx.Location = new System.Drawing.Point(357, 65);
               this.rptLstBx.Name = "rptLstBx";
               this.rptLstBx.Size = new System.Drawing.Size(388, 280);
               this.rptLstBx.TabIndex = 4;
               // 
               // hlpBtn5
               // 
               this.hlpBtn5.Location = new System.Drawing.Point(690, 375);
               this.hlpBtn5.Name = "hlpBtn5";
               this.hlpBtn5.Size = new System.Drawing.Size(94, 29);
               this.hlpBtn5.TabIndex = 3;
               this.hlpBtn5.Text = "Help";
               this.hlpBtn5.UseVisualStyleBackColor = true;
               this.hlpBtn5.Click += new System.EventHandler(this.hlpBtn5_Click);
               // 
               // mnteMjrCntBtn
               // 
               this.mnteMjrCntBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mnteMjrCntBtn.Location = new System.Drawing.Point(53, 249);
               this.mnteMjrCntBtn.Name = "mnteMjrCntBtn";
               this.mnteMjrCntBtn.Size = new System.Drawing.Size(196, 106);
               this.mnteMjrCntBtn.TabIndex = 1;
               this.mnteMjrCntBtn.Text = "Get Mentees By Major";
               this.mnteMjrCntBtn.UseVisualStyleBackColor = true;
               this.mnteMjrCntBtn.Click += new System.EventHandler(this.mnteMjrCntBtn_Click);
               // 
               // actvtCntBtn
               // 
               this.actvtCntBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.actvtCntBtn.Location = new System.Drawing.Point(53, 65);
               this.actvtCntBtn.Name = "actvtCntBtn";
               this.actvtCntBtn.Size = new System.Drawing.Size(196, 106);
               this.actvtCntBtn.TabIndex = 0;
               this.actvtCntBtn.Text = "Get Number of Activities Per Mentee";
               this.actvtCntBtn.UseVisualStyleBackColor = true;
               this.actvtCntBtn.Click += new System.EventHandler(this.actvtCntBtn_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.menu);
               this.Name = "Form1";
               this.Text = "Fredonia Mentor/Mentee Application";
               this.menu.ResumeLayout(false);
               this.Home.ResumeLayout(false);
               this.Home.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.Mentor.ResumeLayout(false);
               this.Mentor.PerformLayout();
               this.Mentee.ResumeLayout(false);
               this.Mentee.PerformLayout();
               this.Activity.ResumeLayout(false);
               this.Activity.PerformLayout();
               this.Reports.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.TabControl menu;
          private System.Windows.Forms.TabPage Home;
          private System.Windows.Forms.TabPage Mentor;
          private System.Windows.Forms.TabPage Mentee;
          private System.Windows.Forms.TabPage Activity;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Button hlpBtn;
          private System.Windows.Forms.Button hlpBtn2;
          private System.Windows.Forms.Button hlpBtn3;
          private System.Windows.Forms.Button hlpBtn4;
          private System.Windows.Forms.TextBox MntrMjrTxtBx;
          private System.Windows.Forms.Label MntrMjrLbl;
          private System.Windows.Forms.TextBox mntrFstNmTxtBx;
          private System.Windows.Forms.Label mntrFstNm;
          private System.Windows.Forms.Label mntrLbl;
          private System.Windows.Forms.ComboBox mntrCmbBx;
          private System.Windows.Forms.TextBox mnteMjrTxtBx;
          private System.Windows.Forms.Label mnteMjrLbl;
          private System.Windows.Forms.TextBox mnteNmTxtBx;
          private System.Windows.Forms.Label mnteNmLbl;
          private System.Windows.Forms.Label mnteLbl;
          private System.Windows.Forms.ComboBox mnteCmbBx;
          private System.Windows.Forms.Label hrsSpnt;
          private System.Windows.Forms.Label dscrbActvt;
          private System.Windows.Forms.Label mnteSlct;
          private System.Windows.Forms.Label mtnrSlct;
          private System.Windows.Forms.Button sbmtBtn;
          private System.Windows.Forms.ListBox hrLstBx;
          private System.Windows.Forms.TextBox actvtTxtBx;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.TabPage Reports;
          private System.Windows.Forms.Button mnteMjrCntBtn;
          private System.Windows.Forms.Button actvtCntBtn;
          private System.Windows.Forms.Button hlpBtn5;
          private System.Windows.Forms.ListBox rptLstBx;
          private System.Windows.Forms.ListBox mntrLstBxNm;
          private System.Windows.Forms.ListBox mnteLstBxNm;
     }
}

