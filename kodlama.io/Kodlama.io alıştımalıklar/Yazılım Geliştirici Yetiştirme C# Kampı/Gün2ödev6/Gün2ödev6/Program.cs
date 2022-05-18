using System;

class Program
{
    static void Main(string[] args)
    {

        Product product = new Product();
        product.Name = "Sherlock Holmes";
        product.Price = 230;
        product.isAvaible = true;

        Product product1 = new Product();
        product1.Name = "Sapıens";
        product1.Price = 70;
        product1.isAvaible = false;

        Product product2 = new Product();
        product2.Name = "Göl Çocukları";
        product2.Price = 130;
        product2.isAvaible = true;

        Product product3 = new Product();
        product3.Name = "Stranç";
        product3.Price = 160;
        product3.isAvaible = true;

        Product[] products = new Product[] { product, product1, product2, product3 };

        Console.WriteLine("FOREACH DÖNGÜSÜ İLE");
        foreach (Product item in products)
        {
            Console.WriteLine("Kitap ADI : " + item.Name + " / " + " Kitap FİYATI : " + item.Price + " / " + " Stok DURUMU : " + item.isAvaible);
        }

        Console.WriteLine("FOR DÖNGÜSÜ İLE");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine("Kitap ADI : " + products[i].Name + " / " + " Kitap FİYATI : " + " " + products[i].Price + " / " + " Stok DURUMU : " + " " + products[i].isAvaible);
        }

        Console.WriteLine("WHİLE DÖNGÜSÜ İLE");
        int x = 0;
        while (x < products.Length)
        {
            Console.WriteLine("Kitap ADI : " + products[x].Name +" / "+ " Kitap FİYATI : "  + products[x].Price + " / " + " Stok DURUMU : " + " " + products[x].isAvaible);
            x++;
        }
    }
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public bool isAvaible { get; set; }
}





