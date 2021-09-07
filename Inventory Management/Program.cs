using System;

namespace Inventory_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch batch = new Batch(" ");
            int inputMenu = MenuOptions.EMPTY;
            while (inputMenu != MenuOptions.EXIT_PROGRAM)
            {
                Console.Clear();
                IO.PrintMenu();
                inputMenu = IO.EnterMenuOption();
                switch (inputMenu)
                {
                    case MenuOptions.ADD_PRODUCT_INFOR:
                        Console.WriteLine("--------------------------------------------");
                        Console.Write("Enter number of product : ");
                        int number = int.Parse(Console.ReadLine());
                        for (int j = 0; j < number; j++)
                        {
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine(">> Product number {0}", j + 1);
                            batch.AddProduct
                            (
                                 IO.EnterProductCode(),
                                 IO.EnterProductName(),
                                 IO.EnterProductType(),
                                 IO.EnterAmount(),
                                 IO.EnterConditionOfProduct(),
                                 IO.EnterPrice()
                            );
                            IO.ShowMessage(true);
                        }
                        break;

                    case MenuOptions.REMOVE_PRODUCT_BY_CODE:
                        IO.ShowMessageRemove(batch.RemoveProductByCode(IO.RemoveProductByCode()));
                        Console.ReadLine();
                        break;

                    case MenuOptions.UPDATE_PRODUCT_BY_CODE:
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

                    case MenuOptions.PRINT_ALL_PRODUCT_INFOR:
                        IO.ToScreen(batch.GetAllProductInfor());
                        Console.ReadKey();
                        break;

                    case MenuOptions.PRINT_PRODUCT_INFOR_BY_CODE:
                        IO.ToScreen(batch.GetProductByCode(IO.ViewProductByCode()).ToString());
                        Console.ReadKey();
                        break;

                    case MenuOptions.PRINT_PRODUCT_INFOR_BY_PRICE:
                        IO.ToScreen(batch.GetProductByPrice(IO.ViewProductByPrice()).ToString());
                        Console.ReadKey();
                        break;

                    case MenuOptions.EXIT_PROGRAM:
                        IO.ShowMessageExit();
                        Console.ReadLine();
                        return;

                    default:
                        IO.InputError();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}