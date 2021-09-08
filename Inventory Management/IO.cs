using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
	class IO
	{
		public static void PrintMenu()
		{
			Console.WriteLine("\t\t\t\tINVENTORY MANAGEMENT SYSTEM");
		}

		public static int EnterMenuOption()
		{
			Console.WriteLine("------------------------------------------------------------------------------");
			Console.WriteLine("\t\t\t 1. Add new product to inventory");
			Console.WriteLine("\t\t\t 2. Remove product by code");
			Console.WriteLine("\t\t\t 3. Update product by code");
			Console.WriteLine("\t\t\t 4. View all product information");
			Console.WriteLine("\t\t\t 5. View product information by code");
			Console.WriteLine("\t\t\t 6. View product information by price");
			Console.WriteLine("\t\t\t 7. View product information by type");
			Console.WriteLine("\t\t\t 8. Exit Application");
			Console.WriteLine("------------------------------------------------------------------------------");
			Console.Write("Enter your choice : ");
			return int.Parse(Console.ReadLine());
		}

		public static string EnterStringValue()
		{
			return Console.ReadLine();
		}

		public static int EnterProductCode()
		{
			int pCode;
			inputAgain:
			Console.Write("Product Code         : ");
			pCode = int.Parse(Console.ReadLine());
			Product result = Batch._product.Find(x => x.ProductCode == pCode);
            if (result != null)
			{
				Console.WriteLine(">> Product Code is already exists, please try again! <<");
				goto inputAgain;
			}
			return pCode;
		}

		public static int RemoveProductByCode()
        {
			Console.Write("Product Code         : ");
			return int.Parse(Console.ReadLine());
		}

		public static string EnterProductName()
		{  
			Console.Write("Product Name         : ");
			return Console.ReadLine();
		}

		public static string EnterProductType()
		{
			Console.Write("Product Type         : ");
			return Console.ReadLine();
		}

		public static int EnterAmount()
		{
			Console.Write("Amount               : ");
			return int.Parse(Console.ReadLine());
		}

		public static string EnterConditionOfProduct()
		{
			Console.Write("Condition Of Product : ");
			return Console.ReadLine();
		}

		public static double EnterPrice()
		{
			Console.Write("Price/1 (USD)        : ");
			return double.Parse(Console.ReadLine());
		}

		public static int NewProductCode()
		{
			Console.WriteLine("--------------------------------------------");
			Console.Write("Product Code        : ");
			return int.Parse(Console.ReadLine());
		}

		public static int ViewProductByCode()
		{
			Console.WriteLine("--------------------------------------------");
			Console.Write("Product Code        : ");
			return int.Parse(Console.ReadLine());
		}

		public static double ViewProductByPrice()
		{
			Console.WriteLine("--------------------------------------------");
			Console.Write("Price/1 (USD)        : ");
			return double.Parse(Console.ReadLine());
		}

		public static int EnterIntValue()
		{
			return int.Parse(Console.ReadLine());
		}

		public static void ToScreen(string str)
		{
			Console.WriteLine(str);
		}

		public static void ShowMessage(bool status)
		{
			if (status)
			{
				Console.WriteLine("--------------------------------------------");
				Console.WriteLine(">> This product has been stored in stock <<");
				Console.ReadKey();
			}

			else
			{
				Console.WriteLine("--------------------------------------------");
				Console.WriteLine("WARNING!");
				Console.WriteLine(">> You have a problem filling out the information, please try again <<");
			}
		}

		public static void ShowMessageRemove(bool status)
        {
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(">> This product has been removed out of stock <<");
		}

		public static void ShowMessageUpdate(bool status)
		{
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(">> This product has been updated to stock <<");
		}

		public static void ShowMessageExit()
        {
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(">> Inventory Program Ended <<");
		}

		public static void ShowMessageError()
		{
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("WARNING!");
			Console.WriteLine(">> You can only choose one of the 6 options in the menu, please try again <<");
		}
	}
}

