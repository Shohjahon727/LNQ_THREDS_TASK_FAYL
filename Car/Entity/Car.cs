using ClassCar.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Entity;

public class Car
{
    public CarType Name { get; set; }   
    public ColorType Color { get; set; }
    public DateTime Created { get; set; }
    public decimal Price { get; set; }
    public int Power { get; set; }
    
    public Car () { }

    public CarType(CarType name, ColorType, DateTime created, decimal price, int power)
    {
        Name = name;
        Created=created;
        Price = price;
        Power = power;
    }

}