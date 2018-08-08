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
using System.Configuration; 

namespace GIDAdministrationLegacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hiding the forms that the customer doesn't need to see on first load. 
            pnlTestInterface.Visible = false;
            pnlAddNewMember.Visible = false;
            pnlShowMembers.Visible = false;
            pnlViewMembers.Visible = false; 

            // Need to read in the file store items to populate infoStorage.gidMain
            // Populate the members list with some temporary character data, later this should pull from stored information. 



            GuildMember one = new GuildMember("Dhkala", "Undead", "Rogue", "Assassination", "PST", "None", "Shu'halo");
            GuildMember two = new GuildMember("Blackened", "Blood Elf", "Paladin", "Protection", "PST", "None", "Shu'halo");
            GuildMember three = new GuildMember("Phobetorr", "Blood Elf", "Warlock", "Affliction", "PST", "None", "Shu'halo");
            GuildMember four = new GuildMember("Diosamor", "Troll", "Mage", "Frost", "PST", "None", "Shu'halo"); 

            infoStorage.gidMain.Add(one);
            infoStorage.gidMain.Add(two);
            infoStorage.gidMain.Add(three);
            infoStorage.gidMain.Add(four); 

        }

        private void btnShowTestInterface_Click(object sender, EventArgs e)
        {
            pnlTestInterface.Visible = true; // make the test interface visible to the User. 
        }

        private void btnHideTestInterface_Click(object sender, EventArgs e)
        {
            pnlTestInterface.Visible = false;
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            pnlAddNewMember.Visible = true;
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = ConfigurationManager.ConnectionStrings["filelocation"].ConnectionString + "GuildList.json";

                FileStream fs = File.Create(fileName);
                fs.Close();
                lblErrorStatus.Text = "File Created Successfully";
            }
            catch (IOException oEX)
            {
                MessageBox.Show(oEX.Message);
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
                throw;
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = ConfigurationManager.ConnectionStrings["filelocation"].ConnectionString + "GuildList.json";
                File.Delete(fileName);
                lblErrorStatus.Text = "File Deleted Successfully";
            }
            catch (IOException oEX)
            {
                MessageBox.Show(oEX.Message);
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
                throw;
            }
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMemberApply_Click(object sender, EventArgs e)
        {

        }

        GuildMember addNewGuildMember()
        {
            GuildMember tmpGmem = new GuildMember();

            tmpGmem.charName = txbxCharName.Text;
            tmpGmem.charRace = cmbbxCharRace.SelectedIndex.ToString();
            tmpGmem.charClass = cmbbxCharClass.SelectedIndex.ToString();
            tmpGmem.charSpec = cmbbxCharSpec.SelectedIndex.ToString();
            tmpGmem.locale = cmbbxLocale.SelectedIndex.ToString();
            tmpGmem.currentGuild.guildName = cmbbxGuildName.SelectedIndex.ToString();
            tmpGmem.currentGuild.realmName = cmbbxRealm.SelectedIndex.ToString();

            infoStorage.gidMain.Add(tmpGmem);

            return tmpGmem;
        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            /*  This is the code to view using ShowMembers listbox
                 
            pnlShowMembers.Visible = true;
            
            // Parse the infoStorage.gidmain object. 
            foreach (var gm in infoStorage.gidMain)
            {
                lstbxShowMembers.BeginUpdate();
                lstbxShowMembers.Items.Add(gm.charName);
                lstbxShowMembers.EndUpdate(); 
            }*/

            // This is the code to view using ListMembers listview
            pnlViewMembers.Visible = true; 

            foreach (GuildMember tmpGM in infoStorage.gidMain)
            {
                ListViewItem item = new ListViewItem(tmpGM.charName);

                
                item.SubItems.Add(tmpGM.charRace);
                item.SubItems.Add(tmpGM.charClass);
                item.SubItems.Add(tmpGM.charSpec);
                
                lstvwViewMembers.Items.Add(item);
                btnShowMembers.Focus(); 
                                
            }
            
            

        }

        private void cmbbxCharClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When we select a Class, we need to show only the correct specifications. 

            string tmpChar = cmbbxCharClass.Text;

            switch (tmpChar)
            {
                case "Death Knight":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Blood");
                    cmbbxCharSpec.Items.Add("Frost");
                    cmbbxCharSpec.Items.Add("Unholy");
                    cmbbxCharSpec.EndUpdate(); 
                    break;
                case "Demon Hunter":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Havoc");
                    cmbbxCharSpec.Items.Add("Vengance");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Druid":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Balance");
                    cmbbxCharSpec.Items.Add("Feral");
                    cmbbxCharSpec.Items.Add("Guardian");
                    cmbbxCharSpec.Items.Add("Restoration");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Hunter":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Beastmaster");
                    cmbbxCharSpec.Items.Add("Marksman");
                    cmbbxCharSpec.Items.Add("Survival");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Mage":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Arcane");
                    cmbbxCharSpec.Items.Add("Fire");
                    cmbbxCharSpec.Items.Add("Frost");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Monk":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Brewmaster");
                    cmbbxCharSpec.Items.Add("Mistweaver");
                    cmbbxCharSpec.Items.Add("Windwalker");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Paladin":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Holy");
                    cmbbxCharSpec.Items.Add("Protection");
                    cmbbxCharSpec.Items.Add("Retribution");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Priest":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Discipline");
                    cmbbxCharSpec.Items.Add("Holy");
                    cmbbxCharSpec.Items.Add("Shadow");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Rogue":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Assassination");
                    cmbbxCharSpec.Items.Add("Outlaw");
                    cmbbxCharSpec.Items.Add("Subtlety");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Shaman":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Enhancement");
                    cmbbxCharSpec.Items.Add("Elemental");
                    cmbbxCharSpec.Items.Add("Restoration");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Warlock":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Afflication");
                    cmbbxCharSpec.Items.Add("Demonology");
                    cmbbxCharSpec.Items.Add("Destruction");
                    cmbbxCharSpec.EndUpdate();
                    break;
                case "Warrior":
                    cmbbxCharSpec.Items.Clear();
                    cmbbxCharSpec.BeginUpdate();
                    cmbbxCharSpec.Items.Add("Arms");
                    cmbbxCharSpec.Items.Add("Fury");
                    cmbbxCharSpec.Items.Add("Protection");
                    cmbbxCharSpec.EndUpdate();
                    break;
                default:
                    // should I need to add a error condition, it will go here. 
                    cmbbxCharSpec.Text = "Pick Class"; 
                    break;
            }
        }
    }
}
