using System;
using System.Collections.Generic;
using System.Reflection.Emit;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal OrderTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }


    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.GetProductInformation();
        }

        return label;
    }

    public string GetShippingLabel()
    {
       return _customer.GetNameAddress();
    }
}