var name = ("Ewa");
var gender = ("female");
var age = 33;

if (gender == "female" && age > 30)
{

    Console.WriteLine("Kobieta powyżej 30 lat");

}

else if (gender == "female" && age < 30)
{

    Console.WriteLine("kobieta poniżej 30 lat");

}

else
{
    Console.WriteLine("Nie jest to kobieta");
}

// 2 -----------------------------------
if (name == "Ewa" && age == 33)
{

    Console.WriteLine("Ewa, lat 33");

}

else
{

    Console.WriteLine("Nie jest to 33 letnia Ewa");

}

// 3 --------------------------------------
if (age > 18 && gender == "female")
{

    Console.WriteLine("Pełnoletnia Kobieta");

}

else
{

    Console.WriteLine("Niepełnoletnia Kobieta");

}