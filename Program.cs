int liczbaTur;
while(true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");
    bool poprawnyFormat = int.TryParse(Console.ReadLine(), out liczbaTur);
    
    if (!poprawnyFormat)
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    if (liczbaTur < 1)
    {
        Console.WriteLine("Liczba musi być większa od 0");
        continue;
    }
    else if(liczbaTur > 10)
    {
        Console.WriteLine("Liczba musi być mniejsza od 11");
        continue;
    }
    
    Console.WriteLine("Poprawna wartość!");
    break;
}

Console.WriteLine($"Wybrano {liczbaTur} tur.");