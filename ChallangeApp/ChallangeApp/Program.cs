
using System.Diagnostics.Metrics;

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] counter = new int[10];
counter[0] = 0;
counter[1] = 0;
counter[2] = 0;
counter[3] = 0;
counter[4] = 0;
counter[5] = 0;
counter[6] = 0;
counter[7] = 0;
counter[8] = 0;
counter[9] = 0;


foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter[0]++;
    }
    else if (letter == '1')
    {
        counter[1]++;
    }
    else if (letter == '2')
    {
        counter[2]++;
    }
    else if (letter == '3')
    {
        counter[3]++;
    }
    else if (letter == '4')
    {
        counter[4]++;
    }
    else if (letter == '5')
    {
        counter[5]++;
    }
    else if (letter == '6')
    {
        counter[6]++;
    }
    else if (letter == '7')
    {
        counter[7]++;
    }
    else if (letter == '8')
    {
        counter[8]++;
    }
    else
    {
        counter[9]++;
    }
}

for (int i =0; i<10; i++)
    {

    Console.WriteLine(i + "=>" + counter[i]);
    }