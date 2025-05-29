using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private int _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, int id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    

    public decimal TotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductInformation()
    {
        return $"\nProduct: {_name}\nID: {_id},\nPrice: ${_price}\nQuantity: {_quantity}\nTotal: ${TotalCost()}\n";
    }
}
