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

            // Goals: 
            // create member objects
            // store them in a JSON format
            // Display the guild member list. 
            
            this.grdNewUser.Visibility = Visibility.Collapsed; 
        }

        private void btnNewMember_Click_1(object sender, RoutedEventArgs e)
        {
            // Spawn the new member text controls
            grdNewUser.Visibility = Visibility.Visible; 

            
        }

        private void btnNewMemApply_Click(object sender, RoutedEventArgs e)
        {
            // GuildMember tmpMember = GuildMember.AddMember(); 

            
            
            
        }
    }
}
