using Design_Highlands.components;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using Design_Highlands.models;
using ComponentFactory.Krypton.Toolkit;
using Design_Highlands.views;
using Design_Highlands.views.dialogs;

namespace Design_Highlands
{
    internal partial class OrderScreen : Form
    {
        Staff staff;
        List<String> typeDrinks;
        public FlowLayoutPanel billPanel;
        public OrderScreen()
        {
            InitializeComponent();
            typeDrinks = new List<String>();
        }

        public OrderScreen(FlowLayoutPanel billPanel)
        {
            InitializeComponent();
            typeDrinks = new List<String>();
            this.billPanel = billPanel; 
        }

        public OrderScreen(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            typeDrinks = new List<String>();
        }

        // Event handlers
        private void backToHome()
        {
            this.Hide();
            Home home = new Home(this.staff);
            home.ShowDialog();
        }

        private List<Drink> getDrinks()
        {
            List<Drink> drinks = new List<Drink>();
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("drinks");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Drink drink = BsonSerializer.Deserialize<Drink>(result);
                if (!typeDrinks.Contains(drink.Type))
                {
                    typeDrinks.Add(drink.Type);

                }
                drinks.Add(drink);
            }

            return drinks;
        }

        private List<Drink> getCoffees()
        {
            List<Drink> drinks = new List<Drink>();
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("drinks");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Drink drink = BsonSerializer.Deserialize<Drink>(result);
                if (drink.Type.Equals("coffee"))
                {
                    drinks.Add(drink);
                }
            }

            return drinks;
        }

        private List<Food> getFoods()
        {
            List<Food> foods = new List<Food>();
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("foods");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Food food = BsonSerializer.Deserialize<Food>(result);
                foods.Add(food);
            }
            return foods;
        }

        private void loadBills()
        {
            flp_bill.Controls.Clear();
            if (billPanel != null)
            {
                foreach(Control control in billPanel.Controls)
                {
                    flp_bill.Controls.Add(control);
                }
            }
        }
        private void loadCoffees()
        {
            // Get all coffees from db
            List<Drink> drinks = getCoffees();
            flp_type.Controls.Clear();


            foreach (Drink drink in drinks)
            {
                DrinkWidget widget = new DrinkWidget(drink, flp_bill, tbt_total);
                flp_menu.Controls.Add(widget);
            }
        }
        private void loadDrinks()
        {
            // Get all drinks from db
            List<Drink> drinks = getDrinks();
            flp_type.Controls.Clear();
            //123
            foreach (Drink drink in drinks)
            {
                DrinkWidget widget = new DrinkWidget(drink, flp_bill, tbt_total);
                flp_menu.Controls.Add(widget);
            }

            foreach (String type in typeDrinks)
            {
                addNewBtnType(type);
            }
        }

        private void loadDrinksOfType(String type)
        {
            flp_menu.Controls.Clear();
            // Get all drinks from db
            List<Drink> drinks = getDrinks();

            foreach (Drink drink in drinks)
            {
                if (drink.Type == type)
                {
                    DrinkWidget widget = new DrinkWidget(drink, flp_bill, tbt_total);
                    flp_menu.Controls.Add(widget);
                }
            }
        }
        private void loadFoods()
        {
            // Get all foods from db
            List<Food> foods = getFoods();
            flp_type.Controls.Clear();


            foreach (Food food in foods)
            {
                FoodWidget widget = new FoodWidget(food, flp_bill, tbt_total);
                flp_menu.Controls.Add(widget);
            }
        }

        private void showPayment()
        {
            this.Hide();
            Payment paymentView = new Payment(this.staff, flp_bill, tbt_total);
            paymentView.Show();
        }

        private void showCheckPointDialog()
        {
            //this.Hide();
            CheckPoint checkPointDialog = new CheckPoint(staff, flp_bill, tbt_total);
            checkPointDialog.ShowDialog();
            this.Hide();
        }

        // Events
        private void lb_back_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void addNewBtnType(String type)
        {
            KryptonButton btn = new KryptonButton
            {
                Text = type,
                Size = new Size(100, 60),
                //Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            btn.Click += (sender, e) => {
                loadDrinksOfType(type);
            };
            flp_type.Controls.Add(btn);
        }

        private void btn_drink_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadDrinks();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadDrinks();
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            loadDrinks();
            loadBills();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadFoods();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadFoods();
        }

        private void btn_coffee_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadCoffees();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadCoffees();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {

            showCheckPointDialog();
        }

        private void btn_topping_Click(object sender, EventArgs e)
        {

        }
    }
}
