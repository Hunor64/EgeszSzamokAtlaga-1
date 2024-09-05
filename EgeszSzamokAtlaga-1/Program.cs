List<int> szamok = new();
while (true)
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
Console.WriteLine(osszes);
Console.WriteLine(szamok.Count());
Console.WriteLine(Math.Round(osszes*1.0/szamok.Count(),2));