using System.Collections.Generic;
using System.ComponentModel;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        private List<MenuItem> _menuItems;

        public List<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set
            {
                if ( value != _menuItems)
                {
                    _menuItems = value;
                    OnPropertyChanged(); 
                }
            }
        }

        private List<MenuItem> _currentlySelectedMenuItems;
        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get
            {
                return _currentlySelectedMenuItems;
            }
            set
            {
                if (value != _currentlySelectedMenuItems)
                {
                    _currentlySelectedMenuItems = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
