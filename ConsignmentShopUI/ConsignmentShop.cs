using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();

        private decimal storeProfit = 0;


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemListbox.DataSource = itemsBinding;

            itemListbox.DisplayMember = "Display";
            itemListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListbox.DataSource = vendorsBinding;

            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";




        }

        private void SetupData()
        {

            store.Vendors.Add(new Vendor { FirstName = "Matthew", LastName = "Zaśko" });
            store.Vendors.Add(new Vendor { FirstName = "Michał", LastName = "Dziuba" });

            store.Items.Add(new Item { Title = "Moby Dick", Desscription = "A book about whale", Price = 4.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Lord of The Rings", Desscription = "A book about magic ring", Price = 5.80M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Harry Poter Book 1", Desscription = "A book about wizards", Price = 3.70M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Jane Eyre", Desscription = "A book about girl", Price = 1.50M, Owner = store.Vendors[0] });

            store.Name = "Seconds are Better";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemListbox.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            shoppingCartData.Clear();     
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            storeProfitValue.Text =  string.Format("${0}", storeProfit);
                
        }

      
    } 
}
