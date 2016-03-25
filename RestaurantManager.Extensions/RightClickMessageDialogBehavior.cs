using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager.Extensions
{
    public class RightClickMessageDialogBehavior : DependencyObject, IBehavior
    {
        public string Message { get; set; }
        public string Title { get; set; }


        public DependencyObject AssociatedObject
        {
            get;
            private set;
        }

        public void Attach(DependencyObject associatedObject)
        {
            this.AssociatedObject = associatedObject;
            (this.AssociatedObject as Page).RightTapped += Right_Button_Click;
        }

        public void Detach()
        {
            (this.AssociatedObject as Page).RightTapped -= Right_Button_Click;
        }

        private async void Right_Button_Click(object sender, RoutedEventArgs e)
        {
            await new MessageDialog(this.Message, this.Title).ShowAsync();
        }
    }
}
