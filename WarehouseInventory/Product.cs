namespace WarehouseInventory;

public class Product
{
  public string Name { get; set; }
  public int StockValue { get; set; }
  public int MinimumStockValue { get; set; }

  public Product(string name, int stock, int minimumStock)
  {
    Name = name;
    StockValue = stock;
    MinimumStockValue = minimumStock;
  }
}