using System;
using System.Collections.Generic;

class InventoryItem
{
  public string Name { get; set; }
  public string PurchaseDate { get; set;}
  public string ExpirationDate { get; set;}
  public int Quantity { get; set; 
  }
  }
class Program
//look at this area
{
  static List<InventoryItem> inventory = new List<InventoryItem>();

  static void DisplayMenu()
  {
    Console.WriteLine("\nMenu:");
    Console.WriteLine("Add Item");
    Console.WriteLine("Remove Item");
    Console.WriteLine
    Console.WriteLine("View Inventory");
    Console.WriteLine("Exit");

    Console.WriteLine("\nChoose an option:");

    //Display buttons
    Console.WriteLine("[A]dd Item [R]emove Item [V]iew Inventory E[x]it");
    
  }

  static void AddItem()
  {
    Console.Write("Enter name of item: ");
    string name = Console.ReadLine();
    Console.Write("Enter date of purchase: ");
    string purchaseDate = Console.ReadLine();
    Console.Write("Enter expiration date: ");
     Console.Write("Enter the quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    InventoryItem item = new InventoryItem
    {
      Name = name,
      PurchaseDate = purchaseDate,
      ExpirationDate = expirationDate,
      Quantity =  quantity
    };

    inventory.Add(item);
    Console.WriteLine("Item added sucessfully!");
    
  }
    static void RemoveItem()
  {
    if (inventory.Count == 0)
    {
      Console.WriteLine("Inventory is empty. Cannot remove items.");
      return;
      }
//fix this area
    Console.WriteLine("Current Inventory: ");
    for (int i = 0
    {
      Console.WriteLine($"{i + 1"}. {inventory[i].Name}");
    }
      Console.Write("Enter the number of the item to remove: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice >= 1 && choice <= inventory.Count)
  {
    InventoryItem removedItem = inventory[choice - 1];
    inventory.RemoveAt(choice - 1);
    Console.WriteLine($"{removeItem.Name} remove from inventory.");
  }
  else
  {
      Console.WriteLine("Invalid choice. Please enter a valid item number.");
  }
  static void ViewInventory()
{
    if (inventory.Count == 0)
    {
        Console.WriteLine("Inventory is empty.");
        return;
     }

    Console.WriteLine("\nInventory:");
    for (int i = 0; i < inventory.Count; i++)
      {
          Console.WriteLine($"{i + 1}. Name {inventory[i].Name}, Purchase Date: {inventory[i].PurchaseDate}, Expiration Date: {inventory[i].ExpirationDate}, Quantity: {inventory[i].Quantity}");
       }
}
    static void Main()

{
  while (true)
    {
    //want to change this method
    DisplayMenu();
    ConsoleKeyInfo key = Console.ReadKey();

    switch (char.ToUpper(key.KeyChar());
      {
          case 'A':
            AddItem();
            break;
          case'R':
            RemoveItem();
            break;
            case 'V':
          ViewInventory();
            break;
            case 'X':
            Console.WriteLine("\nExiting the menu. Goodbye!");
            return;
            default:
              Console.WriteLine("n\Invalid choice. Please enter a number between 1 and 4.");
              
  
    
      }
    }
  }
}

