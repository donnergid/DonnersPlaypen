using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Windows.Storage; 





// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GIDAdministration
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
            //Ensure the proper controls are not visible on init. 
            this.grdNewUser.Visibility = Visibility.Collapsed;
            this.grdAddGuild.Visibility = Visibility.Collapsed; 

            //Search/Create for the dependent local files
            // GuildList, MemberList & Logging files. 

            
        }

        private void btnNewMember_Click_1(object sender, RoutedEventArgs e)
        {
            // Spawn the new member text controls
            grdNewUser.Visibility = Visibility.Visible; 

            
        }

        private void btnNewMemApply_Click(object sender, RoutedEventArgs e)
        {
            GuildMember tmpMember = new GuildMember();
            tmpMember.AddMember("Ghosts in the Darkness",txtbxCharName.Text, txtbxCharRace.Text, txtbxCharClass.Text, txtbxCharSpec.Text, txtbxRealm.Text); 
                                    
        }

        private void btnAddGuild_Click(object sender, RoutedEventArgs e)
        {
            grdAddGuild.Visibility = Visibility.Visible; 
        }


        private async void btnGuildApply_Click_1(object sender, RoutedEventArgs e)
        {
            // add guild object here, store data and pass to Json writer. 
            Guild tmpGuild = new Guild();

            tmpGuild.gName = txtbxAddGuildName.Text;
            tmpGuild.gRealm = txtbxAddRealm.Text;

            GuildLIst.gmMain.Add(tmpGuild);



            // StorageFolder sfold = Windows.ApplicationModel.Package.Current.InstalledLocation; 
            // StorageFile sfile = await sfold.CreateFileAsync("Sample.json", Windows.Storage.CreationCollisionOption.ReplaceExisting);

            // txtblkStatus.Text = "file written/overwritten";
            StorageFile newFile = await DownloadsFolder.CreateFileAsync("GuildList.json", CreationCollisionOption.OpenIfExists);
           
            try
            {

                await PathIO.WriteTextAsync(newFile.Path, "Swift as a shadow");

            }
            // Handle errors with catch blocks
            catch (FileNotFoundException)
            {
                // For example, handle file not found
            }
            catch (UnauthorizedAccessException)
            {
                throw; 
            }
           
            
            /*
            JsonSerializer serializer;

            // Need to add access exception handling. 
            try
            {
                
                serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(ApplicationData.Current.LocalFolder))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, GuildLIst.gmMain);
                    }
                }
            }
            catch (Exception oEX)
            {

                txtblkStatus.Text = "Exception found, " + oEX.Message; 
            }

            if (txtblkStatus.Text.Contains("Status"))
            {
                txtblkStatus.Text = "File Saved";
            }
            */


        }
    }
}
