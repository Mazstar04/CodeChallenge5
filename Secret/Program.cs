// See https://aka.ms/new-console-template for more information
Console.WriteLine(Secret(6, 2, 4));

static int Secret(int n, int delay, int forget)
{
    var Keepers = new List<string>();
    for (int i = 0; i < n; i++)
    {
        if (i == 0) Keepers.Add(i.ToString());
        int counter = Keepers.Count();
        for (int j = 0; j < counter; j++)
        {
            if (Keepers[j] != "expired")
            {
                if (int.Parse(Keepers[j]) + i + 1 > forget)
                {
                    Keepers[j] = "expired";
                }
                else if (int.Parse(Keepers[j]) + i + 1 > delay)
                {
                    Keepers.Add((-i).ToString());

                }
            }
        }
    }
    return Keepers.Where(a => a != "expired").Count();
}
