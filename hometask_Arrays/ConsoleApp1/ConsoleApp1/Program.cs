//int number = 10;
//int[] numbers = { 200, 100, 300 };


//for (int i = 0; i < numbers.Length ; i++)
//{
//    Console.WriteLine(numbers[i]);
//}



// 1. arraydeki ededlerin cemini tapmaq
//int[] numbers = new int[5];

//for (int i = 0; i< numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = 0; j < numbers.Length; j++)
//{
//    Console.WriteLine(numbers[j] + " ");
//}









//2. cem
//int[] numbers = new int[5];
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = 0; j < numbers.Length; j++)
//{
//    sum = sum + numbers[j];
//}

//Console.WriteLine("cem=" + sum);










//3. tersine print
//int[] numbers = new int[5];


//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = numbers.Length - 1; j >= 0; j--)
//{
//    Console.Write(numbers[j] + " ");
//}











//4.reverse array

//int[] numbers = new int[5];

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//// reverse
//for (int j = 0; j < numbers.Length / 2; j++)
//{
//    int temp = numbers[j];
//    numbers[j] = numbers[numbers.Length - 1 - j];
//    numbers[numbers.Length - 1 - j] = temp;
//}

//for (int k = 0; k < numbers.Length; k++)
//{
//    Console.Write(numbers[k] + " ");
//}








//5. en boyuk


//int[] numbers = new int[5];
//int max = numbers[0];

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = 1; j < numbers.Length; j++)
//{
//    while (numbers[j] > max)
//    {
//        max = numbers[j];
//    }
//}
//Console.WriteLine(max);







//6. ededlerin sayini tapmaq

//int[] numbers = new int[5];
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for(int j = 0; j < numbers.Length; j++)
//{
//    count += 1;
//}

//Console.WriteLine(count);







//7.arrayi sort etmek

//int[] numbers = new int[5];
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//// Bubble sort implementation 
//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    for (int j = 0; j < numbers.Length - i - 1; j++)
//    {
//        if (numbers[j] > numbers[j + 1])
//        {
//            int temp = numbers[j];
//            numbers[j] = numbers[j + 1];
//            numbers[j + 1] = temp;
//        }
//    }
//}

////print sorted array
//Console.WriteLine("Sorted array:");
//for (int k = 0; k < numbers.Length; k++)
//{
//    Console.Write(numbers[k] + " ");
//}







//8. 0 ededinnen nece defe islendiyini tapmaq

//int[] numbers = new int[5];
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = 0;  j < numbers.Length; j++)
//{
//    if (numbers[j] == 0)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);











//9. arraydaki menfi ededler say


//int[] numbers = new int[5];
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = 0; j < numbers.Length; j++)
//{
//    if (numbers[j] < 0)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);








//10. musbet ededlerin cemi

//int[] numbers = new int[5];
//int max = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = 0; j < numbers.Length; j++)
//{
//    if (numbers[j] > 0)
//    {
//        max += numbers[j];
//    }
//}

//Console.WriteLine(max);














//11.arraydaki ededleri ozlerinin kvadratina cevir

//int[] numbers = new int[5];
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = 0; j < numbers.Length; j++)
//{
//    numbers[j] = numbers[j] * numbers[j];
//}

//Console.WriteLine("squared vers:");
//for (int k = 0; k < numbers.Length; k++)
//{
//    Console.Write(numbers[k] + " ");
//}












//12.  sort coxdan aza
//int[] numbers = new int[5];
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("enter number {0}: ", i + 1);
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//// Bubble sort implementation 
//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    for (int j = 0; j < numbers.Length - i - 1; j++)
//    {
//        if (numbers[j] < numbers[j + 1])
//        {
//            int temp = numbers[j];
//            numbers[j] = numbers[j + 1];
//            numbers[j + 1] = temp;
//        }
//    }
//}

////print sorted array
//Console.WriteLine("Sorted array:");
//for (int k = 0; k < numbers.Length; k++)
//{
//    Console.Write(numbers[k] + " ");
//}
