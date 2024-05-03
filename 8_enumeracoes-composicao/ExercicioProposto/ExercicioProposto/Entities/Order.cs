using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using ExercicioProposto.Entities.Enums;

namespace ExercicioProposto.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in OrderItems) {

                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Order moment: ");
            builder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.Append("Order status: ");
            builder.AppendLine(Status.ToString());

            builder.AppendLine(Client.ToString());

            builder.AppendLine("Order Items: ");

            foreach (OrderItem item in OrderItems)
            {
                builder.AppendLine(item.ToString());
            }

            builder.Append("Total Price: $");
            builder.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return builder.ToString();
        }
    }
}
