using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class Form1 : Form
    {
        private List<Item> itemList;
        public Form1()
        {
            InitializeComponent();
            itemList = new List<Item>();
            List<Item> dataList = new List<Item>
            {
                new Item(1,"紅茶", 120),
                new Item(2,"奶茶", 150),
                new Item(3,"咖啡", 120),
            };

            ItemsList.DataSource = dataList;
            ItemsList.DisplayMember = "Name";
        }

        private void AddSellItemButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = ItemsList.SelectedItem as Item;
            if (selectedItem != null)
            {
                Item item = new Item(selectedItem.Id, selectedItem.Name, selectedItem.Price);
                if (itemList.Count <= 0) 
                {
                    item.Uid = 1;
                } else
                {
                    item.Uid = itemList.Last().Uid+1;
                }
                ItemsList.SelectedItem = null;
                itemList.Add(item);
                UpdateItemSellList();
            }
        }

        private void UpdateItemSellList()
        {
            decimal total=0;
            ItemSellList.Clear();
            for (int index = 0; index < itemList.Count; index++)
            {
                ItemSellList.Items.Add($"{itemList[index].Uid}, {itemList[index].Name}, ${itemList[index].Price}");
                total = total + itemList[index].Price;
            }
            displayTotal.Text = $"此訂單總價: {total}";
        }

        private void DelSellItemButton_Click(object sender, EventArgs e)
        {
            if(ItemSellList.SelectedItems.Count > 0)
            {
                int itemIndex = ItemSellList.SelectedIndices[0];
                Console.WriteLine(itemIndex);
                itemList.RemoveAt(itemIndex);
                UpdateItemSellList();
            }
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
