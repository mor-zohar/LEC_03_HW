// See https://aka.ms/new-console-template for more information

Console.WriteLine("---------- LEC_03_HW ----------\n");

// a)
Console.WriteLine("---------- A ----------");
Console.WriteLine("Enter Model Year:");
int carYear = int.Parse(Console.ReadLine());
Console.WriteLine("-----------------------");

// b)
Console.WriteLine("---------- B ----------");
Console.WriteLine("Enter car km:");
double carKm = double.Parse(Console.ReadLine());

Console.WriteLine("Your Car Year Is: {0}",carYear);
Console.WriteLine("Your Car KM Is: {0}\n", carKm);
Console.WriteLine("-----------------------");


// c)
Console.WriteLine("---------- C ----------");
bool isNewCar = (carYear > 2016) || (carKm < 185000);
Console.WriteLine("The Car Is New: {0}\n",isNewCar);
Console.WriteLine("-----------------------");


// d)
Console.WriteLine("---------- D ----------");
bool isOldCar = (carYear < 2016) && (carKm > 185000);
Console.WriteLine("The Car Is Old: {0}\n", isOldCar);
Console.WriteLine("-----------------------");


// e)
Console.WriteLine("---------- E ----------");
bool isOldCar2 = (carYear > 2016) || (carKm < 185000);
Console.WriteLine("The Car Is Old: {0}\n", !(isOldCar2));
Console.WriteLine("-----------------------");





