using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EMSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void update_Tick(object sender, EventArgs e)
        {
            adminPassBox.Enabled = checkBox1.Checked;
            passwordBox.Enabled = checkBox2.Checked;
            rconPortBox.Enabled = checkBox3.Checked;
            rconPasswordBox.Enabled = checkBox3.Checked;
            motdUrlBox.Enabled = checkBox5.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int teamDamageFlinch = 0;

            if (teamDamageFlinchCheckBox.Checked) {
                teamDamageFlinch = 1;
            }

            finalGameIni.Text = "[/Script/Mordhau.MordhauGameMode]" + Environment.NewLine
                + "MOTDURL=" + motdUrlBox.Text + Environment.NewLine
                + "bIsThirdPersonCameraDisabled=" + disableThirdPersonBox.Checked + Environment.NewLine
                + "ConstrainAspectRatio=0.000000" + Environment.NewLine
                + "bIsHitStopOnTeamHitsDisabled=" + disableTeamHitstopCheckBox.Checked + Environment.NewLine
                + "bDisableClientMods=" + disableClientModsCheckBox.Checked + Environment.NewLine
                + "bLogKillfeed=False" + Environment.NewLine
                + "bLogChat=False" + Environment.NewLine
                + "bLogScore=False" + Environment.NewLine
                + "bAllowAdminChat=True" + Environment.NewLine
                + "bAllowWhisperChat=False" + Environment.NewLine
                + "PlayerRespawnTime" + respawnBox.Text + Environment.NewLine
                + "AutoKickOnTeamKillAmount=5" + Environment.NewLine
                + "BallistaRespawnTime=30.000000" + Environment.NewLine
                + "CatapultRespawnTime=30.000000" + Environment.NewLine
                + "HorseRespawnTime=30.000000" + Environment.NewLine
                + "DamageFactor=" + damageFactorBox.Text + Environment.NewLine
                + "TeamDamageFactor=" + teamDamageFactorBox.Text + Environment.NewLine
                + "TeamDamageFlinch=" + teamDamageFlinch + Environment.NewLine
                + "MessageTypeMap=((\"Say\", \"ALL\"),(\"TeamSay\", \"TEAM\"),(\"Whisper\", \"WHISPER\"),(\"AdminSay\", \"ADMIN\"),(\"AdminChat\", \"ADMIN\"),(\"AdminWhisper\", \"ADMIN\"),(\"AdminAnnounce\", \"ADMIN\"),(\"AdminPrivateAnnounce\", \"ADMIN\"))" + Environment.NewLine
                + mapRotationBox.Text + Environment.NewLine
                + "" + Environment.NewLine
                + "[/Script/Mordhau.MordhauGameSession]" + Environment.NewLine
                + "MaxSlots=" + slotsBox.Text + Environment.NewLine
                + "ServerName=" + nameBox.Text + Environment.NewLine
                + "ServerPassword=" + passwordBox.Text + Environment.NewLine
                + "AdminPassword=" + adminPassBox.Text + Environment.NewLine
                + "RconPassword=" + rconPasswordBox.Text + Environment.NewLine
                + "RconPort=" + rconPortBox.Text + Environment.NewLine
                + "bTieredAdmins=False" + Environment.NewLine
                + "RconAdminsTierMap=()" + Environment.NewLine
                + "AdminsTierMap=()" + Environment.NewLine
                + "bAllowHttpRequests=False" + Environment.NewLine
                + "BannedPlayers=()" + Environment.NewLine
                + "MutedPlayers=()" + Environment.NewLine
                + "LegacyBannedPlayers=()" + Environment.NewLine
                + "LegacyMutedPlayers=()" + Environment.NewLine
                + modsBox.Text + Environment.NewLine
                + "bAdvertiseServerViaSteam=False" + Environment.NewLine
                + "bUseLegacyPakMounting=False" + Environment.NewLine
                + "bUseOfficialBanList=" + useOfficialBanListBox.Checked + Environment.NewLine
                + "bUseOfficialMuteList=" + useOfficialMuteListCheckBox.Checked + Environment.NewLine
                + "" + Environment.NewLine
                + "[/Game/Mordhau/Blueprints/GameModes/BP_DeathmatchGameMode.BP_DeathmatchGameMode_C]" + Environment.NewLine
                + "ScoreToWin=" + Int32.Parse(killsToWinBox.Text) * 100 + Environment.NewLine
                + "" + Environment.NewLine
                + "[/Game/Mordhau/Blueprints/GameModes/BP_DeathmatchGameState.BP_DeathmatchGameState_C]" + Environment.NewLine
                + "MatchDurationMax=" + Int32.Parse(roundDurationBox.Text) * 60 + Environment.NewLine;

            finalEngineIni.Text = "[/Script/OnlineSubsystemUtils.IpNetDriver]" + Environment.NewLine
                + "NetServerMaxTickRate= " + tickBox.Text;

            File.WriteAllText("Game.ini", finalGameIni.Text);
            File.WriteAllText("Engine.ini", finalEngineIni.Text);

            MessageBox.Show("Successfully generated Game.ini and Engine.ini");
        }

        private void modsHelpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Add your mods from Mod.Io here by typing \"Mods=\" followed by the ID of the mod you want to add. Example: \"Mods=883562\". Each mod needs to be added on a separate line. Do NOT include quotation marks. Leave this blank if you do not want to add any mods.");
        }

        private void mapRotationHelpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Add maps to your server's map rotation here by typing \"MapRotation=\" followed by the map you want to add. Each map needs to be added on a separate line");
        }
    }
}
