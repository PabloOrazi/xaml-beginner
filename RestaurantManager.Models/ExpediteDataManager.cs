using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            
        }

        private List<Order> _orderItems;

        public List<Order> OrderItems
        {
            get { return base.Repository.Orders; }
            set
            {
                if (value != _orderItems)
                {
                    _orderItems = value;
                    OnPropertyChanged();

                }
            }
        }
    }
}
