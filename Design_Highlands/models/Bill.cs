using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Highlands.models
{
    internal class Bill
    {
        private string id;
        private string employee_name;
        private string customer_name;
        private DateTime order_date;
        private ItemDetail[] items;
        private int total_amount;
        private string payment_method;
        private string delivery;
        private string order_id;

        public Bill(string id, 
            string employee_name, 
            string customer_name, 
            DateTime order_date, 
            ItemDetail[] items, 
            int total_amount, 
            string payment_method, 
            string delivery,
            string order_id
        ) { 
            this.employee_name = employee_name;
            this.customer_name = customer_name;
            this.order_date = order_date;
            this.items = items;
            this.total_amount = total_amount;
            this.payment_method = payment_method;
            this.delivery = delivery;
            this.order_id = order_id;
         
        }


        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get { return this.id; } set { this.id = value; } }
        public string Employee_name { get { return this.employee_name; } set { this.employee_name = value; } }
        public string Customer_name { get { return this.customer_name; } set { this.customer_name = value; } }
        public DateTime Order_date { get { return this.order_date; } set { this.order_date = value; } }
        public ItemDetail[] Items { get { return this.items; } set { this.items = value; } }
        public int Total_amount { get { return this.total_amount; } set { this.total_amount = value; } }
        public string Delivery { get { return this.delivery; } set { this.delivery = value; } }
        public string Order_id { get { return this.order_id; } set { this.order_id = value; } }
    }
}
