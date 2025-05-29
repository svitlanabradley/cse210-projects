using System;
using System.Collections.Generic;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    public string GetNameAddress()
    {
        return $"{_customerName}\n{_address.GetAddress()}";
    }
}