using System;


class MainProgram
{
    static void Main()
    {
        Laptop laptop1 = new Laptop("Toshiba Satellite L850-13R", 200);
        Console.WriteLine(laptop1.ToString());
        Laptop laptop2 = new Laptop("Lenovo Yoga 2 Pro", 2259.00, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "128GB SSD", "Intel HD Graphics 4400", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", "Li-Ion, 4-cells, 2550 mAh","4.5 hours");
        Console.WriteLine(laptop2.ToString());
    }

}