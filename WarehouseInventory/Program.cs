// A warehouse has several products with different stock levels.

// Input:
// Number of products
// Product name
// Current stock quantity
// Minimum required stock level

// Task:
// Write a program that lists all products that need to be reordered because their stock level is below the minimum required level.

// Example input:

// Number of products: 4

// Product: Screws
// Stock: 15
// Minimum: 10

// Product: Nuts
// Stock: 3
// Minimum: 8

// Product: Bolts
// Stock: 20
// Minimum: 15

// Product: Washers
// Stock: 5
// Minimum: 5

// Expected output:

// Products that need to be reordered:
// Nuts

using WarehouseInventory;

var products1 = new List<Product>{
  new Product(name: "Skruv", stock: 15, minimumStock: 10),
  new Product(name: "Mutter", stock: 3, minimumStock: 8),
  new Product(name: "Bult", stock: 20, minimumStock: 15),
  new Product(name: "Bricka", stock: 5, minimumStock: 5)
};

var products2 = new List<Product>{
  new Product(name: "Penna", stock: 12, minimumStock: 10),
  new Product(name: "Miniräknare", stock: 5, minimumStock: 8),
  new Product(name: "Skrivhäfte", stock: 8, minimumStock: 15),
  new Product(name: "Linjal", stock: 9, minimumStock: 5),
  new Product(name: "Suddgummin", stock: 50, minimumStock: 35),
  new Product(name: "Häftapparat", stock: 2, minimumStock: 8),
};

void ProductInventory(int numberOfProducts, List<Product> products)
{
  var stockProducts = new List<string>();

  foreach (Product product in products)
  {
    if (product.StockValue < product.MinimumStockValue)
    {
      stockProducts.Add(product.Name);
    }
  }

  Console.WriteLine($"Nummer av produkter: {numberOfProducts}");
  if (stockProducts.Count > 0)
  {
    foreach (string name in stockProducts)
    {
      Console.WriteLine(name);
    }
  }
  else
  {
    Console.WriteLine("Inga produkter behöver beställas!");
  }
}

ProductInventory(products1.Count, products1);
Console.WriteLine("--------------------------------");
ProductInventory(products2.Count, products2);