using System;

public class Product
{
    private string _name;
    private string _productId;
    private int _quantity;
    private decimal _price;

    public Product(string name, string productId, int quantity, decimal price)
    {
        _name = name;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    public decimal GetTotalCost()
    {
        return _quantity * _price;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

}