using System;

namespace Inventory_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch batch = new Batch("");
            int inputMenu = 0;
            while (inputMenu != MenuOptions.EXIT_PROGRAM)
            {
                Console.Clear();
                IO.PrintMenu();
                inputMenu = IO.EnterMenuOption();
                switch (inputMenu)
                {
                    case 1:
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        Console.Write("Enter number of product : ");
                        int number = int.Parse(Console.ReadLine());
                        for (int j = 0; j < number; j++)
                        {
                            Console.WriteLine("-----------------------------------------------------------------------------------");
                            Console.WriteLine(">> Product number {0}", j + 1);
                            Product product = new Product
                            (
                               IO.EnterAndCheckProductCode(batch),
                               IO.EnterProductName(),
                               IO.EnterProductType(),
                               IO.EnterAmount(),
                               IO.EnterConditionOfProduct(),
                               IO.EnterPrice()
                            );
                            batch.AddProduct(product);
                            IO.ShowMessage(true);
                        }
                        break;

                    case 2:
                        IO.ShowMessageRemove(batch.RemoveProductByCode(IO.RemoveProductByCode()));
                        Console.ReadLine();
                        break;

                    case 3:
                        IO.ShowMessageUpdate
                           (
                             batch.UpdateProductByCode
                               (
                                  IO.NewProductCode(),
                                  IO.EnterProductName(),
                                  IO.EnterProductType(),
                                  IO.EnterAmount(),
                                  IO.EnterConditionOfProduct(),
                                  IO.EnterPrice()
                               )
                           );
                        Console.ReadKey();
                        break;

                    case 4:
                        IO.ToScreen(batch.GetAllProductInfor());
                        Console.ReadKey();
                        break;

                    case 5:
                        IO.ToScreen(batch.GetProductByCode(IO.ViewProductByCode()).ToString());
                        Console.ReadKey();
                        break;

                    case 6:
                        IO.ToScreen(batch.GetProductByPriceRange(IO.ViewProductByPrice()));
                        Console.ReadKey();
                        break;

                    case 7:
                        IO.ShowMessageExit();
                        Console.ReadLine();
                        return;

                    default:
                        IO.ShowMessageError();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}