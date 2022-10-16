﻿using _04.Telephony;

var numbers = Console.ReadLine().Split();
var urls = Console.ReadLine().Split();

var phone = new Smartphone();
foreach (var number in numbers)
{
    Console.WriteLine(phone.Call(number));
}

foreach (var url in urls)
{
    Console.WriteLine(phone.Browse(url));
}