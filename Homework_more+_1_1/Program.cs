Console.WriteLine("Input number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input number b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Input number c");
int c = int.Parse(Console.ReadLine());
Console.WriteLine(nsd_three(a, b, c));

static int nsd(int a, int b)
{
    int x;
	if (b == 0)
	{
		return Math.Abs(a);
	}
	return nsd(b, a % b);
}

static	int nsd_three(int a, int b, int c)
{
	int for_two = nsd(a, b);
	int for_three = nsd(for_two, c);
	return for_three;
}

