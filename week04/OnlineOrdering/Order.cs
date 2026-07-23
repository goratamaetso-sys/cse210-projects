using System;
using System.Collections.Generic;

public class Order
{
   private Customer _customers;
   private List<Product>_products;

   public Order(Customer customer, List<Product> products)
    {
        _customers = customer;
        _products = products;
    
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0m;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        decimal shipping = _customers.livesInUSA() ? 5m : 35m;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()}-({product.GetProductId()})";
        }

        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"{_customers.GetName()}:{_customers.GetAddress()}";
    } 
}