namespace product_class
{




    internal class Program
    {
        static void Main(string[] args)
        {
           Product productOne = new Product();
            Product productTwo= new Product();
            Product productThree = new Product();




            productOne.Id = 1;
            productTwo.Id = 2;
            productThree.Id = 3;

            productOne.Name = "Apple";
            productTwo.Name = " Orange";
            productThree.Name = "banana";


            productOne.Description = "Description 1";
            productTwo.Description = "Description 2 ";
            productThree.Description = "Description 3 ";



            productOne.Price = 10.5;
            productTwo.Price = 8;
            productThree.Price = 5.6;


            productOne.print();
            productTwo.print();
            productThree.print();

        }
    }
}