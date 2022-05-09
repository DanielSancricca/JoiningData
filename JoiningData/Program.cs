namespace JoiningData
{
    public class Program
    {
        
        public static void Main()
        {
            List<CustomerOrder> orders = new List<CustomerOrder>();

            CustomerOrder a = new CustomerOrder("Acme Hardware", "Mouse", 25, 3);
            CustomerOrder b = new CustomerOrder("Acme Hardware", "Keyboard", 45, 2);
            CustomerOrder c = new CustomerOrder("Falls Realty", "Macbook", 800, 2);
            CustomerOrder d = new CustomerOrder("Julie's Morning Diner", "iPad", 525, 1);
            CustomerOrder e = new CustomerOrder("Julie's Morning Diner", "Credit Card Reader", 45, 1);

            orders.Add(a);
            orders.Add(b);
            orders.Add(c);
            orders.Add(d);
            orders.Add(e);
            orders.ToArray();


            foreach (CustomerOrder order in orders)
            {
                Console.WriteLine(order.CustomerName);
                Console.WriteLine($"Item        Price       Quantity        ");
                Console.WriteLine($"{order.Item}        {order.Price}         {order.Quantity}");
                Console.WriteLine();
            }

        }   
    }
}
