List<int> szamok = new();
int szama = int.Parse(Console.ReadLine());

for (int i = 0; i < szama; i++)
{
    string szoveg = Console.ReadLine();
    if (szoveg != "")
    {
        try
        {
            szamok.Add(Convert.ToInt32(szoveg));
        }
        catch (Exception)
        {

        }
    }
    else
    {
        break;
    }
}
int osszes = 0;
foreach (var item in szamok)
{
    osszes = osszes + item;
}
string eredmeny = Math.Round(osszes * 1.0 / szamok.Count(), 2).ToString();
try
{
    if (eredmeny.Split('.')[1].Length == 1)
    {
        eredmeny = eredmeny + "0";
    }

}
catch (Exception)
{
    eredmeny = eredmeny + ".00";
    throw;
}

Console.WriteLine(eredmeny);