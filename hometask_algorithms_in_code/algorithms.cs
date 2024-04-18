
//TASKS

//0. ededin menfi musbet
//Console.WriteLine("eded daxil et: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num > 0)
//{
//    Console.WriteLine("eded musbetdir");
//}
//else if (num == 0)
//{
//    Console.WriteLine("eded sifirdir");
//}
//else
//{
//    Console.WriteLine("eded menfidir");
//}







//1.   5 ededin cemi
//int sum = 0;

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine( "eded daxil et");
//    int num = Convert.ToInt32(Console.ReadLine());
//    sum += num;

//}
//Console.WriteLine("sum=" + sum);










//2.  ededin kvadrati
//Console.WriteLine("eded daxil et: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("ededin kvadrati=" + (num * num));







//3.  3 ededdden boyuyu
//Console.WriteLine("1ci eded daxil et:");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2ci:");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("3cu:");
//int num3 = Convert.ToInt32(Console.ReadLine());

//int max;

//if (num1 >= num2 && num1 >= num3)
//{
//    max = num1;
//}
//else if (num2 >= num1 && num2 >= num3)
//{
//    max = num2;
//}
//else
//{
//    max = num3;
//}

//Console.WriteLine("en boyuk: " + max);










//4.  1cinin kubu compare 2ci
//Console.WriteLine("1ci eded daxil et:");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2ci:");
//int num2 = Convert.ToInt32(Console.ReadLine());

//int sqrnum1 = num1 * num1;

//if (sqrnum1 > num2)
//{

//    Console.WriteLine("1cinin kvadrati 2ciden boyukdur");
//}

//else if (sqrnum1 < num2)
//{

//    Console.WriteLine("1cinin kvadrati 2ciden kicikdir");
//}

//else
//{
//    Console.WriteLine("beraberdiler");
//}







//5.  hem 3e hem 5e
//Console.WriteLine("eded daxil et:");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 3 == 0 && num % 5 == 0)
//{
//    Console.WriteLine("bolunur");
//}
//else
//{
//    Console.WriteLine("hem 3e hem 5e bolunmur");
//}








//6.  kart mehsul
//Console.WriteLine("kartdaki meblegi daxil et:");
//int card = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("mehsul neceyedir:");
//int mehsul = Convert.ToInt32(Console.ReadLine());

//if (card >= mehsul)
//{

//    Console.WriteLine("pulun catir");
//}
//else
//{

//    Console.WriteLine("pulun catmir");
//}








//7. imtahan
//int sum = 0;
//int minScore = 0;
//int maxScore = 100;
//int totalExams = 5;

//for (int i = 1; i <= totalExams; i++)
//{
//    int score;
//    bool validInput = false;

//    do
//    {
//        Console.WriteLine("Enter the result of exam " + i + " (between 0 and 100):");
//        string input = Console.ReadLine();

//        if (int.TryParse(input, out score))
//        {
//            if (score >= minScore && score <= maxScore)
//            {
//                validInput = true;
//            }
//            else
//            {
//                Console.WriteLine("Please enter a valid score between 0 and 100.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Please enter a valid integer score.");
//        }
//    } while (!validInput);

//    sum += score;
//}

//double average = (double)sum / totalExams;

//Console.WriteLine("Average score: " + average);
//hg
//if (average > 65)
//{
//    Console.WriteLine("Congratulations! You passed.");
//}
//else
//{
//    Console.WriteLine("Sorry, you failed.");
//}








//8.  iki natural eded comparison
//int num1, num2;

//do
//{
//    Console.WriteLine("1ci natural eded:");
//    num1 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("2ci natural eded:");
//    num2 = Convert.ToInt32(Console.ReadLine());

//    if (num1 <= 0 || num2 <= 0)
//    {
//        Console.WriteLine("natural eded olmalidir ikisi de!");
//    }
//    else
//    {
//        if (num1 > num2)
//        {
//            Console.WriteLine($"{num1} boyuydu {num2} den.");
//        }
//        else if (num1 < num2)
//        {
//            Console.WriteLine($"{num2} boyukdu {num1} den.");
//        }
//        else
//        {
//            Console.WriteLine("beraberdiler.");
//        }
//    }
//}
//while (num1 <= 0 || num2 <= 0);











//9.  temperatur
//int donma = 0;

//Console.WriteLine("Temperaturu daxil et");
//int temp = Convert.ToInt32(Console.ReadLine());

//if (temp == donma)
//{
//    Console.WriteLine("eynidi");
//}
//else if (temp < donma)
//{
//    Console.WriteLine("donma tempereaturundan kicikdir");

//}
//else
//{
//    Console.WriteLine("donma temperaturundan yuksekdir");
//}










//2.1  50eqeder artan sira ile
//for (int i = 1; i <= 50; i++)
//{
//    Console.WriteLine(i);
//}








//2.2  40 a qeder 3e bolunen sayi
//int count = 0;
//for (int i = 3; i<=40; i++)
//{
//    if (i % 3 == 0)
//    {
//        count++;
//    }

//}
//Console.WriteLine(count);








//2.3  100e qeder hem 3 hem 7e bolunen
//for (int i = 21; i <= 100; i++)
//{
//    if (i % 3 == 0 && i % 7 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}







//2.4 ededin reqemlerinin sayini tapmaq
//Console.WriteLine("eded daxil et:");
//int num = Convert.ToInt32(Console.ReadLine());

//int digitCount = 0;
//int tempNum = num;

//if (num == 0)
//{
//    digitCount = 1;
//}
//else
//{

//    while (tempNum != 0)
//    {
//        tempNum /= 10;
//        digitCount++;
//    }
//}

//Console.WriteLine($"bu {num} ededdeki reqem sayi {digitCount}dir.");








//2.5  ededi tersine yazmaq

//int reversed_num = 0;
//int last_digit = 0;

//Console.WriteLine("enter num: ");
//int num = Convert.ToInt32(Console.ReadLine());

//while (num != 0)
//{
//    last_digit = num % 10;
//    reversed_num = reversed_num * 10 + last_digit;
//    num = num / 10;
//}

//Console.WriteLine(reversed_num);








//2.6  factorial
//Console.WriteLine("eded daxil et:");
//int num = Convert.ToInt32(Console.ReadLine());

//int factorial = 1;

//for (int i = 1; i <= num; i++)
//{
//    factorial *= i;
//}

//Console.WriteLine(factorial);








//2.7   sade murekkeb 

//Console.WriteLine("edded daxil et:");
//int num = Convert.ToInt32(Console.ReadLine());

//bool Sade = true;


//for (int i = 2; i * i <= num; i++)
//{
//    if (num % i == 0)
//    {
//        Sade = false;
//        break;
//    }
//}

//if (num <= 1)
//{
//    Sade = false;
//}

//if (Sade)
//{
//    Console.WriteLine($"{num} sade");
//}
//else
//{
//    Console.WriteLine($"{num} murekkeb");
//}








// 2.8  ededin reqemlerinin cemi
//Console.WriteLine("eded daxil et:");
//int num = Convert.ToInt32(Console.ReadLine());
//int digit;
//int sum= 0;

//while (num != 0)
//{
//    digit = num % 10;
//    sum += digit;
//    num/= 10;
//}
//Console.WriteLine(sum);










//2.9    ededin reqemleri icersinde en boyuyu
//Console.WriteLine("eded daxil et:");
//int num = Convert.ToInt32(Console.ReadLine());
//int digit = 0;
//int max_digit = 0;

//while (num != 0)
//{
//    digit = num % 10;
//    if (digit > max_digit)
//    {
//        max_digit = digit;
//        num = num / 10;
//    }
//    else
//    {
//        num = num / 10;
//    }
//}

//Console.WriteLine(max_digit);









//2.10    70den kicik olan cut edeleri azalan sira ile
//for (int i = 70; i > 0; i--)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}










//2.11  ayin reqemi daxil edilir  fesil gelir

//Console.WriteLine("Ayin reqemin daxil et: ");
//int num = Convert.ToInt32(Console.ReadLine());

//switch (num)
//{
//    case 2:
//    case 12:
//    case 1:
//        Console.WriteLine("Winter");
//        break;
//    case 5:
//    case 3:
//    case 4:
//        Console.WriteLine("Spring");
//        break;
//    case 8:
//    case 6:
//    case 7:
//        Console.WriteLine("Summer");
//        break;
//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("Autumn");
//        break;
//}










//2.12   square
//Console.WriteLine("enter the side of the square: ");
//int a = Convert.ToInt32(Console.ReadLine());

//for (int i=0; i<=a; i++)
//{
//    for (int j=0; j<=a; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();

//}









//2.13  triangle 1
//Console.WriteLine("enter the side of the triangle: ");
//int a = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= a; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}











//2.14  triangle 2
//Console.WriteLine("enter the side of the triangle: ");
//int a = Convert.ToInt32(Console.ReadLine());

//for (int i = a; i > 0; i--)
//{
//    for (int j = i; j > 0; j--)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}







