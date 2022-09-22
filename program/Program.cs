string[] GetStrings()
{
    Console.WriteLine("Введите несколько строк через запятую (Just,Johnny):");
    string value = Convert.ToString(Console.ReadLine());
    string[] temp = value.Split(',');

    return temp;
}

string[] ArraySo3CH( string[] value)
{
    int count = 0;
    for (int i = 0; i < value.Length; i++) 
    {
        if (value[i].Length <= 3) 
        {
            count = count + 1;
        }
    }
    
    if (count > 0) 
    {
        string[] temp = new string[count];

        for (int i = 0; i < value.Length; i++) 
    {
        if (value[i].Length <= 3) 
        {
            temp[i] = value[i];
        }
    }

        return temp;
    } 
    else 
    {
        string[] temp = new string[] {""};
        System.Console.WriteLine("Все строки в массиве имеют более 3-х символов.");

        return temp;
        
    }
}

void WriteArray(string[] value)
{
    int count = 0;
    while(count < value.Length)
    {
        System.Console.Write($"{value[count]} ");
        count = count + 1;
    }
    System.Console.WriteLine("");
}



WriteArray(ArraySo3CH(GetStrings()));