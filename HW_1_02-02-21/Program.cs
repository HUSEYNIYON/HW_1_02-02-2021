using System;

namespace HW_1_02_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid id = Guid.NewGuid();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Tel: ");
            string tel = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            DushanbeStores stores = new DushanbeStores(id,name,address,city,tel,email);
            stores.GetInfoStore();
        }
    }
    class DushanbeStores
    {
        public Guid stores_id { get;set; }
        public string stores_name { get; set; }
        public string stores_address { get; set; }
        public string stores_city { get; set; }
        public string stores_tel { get; set; }
        public string stores_email { get; set; }
        public DushanbeStores(Guid id, string name, string address, string city, string tel, string email)
        {
            stores_id = id;
            stores_name = name;
            stores_address = address;
            stores_city = city;
            stores_tel = tel;
            stores_email = email;
        }
        public void GetInfoStore()
        {
            Console.WriteLine($"Id: {stores_id}\nName:{stores_name}\nAddress:{stores_address}" +
                $"\nCity:{stores_city}\nTel:{stores_tel}\nEmail:{stores_email}\n");
        }
    }
}
