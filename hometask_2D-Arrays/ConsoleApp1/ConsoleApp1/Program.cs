//string[] cars = { "bmw" , "lada"};

//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}

//string word = "salam";

//for (int i = 0; i < word.Length; i++)
//{
//    Console.WriteLine(word[i]);
//}






//1. nxn print etmek

//int[,] array =
//{
//    {100,200,300 },
//    {50, 40, 20},
//    {70,90,30 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//2. cem
//int sum = 0;
//int[,] array =
//{
//    {100,200,300 },
//    {50,40,20},
//    {70,90,30 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum += array[i,j];
//    }
//}
//Console.WriteLine("cem beraberdi" + sum);



//3. 1ci sutunun cemi

//int sum = 0;
//int[,] array =
//{
//    {100,200,300 },
//    {50,40,20},
//    {70,90,30 }
//};

//for (int j = 0; j < array.GetLength(1); j++)
//{
//        sum += array[0, j];
//}

//Console.WriteLine("cem beraberdi" + sum);



//4. neqativleri print

//int[,] array =
//{
//    {100,200,-300 },
//    {50,-40,20},
//    {-70,90,30 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i,j] <0)
//        {
//            Console.Write(array[i,j] + " " );
//        }
//    }
//}




//5.minimum max

//int[,] array =
//{
//    {100,200,-300 },
//    {50,-40,20},
//    {-70,90,30 }
//};
//int max = array[0, 0];
//int min = array[0, 0];

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] > max)
//        {
//            max = array[i, j];

//        }

//        if (array[i, j] < min)
//        {
//            min = array[i, j];

//        }
//    }
//}
//Console.WriteLine("max= " +max);
//Console.WriteLine("min= " + min);




//6.cut - 2   tek - 1   0disa - 0

//int[,] array =
//{
//    {5,200,0 },
//    {24,7,-9},
//    {-70,90,30 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] > 0)
//        {
//            if (array[i, j] % 2 == 0)
//            {
//                array[i, j] = 2;
//            }
//            else
//            {
//                array[i, j] = 1;
//            }
//        }
//        else if (array[i, j] < 0)
//        {
//            if (array[i, j] % 2 == 0)
//            {
//                array[i, j] = -2;
//            }
//            else
//            {
//                array[i, j] = -1;
//            }
//        }
//        else
//        {
//            array[i, j] = 0;
//        }
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}




//7. 4x4 2ci sira 0

//int[,] array =
//{
//    {5,200,0 , 20},
//    {24,7,-9, 20},
//    {-70,90,30 , 60},
//    {34, -5, 89, 34 }
//};


//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[1, j] = 0;
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}




//8. 3cu sutun 0

//int[,] array =
//{
//    {5,200,0 },
//    {24,7,-9},
//    {-70,90,30 }
//};


//for (int i = 0; i < array.GetLength(0); i++)
//{
//    array[i,2] = 0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//9. 3x3 de sol dioqanaldakilarin cemi


//int[,] array =
//{
//    {5,200,0 },
//    {24,7,-9},
//    {-70,90,30 }
//};
//int sum = 0;

//for (int i = 0 ; i < 3; i++)
//{
//    sum += array[i,i];
//}

//Console.WriteLine(sum);



//10.sag diagonal

//int[,] array =
//{
//  { 5, 200, 0 },
//  { 24, 7, -9 },
//  { -70, 90, 30 }
//};

//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int j = array.GetLength(1) - 1 - i;
//    sum += array[i, j];
//}

//Console.WriteLine("sum: " + sum);




//11.5x5 sol diagonaldan asagi sifir olsun

//int[,] array =
//{
//    {5,200,0, 45, -8},
//    {24,7,-9,3,0},
//    {-70, 90, 30, 45, -8},
//    {4,76,-9,4,1 },
//    {34,6,45,2,5}
//};
//int array2 = array[0, 0];



//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//       
//        if (i > j)
//        {
//            array[i, j] = 0;
//        }
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i,j] + " ");
//    }
//    Console.WriteLine();
//}





//12. sol diaqonaldan yuxaridakilar 0

//int[,] array =
//{
//    {5,200,0, 45, -8},
//    {24,7,-9,3,0},
//    {-70, 90, 30, 45, -8},
//    {4,76,-9,4,1 },
//    {34,6,45,2,5}
//};
//int array2 = array[0, 0];



//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {

//        if (i <j )
//        {
//            array[i, j] = 0;
//        }
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}






//13. verilmis arrayin elementlerini cemleyib 3cu arrayi yarat

//int[,] array =
//{
//    {5,200,0, 45, -8},
//    {24,7,-9,3,0},
//    {-70, 90, 30, 45, -8},
//    {4,76,-9,4,1 },
//    {34,6,45,2,5}
//};
//int[,] array2 =
//{
//    {5,34,0, 6, -8},
//    {34,7,-9,3,0},
//    {-70, 3, 30, 45, 7},
//    {4,76,-9,4,6 },
//    {21,3,45,34,9}
//};


//int[,] sumArray = new int[array.GetLength(0), array.GetLength(1)];

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sumArray[i, j] = array[i, j] + array2[i, j];
//    }
//}


//for (int i = 0; i < sumArray.GetLength(0); i++)
//{
//    for (int j = 0; j < sumArray.GetLength(1); j++)
//    {
//        Console.Write(sumArray[i, j] + " ");
//    }
//    Console.WriteLine();
//}






//14. her bir rowun ayriliqda cemi

//int[,] array =
//{
//    {2,4 },
//    {-5, 0 }
//};

//int sum1 = 0;
//int sum2 = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    sum1 += array[0, i];

//}
//Console.WriteLine(sum1);

//for (int i = 0; i < array.GetLength(1); i++)
//{
//    sum2 += array[1, i];

//}
//Console.WriteLine(sum2);







//14.2
//int[,] array =
//{
//    {2,3,5 },
//    {4,6,7},
//    {8,9,10 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int sum = 0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum+= array[i,j];
//    }
//    Console.WriteLine(sum);
//}




//15. her column cemi

//int[,] array =
//{
//    {2,4 },
//    {-5, 0 }
//};

//int sum1 = 0;
//int sum2 = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    sum1 += array[i, 0];
//    sum2 += array[i, 1];

//}
//Console.WriteLine("sum1=" + sum1);
//Console.WriteLine("sum2=" + sum2);














//16.  


//int[,] array =
//{
//  { 1, 1, 5, 0, 1, 1 },
//  { 1, 1, 2, 0, 1, 1 },
//  { 1, 1, 3, 0, 1, 1 },
//  { 1, 1, 4, 0, 1, 1 }
//};


//int shift = 3;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = array.GetLength(1) - 1; j>=0; j--)
//    {
//        if (j - shift > 0)
//        {
//            array[i, j] = array[i, j - shift];
//        }
//        else
//            array[i, j] = 0;
//    }
//}

//for (int i = 0;i< array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}







//17.   2sinin hasili

//int[,] array =
//{
//    {5,200,0, 45, -8},
//    {24,7,-9,3,0},
//    {-70, 90, 30, 45, -8},
//    {4,76,-9,4,1 },
//    {34,6,45,2,5}
//};
//int[,] array2 =
//{
//    {5,34,0, 6, -8},
//    {34,7,-9,3,0},
//    {-70, 3, 30, 45, 7},
//    {4,76,-9,4,6 },
//    {21,3,45,34,9}
//};


//int[,] multArray = new int[array.GetLength(0), array.GetLength(1)];

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        multArray[i, j] = array[i, j] * array2[i, j];
//    }
//}


//for (int i = 0; i < multArray.GetLength(0); i++)
//{
//    for (int j = 0; j < multArray.GetLength(1); j++)
//    {
//        Console.Write(multArray[i, j] + " ");
//    }
//    Console.WriteLine();
//}













//18. 2 arrayde sade ededleri tapib print etmek 

//int[,] array =
//{
//    {5,200,0, 45, -8},
//    {24,7,-9,3,0},
//    {-70, 90, 30, 45, -8},
//    {4,76,-9,4,1 },
//    {34,6,45,2,5}
//};

//int[,] array2 =
//{
//    {5,34,0, 6, -8},
//    {34,7,-9,3,0},
//    {-70, 3, 30, 45, 7},
//    {4,76,-9,4,6 },
//    {21,3,45,34,9}
//};

//bool isComplex;

//Console.WriteLine("prime numbers in array:");
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] <= 1)
//        {
//            continue;
//        }

//        isComplex = false;
//        int squareroot = (int)Math.Sqrt(array[i, j]);
//        for (int k = 2; k <= squareroot; k++)
//        {
//            if (array[i, j] % k == 0)
//            {
//                isComplex = true;
//                break;
//            }
//        }

//        if (!isComplex)
//        {
//            Console.WriteLine(array[i, j]);
//        }
//    }
//}

//Console.WriteLine("prime numbers in array2:");
//for (int i = 0; i < array2.GetLength(0); i++)
//{
//    for (int j = 0; j < array2.GetLength(1); j++)
//    {
//        if (array2[i, j] <= 1)
//        {
//            continue;
//        }

//        isComplex = false;
//        int squareroot = (int)Math.Sqrt(array2[i, j]);
//        for (int k = 2; k <= squareroot; k++)
//        {
//            if (array2[i, j] % k == 0)
//            {
//                isComplex = true;
//                break;
//            }
//        }

//        if (!isComplex)
//        {
//            Console.WriteLine(array2[i, j]);
//        }
//    }
//}
