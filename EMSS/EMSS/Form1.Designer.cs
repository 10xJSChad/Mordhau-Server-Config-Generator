namespace EMSS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminPassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rconPortBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.rconPasswordBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.slotsBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tickBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.respawnBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.teamDamageFlinchCheckBox = new System.Windows.Forms.CheckBox();
            this.useOfficialBanListBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.useOfficialMuteListCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.disableTeamHitstopCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.disableClientModsCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.teamDamageFactorBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.damageFactorBox = new System.Windows.Forms.TextBox();
            this.disableThirdPersonBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.killsToWinBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.roundDurationBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.mapRotationBox = new System.Windows.Forms.TextBox();
            this.modsBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.finalGameIni = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.motdUrlBox = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.finalEngineIni = new System.Windows.Forms.TextBox();
            this.modsHelpLabel = new System.Windows.Forms.LinkLabel();
            this.mapRotationHelpLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(12, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(147, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordBox
            // 
            this.passwordBox.Enabled = false;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(12, 95);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(147, 22);
            this.passwordBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adminPassBox
            // 
            this.adminPassBox.Enabled = false;
            this.adminPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassBox.Location = new System.Drawing.Point(12, 153);
            this.adminPassBox.Name = "adminPassBox";
            this.adminPassBox.Size = new System.Drawing.Size(147, 22);
            this.adminPassBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "RCON Port";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rconPortBox
            // 
            this.rconPortBox.Enabled = false;
            this.rconPortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rconPortBox.Location = new System.Drawing.Point(50, 345);
            this.rconPortBox.Name = "rconPortBox";
            this.rconPortBox.Size = new System.Drawing.Size(73, 22);
            this.rconPortBox.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(165, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(165, 98);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(164, 370);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 10;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "RCON Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rconPasswordBox
            // 
            this.rconPasswordBox.Enabled = false;
            this.rconPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rconPasswordBox.Location = new System.Drawing.Point(12, 399);
            this.rconPasswordBox.Name = "rconPasswordBox";
            this.rconPasswordBox.Size = new System.Drawing.Size(147, 22);
            this.rconPasswordBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max Slots";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // slotsBox
            // 
            this.slotsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotsBox.Location = new System.Drawing.Point(51, 219);
            this.slotsBox.Name = "slotsBox";
            this.slotsBox.Size = new System.Drawing.Size(73, 22);
            this.slotsBox.TabIndex = 13;
            this.slotsBox.Text = "16";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tickrate";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tickBox
            // 
            this.tickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickBox.Location = new System.Drawing.Point(50, 276);
            this.tickBox.Name = "tickBox";
            this.tickBox.Size = new System.Drawing.Size(73, 22);
            this.tickBox.TabIndex = 15;
            this.tickBox.Text = "64";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(186, -46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 574);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Respawn Time";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // respawnBox
            // 
            this.respawnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respawnBox.Location = new System.Drawing.Point(254, 37);
            this.respawnBox.Name = "respawnBox";
            this.respawnBox.Size = new System.Drawing.Size(73, 22);
            this.respawnBox.TabIndex = 18;
            this.respawnBox.Text = "5.000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Team Damage Flinch";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamDamageFlinchCheckBox
            // 
            this.teamDamageFlinchCheckBox.AutoSize = true;
            this.teamDamageFlinchCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDamageFlinchCheckBox.Location = new System.Drawing.Point(368, 182);
            this.teamDamageFlinchCheckBox.Name = "teamDamageFlinchCheckBox";
            this.teamDamageFlinchCheckBox.Size = new System.Drawing.Size(15, 14);
            this.teamDamageFlinchCheckBox.TabIndex = 22;
            this.teamDamageFlinchCheckBox.UseVisualStyleBackColor = true;
            // 
            // useOfficialBanListBox
            // 
            this.useOfficialBanListBox.AutoSize = true;
            this.useOfficialBanListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useOfficialBanListBox.Location = new System.Drawing.Point(368, 309);
            this.useOfficialBanListBox.Name = "useOfficialBanListBox";
            this.useOfficialBanListBox.Size = new System.Drawing.Size(15, 14);
            this.useOfficialBanListBox.TabIndex = 24;
            this.useOfficialBanListBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(207, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Use Official Ban List";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // useOfficialMuteListCheckBox
            // 
            this.useOfficialMuteListCheckBox.AutoSize = true;
            this.useOfficialMuteListCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useOfficialMuteListCheckBox.Location = new System.Drawing.Point(368, 340);
            this.useOfficialMuteListCheckBox.Name = "useOfficialMuteListCheckBox";
            this.useOfficialMuteListCheckBox.Size = new System.Drawing.Size(15, 14);
            this.useOfficialMuteListCheckBox.TabIndex = 26;
            this.useOfficialMuteListCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(207, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Use Official Mute List";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // disableTeamHitstopCheckBox
            // 
            this.disableTeamHitstopCheckBox.AutoSize = true;
            this.disableTeamHitstopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableTeamHitstopCheckBox.Location = new System.Drawing.Point(368, 213);
            this.disableTeamHitstopCheckBox.Name = "disableTeamHitstopCheckBox";
            this.disableTeamHitstopCheckBox.Size = new System.Drawing.Size(15, 14);
            this.disableTeamHitstopCheckBox.TabIndex = 28;
            this.disableTeamHitstopCheckBox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(205, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Disable Team Hitstop";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // disableClientModsCheckBox
            // 
            this.disableClientModsCheckBox.AutoSize = true;
            this.disableClientModsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableClientModsCheckBox.Location = new System.Drawing.Point(368, 277);
            this.disableClientModsCheckBox.Name = "disableClientModsCheckBox";
            this.disableClientModsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.disableClientModsCheckBox.TabIndex = 30;
            this.disableClientModsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(205, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Disable Client Mods";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(209, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Team Damage Factor";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamDamageFactorBox
            // 
            this.teamDamageFactorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDamageFactorBox.Location = new System.Drawing.Point(254, 144);
            this.teamDamageFactorBox.Name = "teamDamageFactorBox";
            this.teamDamageFactorBox.Size = new System.Drawing.Size(73, 22);
            this.teamDamageFactorBox.TabIndex = 31;
            this.teamDamageFactorBox.Text = "0.250000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(232, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Damage Factor";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // damageFactorBox
            // 
            this.damageFactorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageFactorBox.Location = new System.Drawing.Point(254, 90);
            this.damageFactorBox.Name = "damageFactorBox";
            this.damageFactorBox.Size = new System.Drawing.Size(73, 22);
            this.damageFactorBox.TabIndex = 33;
            this.damageFactorBox.Text = "1.000000";
            // 
            // disableThirdPersonBox
            // 
            this.disableThirdPersonBox.AutoSize = true;
            this.disableThirdPersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableThirdPersonBox.Location = new System.Drawing.Point(368, 245);
            this.disableThirdPersonBox.Name = "disableThirdPersonBox";
            this.disableThirdPersonBox.Size = new System.Drawing.Size(15, 14);
            this.disableThirdPersonBox.TabIndex = 36;
            this.disableThirdPersonBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(205, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Disable Third Person";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(390, -47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 562);
            this.button2.TabIndex = 37;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(435, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "FFA Kills To Win";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // killsToWinBox
            // 
            this.killsToWinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killsToWinBox.Location = new System.Drawing.Point(463, 37);
            this.killsToWinBox.Name = "killsToWinBox";
            this.killsToWinBox.Size = new System.Drawing.Size(73, 22);
            this.killsToWinBox.TabIndex = 38;
            this.killsToWinBox.Text = "30";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(420, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 20);
            this.label18.TabIndex = 41;
            this.label18.Text = "FFA Round Duration";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roundDurationBox
            // 
            this.roundDurationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundDurationBox.Location = new System.Drawing.Point(463, 90);
            this.roundDurationBox.Name = "roundDurationBox";
            this.roundDurationBox.Size = new System.Drawing.Size(73, 22);
            this.roundDurationBox.TabIndex = 40;
            this.roundDurationBox.Text = "20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(539, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 16);
            this.label19.TabIndex = 42;
            this.label19.Text = "minutes";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mapRotationBox
            // 
            this.mapRotationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapRotationBox.Location = new System.Drawing.Point(410, 156);
            this.mapRotationBox.Multiline = true;
            this.mapRotationBox.Name = "mapRotationBox";
            this.mapRotationBox.Size = new System.Drawing.Size(194, 103);
            this.mapRotationBox.TabIndex = 43;
            this.mapRotationBox.Text = "MapRotation=FFA_Contraband";
            // 
            // modsBox
            // 
            this.modsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modsBox.Location = new System.Drawing.Point(410, 292);
            this.modsBox.Multiline = true;
            this.modsBox.Name = "modsBox";
            this.modsBox.Size = new System.Drawing.Size(194, 103);
            this.modsBox.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(454, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 20);
            this.label20.TabIndex = 45;
            this.label20.Text = "Map Rotation";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(479, 270);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 20);
            this.label21.TabIndex = 46;
            this.label21.Text = "Mods";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(410, 413);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(194, 63);
            this.generateButton.TabIndex = 47;
            this.generateButton.Text = "Generate Server Config";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // finalGameIni
            // 
            this.finalGameIni.Enabled = false;
            this.finalGameIni.Location = new System.Drawing.Point(683, 51);
            this.finalGameIni.Multiline = true;
            this.finalGameIni.Name = "finalGameIni";
            this.finalGameIni.Size = new System.Drawing.Size(273, 259);
            this.finalGameIni.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(41, 431);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 20);
            this.label22.TabIndex = 50;
            this.label22.Text = "MOTD URL";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // motdUrlBox
            // 
            this.motdUrlBox.Enabled = false;
            this.motdUrlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdUrlBox.Location = new System.Drawing.Point(12, 454);
            this.motdUrlBox.Name = "motdUrlBox";
            this.motdUrlBox.Size = new System.Drawing.Size(147, 22);
            this.motdUrlBox.TabIndex = 49;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(164, 459);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 51;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // finalEngineIni
            // 
            this.finalEngineIni.Enabled = false;
            this.finalEngineIni.Location = new System.Drawing.Point(683, 336);
            this.finalEngineIni.Multiline = true;
            this.finalEngineIni.Name = "finalEngineIni";
            this.finalEngineIni.Size = new System.Drawing.Size(260, 81);
            this.finalEngineIni.TabIndex = 52;
            // 
            // modsHelpLabel
            // 
            this.modsHelpLabel.AutoSize = true;
            this.modsHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modsHelpLabel.Location = new System.Drawing.Point(521, 272);
            this.modsHelpLabel.Name = "modsHelpLabel";
            this.modsHelpLabel.Size = new System.Drawing.Size(22, 15);
            this.modsHelpLabel.TabIndex = 54;
            this.modsHelpLabel.TabStop = true;
            this.modsHelpLabel.Text = "(?)";
            this.modsHelpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.modsHelpLabel_LinkClicked);
            // 
            // mapRotationHelpLabel
            // 
            this.mapRotationHelpLabel.AutoSize = true;
            this.mapRotationHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapRotationHelpLabel.Location = new System.Drawing.Point(554, 135);
            this.mapRotationHelpLabel.Name = "mapRotationHelpLabel";
            this.mapRotationHelpLabel.Size = new System.Drawing.Size(22, 15);
            this.mapRotationHelpLabel.TabIndex = 55;
            this.mapRotationHelpLabel.TabStop = true;
            this.mapRotationHelpLabel.Text = "(?)";
            this.mapRotationHelpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mapRotationHelpLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 488);
            this.Controls.Add(this.mapRotationHelpLabel);
            this.Controls.Add(this.modsHelpLabel);
            this.Controls.Add(this.finalEngineIni);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.motdUrlBox);
            this.Controls.Add(this.finalGameIni);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.modsBox);
            this.Controls.Add(this.mapRotationBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.roundDurationBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.killsToWinBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.disableThirdPersonBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.damageFactorBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.teamDamageFactorBox);
            this.Controls.Add(this.disableClientModsCheckBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.disableTeamHitstopCheckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.useOfficialMuteListCheckBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.useOfficialBanListBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.teamDamageFlinchCheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.respawnBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tickBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.slotsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rconPasswordBox);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rconPortBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminPassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.MaximumSize = new System.Drawing.Size(629, 527);
            this.MinimumSize = new System.Drawing.Size(629, 527);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Mordhau Server Setup - RojokooL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminPassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rconPortBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rconPasswordBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox slotsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tickBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox respawnBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox teamDamageFlinchCheckBox;
        private System.Windows.Forms.CheckBox useOfficialBanListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox useOfficialMuteListCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox disableTeamHitstopCheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox disableClientModsCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox teamDamageFactorBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox damageFactorBox;
        private System.Windows.Forms.CheckBox disableThirdPersonBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox killsToWinBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox roundDurationBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox mapRotationBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox modsBox;
        private System.Windows.Forms.TextBox finalGameIni;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox motdUrlBox;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox finalEngineIni;
        private System.Windows.Forms.LinkLabel modsHelpLabel;
        private System.Windows.Forms.LinkLabel mapRotationHelpLabel;
    }
}

