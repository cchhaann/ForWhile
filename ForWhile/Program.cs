using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //執行7次 (0、1、2、3、4、5、6)
            //for (int i = 0; i < 7; i++) {
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //迴圈執行 (1、2、3、4、5、6、7)
            //for (int i = 1 ; i <= 7; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //while迴圈(0、1、2、3、4)
            //int i = 0;
            //while (i < 5) {
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadKey();

            //變數器+2


            // p.5 for : 五個整數，這五個整數的和
            //Console.WriteLine("請輸入5個整數");
            //int sum=0;
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num; 
            //}
            //Console.Write($"答案是{sum}");
            //Console.ReadKey();

            //p.5 while : 五個整數，這五個整數的和
            //Console.WriteLine("請輸入5個整數");
            //int sum = 0;
            //int i=0;
            //while (i < 5)
            //{
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //    i++;
            //}
            //Console.Write($"答案是{sum}");
            //Console.ReadKey();

            //p.9 for迴圈 N輸入，N整數的和
            //Console.WriteLine("請問要輸入幾個整數");
            //int n ;
            //int sum = 0;
            //n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++) {

            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num; 
            //}
            //Console.Write($"答案是{sum}");
            //Console.ReadKey();

            //p.9 While迴圈 N輸入，N整數的和
            //Console.WriteLine("請問要輸入幾個整數");
            //int sum = 0;
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 0;

            //while (i < n)
            //{
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //    i++;
            //}
            //Console.Write($"答案是{sum}");
            //Console.ReadKey();

            //p.12 for迴圈 : N個正整數，求其中的最大值 MinValue(最大值)、MaxValue
            //Console.WriteLine("請問要輸入幾個整數");

            //int n = Convert.ToInt32(Console.ReadLine());

            //int Max = int.MinValue;

            //for (int i = 0; i< n; i++) {

            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num > Max) {
            //        Max = num;
            //    }
            //}
            //Console.Write($"答案是{Max}");
            //Console.ReadKey();


            //p.12 while迴圈 : N個正整數，求其中的最大值 MinValue(最大值)、MaxValue
            //Console.WriteLine("請問要輸入幾個整數");

            //int n = Convert.ToInt32(Console.ReadLine());

            //int Max = int.MinValue;

            //int i = 0;

            //while (i < n)
            //{
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > Max)
            //    {
            //        Max = num;
            //    }
            //    i++;
            //}
            //Console.Write($"答案是{Max}");
            //Console.ReadKey();


            // p.16 N個正整數，求最大奇數值(for)
            //Console.WriteLine("請問要輸入幾個整數");
            //int n  = Convert.ToInt32(Console.ReadLine());
            //int max = 0;

            //for (int i = 0; i < n; i++)
            //{

            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp % 2 != 0 && tmp > max)
            //    {
            //        max = tmp;

            //    }
            //}
            //Console.Write($"答案是{max}");
            //Console.ReadKey();


            // p.17 N個正整數，求最大奇數值(while)
            //Console.WriteLine("請問要輸入幾個整數");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = 0;
            //int i = 0;
            //while (i < n)
            //{
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp % 2 != 0 && tmp > max)
            //    {
            //        max = tmp;

            //    }
            //    i++;
            //}
            //Console.Write($"答案是{max}");
            //Console.ReadKey();



            // p.20 for(int i=2;i<N+1;i++) (for)
            //Console.WriteLine("幾個階層數");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int VAL = 1;

            //for (int i = 2; i < N + 1; i++)
            //{


            //        VAL *= i;
            //}
            //Console.Write($"答案是{VAL}");
            //Console.ReadKey();

            // p.20 for(int i=2;i<N+1;i++) (while)
            //Console.WriteLine("幾個階層數");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int VAL = 1;
            //int i = 2;

            //while (i < N + 1) {
            //    VAL *= i;
            //    i++;
            //}
            //Console.Write($"答案是{VAL}");
            //Console.ReadKey();

            //p.23 巢狀迴圈 Nested loops  (for)
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"第{i}組為i = {i}, j = {j}");
            //    }
            //}
            //Console.ReadKey();

            //p.23 巢狀迴圈 Nested loops (while)
            //int i = 0;
            //while (i < 3)
            //{
            //    int j = 0;
            //    while (j < 3)
            //    {
            //        Console.WriteLine($"第{i}組為i = {i}, j = {j}");

            //        j++;
            //    }
            //    i++;
            //}
            //Console.ReadKey();

            //p.27 for巢狀迴圈(99乘法)
            //Console.WriteLine($"開始輸出99乘法表：");

            //for (int x = 1; x < 10; x++)
            //{

            //    for (int y = 1; y < 10; y++)
            //    {

            //        int sum = x * y;
            //        Console.WriteLine($"{x}*{y}={sum}");
            //    }
            //}
            //Console.ReadKey();

            //p.27 while巢狀迴圈(99乘法)
            //Console.WriteLine($"開始輸出99乘法表：");
            //int x = 1;
            //while (x < 10)
            //{

            //    int y = 1;
            //    while (y < 10)
            //    {

            //        int sum = x * y;
            //        Console.WriteLine($"{x}*{y}={sum}");
            //        y++;
            //    }
            //    x++;
            //}
            //Console.ReadKey();


            //p.27 for巢狀迴圈(99乘法) \t 跳脫字元

            //Console.WriteLine($"開始輸出99乘法表：");

            //for (int x = 1; x < 10; x+=3)
            //{

            //    for (int y = 1; y < 10; y++)
            //    {

            //        Console.Write($"{x:##} * {y:##} = {x * y:##}\t\t"); //{x:##}:##表示變數x值用兩位數的形式輸出，不足時補空格。
            //        Console.Write($"{(x + 1):##} * {y:##} = {(x + 1) * y}\t\t");
            //        Console.WriteLine($"{(x + 2):##} * {y:##} = {(x + 2) * y}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //p.27 while巢狀迴圈(99乘法) \t 跳脫字元
            //Console.WriteLine($"開始輸出99乘法表：");
            //int x = 1;
            //while (x < 10)
            //{

            //    int y = 1;
            //    while (y < 10)
            //    {

            //        Console.Write($"{x:##} * {y:##} = {x * y:##}\t\t"); //{x:##}:##表示變數x值用兩位數的形式輸出，不足時補空格。
            //        Console.Write($"{(x + 1):##} * {y:##} = {(x + 1) * y}\t\t");
            //        Console.WriteLine($"{(x + 2):##} * {y:##} = {(x + 2) * y}");
            //        y++;
            //    }
            //    x += 3;
            //    Console.WriteLine();
            //}
            //Console.ReadKey();


            // p.33 3-1輸入10個整數，求其最小值 (for) : MaxValue是求最小值
            //Console.WriteLine($"請輸入10個正整數");
            //int min = int.MaxValue;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"第{ i + 1}個整數為");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp < min) 
            //    {
            //        min = tmp;
            //    }

            //}
            //Console.WriteLine($"最小值為{min}");
            //Console.ReadKey();


            // p.33 3-1輸入10個整數，求其最小值 (while) : MaxValue是求最小值
            //Console.WriteLine($"請輸入10個正整數");
            //int min = int.MaxValue;
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine($"第{ i + 1}個整數為");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"最小值為{min}");
            //Console.ReadKey();


            // p.33 3-2輸入n個整數，求其最小值 (for) : MaxValue是求最小值
            //Console.WriteLine("請問要輸入幾個整數");

            //int n = Convert.ToInt32(Console.ReadLine());

            //int min = int.MaxValue;

            //for (int i = 0; i < n; i++)
            //{

            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //}
            //Console.Write($"答案是{min}");
            //Console.ReadKey();


            // p.33 3-2輸入n個整數，求其最小值 (while) : MaxValue是求最小值
            //Console.WriteLine("請問要輸入幾個整數");

            //int n = Convert.ToInt32(Console.ReadLine());

            //int min = int.MaxValue;
            //int i = 0;

            //while ( i < n)
            //{

            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //    i++;
            //}
            //Console.Write($"答案是{min}");
            //Console.ReadKey();

            // p.33 3-3輸入10個整數，求所有大於12的數字(for) :
            //Console.WriteLine($"請輸入10個整數");
            //int[] numbers = new int[10]; // 創建一個長度為10的陣列

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //// 找出大於12的數字並輸出
            //Console.WriteLine($"所有大於12的數字為：");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (numbers[i] > 12)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.ReadKey();

            // p.33 3-3輸入10個整數，求所有大於12的數字(while) :
            //Console.WriteLine($"請輸入10個整數");
            //int[] numbers = new int[10];
            //int i = 0;

            //while (i < 10)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    i++;

            //}
            //Console.WriteLine($"所有大於12的數字為：");
            //int J = 0;
            //while (J < 10)
            //{
            //    if (numbers[J] > 12)
            //    {
            //        Console.WriteLine(numbers[J]);
            //    }
            //    J++;
            //}
            //Console.ReadKey();


            // p.33 3-4輸入10個整數，求所有大於12的數字和(for) :
            //Console.WriteLine($"請輸入10個整數");
            //int[] numbers = new int[10]; // 創建一個長度為10的陣列

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"所有大於12的數字為：");
            //int sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    if (numbers[i] > 12)
            //    {

            //        Console.WriteLine(numbers[i]);

            //        sum += numbers[i];
            //    }

            //}
            //Console.WriteLine($"所有大於12的數字總和為：{sum}");
            //Console.ReadKey();

            // p.33 3-4輸入10個整數，求所有大於12的數字和(while) :
            //Console.WriteLine($"請輸入10個整數");
            //int[] numbers = new int[10]; // 創建一個長度為10的陣列
            //int i = 0;

            //while ( i < 10)
            //{
            //    Console.Write($"第{i + 1}個數值為");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    i++;
            //}

            //Console.WriteLine($"所有大於12的數字為：");
            //int sum = 0;
            //for ( i = 0; i < 10; i++)
            //{
            //    if (numbers[i] > 12)
            //    {

            //        Console.WriteLine(numbers[i]);

            //        sum += numbers[i];
            //    }

            //}
            //Console.WriteLine($"所有大於12的數字總和為：{sum}");
            //Console.ReadKey();

            // p.46 3-5所有奇數中的最大值(for)
            //Console.WriteLine("請問要輸入幾個整數");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = 0;

            //for (int i = 0; i < n; i++)
            //{

            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp % 2 != 0)
            //    {
            //        if (tmp > max) {
            //            max = tmp;
            //        }
            //    }
            //}
            //Console.Write($"答案是{max}");
            //Console.ReadKey();

            // p.46 3-5所有奇數中的最大值(while)
            //Console.WriteLine("請問要輸入幾個整數");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = 0;
            //int i = 0;

            //while ( i < n)
            //{

            //    Console.WriteLine($"第{i + 1}個數值為");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp % 2 != 0)
            //    {
            //        if (tmp > max)
            //        {
            //            max = tmp;
            //        }
            //    }
            //    i++;
            //}
            //Console.Write($"答案是{max}");
            //Console.ReadKey();

            //p.46 3-6輸入N個，求正數的平方加總(For)
            //Console.WriteLine("請問輸入幾個數值?");
            //double n = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    double tmp = Convert.ToDouble(Console.ReadLine());

            //    if (tmp > 0) {
            //        sum += Math.Pow(tmp, 2) ;
            //    }
            //}
            //Console.Write($"答案是{sum}");
            //Console.ReadKey();

            //p.46 3-6輸入N個，求正數的平方加總(while)
            //Console.WriteLine("請問輸入幾個數值?");
            //double n = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;
            //int i = 0;
            //while ( i < n)
            //{
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    double tmp = Convert.ToDouble(Console.ReadLine());

            //    if (tmp > 0)
            //    {
            //        sum += Math.Pow(tmp, 2);
            //    }
            //    i++;
            //}
            //Console.Write($"答案是{sum}");
            //Console.ReadKey();

            //p.46 3-7輸入N個，並將負數轉為正數(For)
            //Console.WriteLine($"請問輸入幾個數值?");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] num= new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < n; i++)
            //{

            //    if (num[i] < 0)
            //    {
            //        Console.Write($"原負數值為：{num[i]}，");
            //        num[i] = Math.Abs(num[i]);
            //        Console.WriteLine($"負值轉為正數為：{num[i]}");
            //    }
            //}
            //Console.ReadKey();

            //p.46 3-7輸入N個，並將負數轉為正數(While)
            //Console.WriteLine($"請問輸入幾個數值?");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] num = new int[n];
            //int i = 0;

            //while (i < n)
            //{
            //    Console.WriteLine($"第{i + 1}個數值為");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //    i++;
            //}
            //int j = 0;
            //while (j < n)
            //{

            //    if (num[j] < 0)
            //    {
            //        Console.Write($"原負數值為：{num[j]}，");
            //        num[j] = Math.Abs(num[j]);
            //        Console.WriteLine($"負值轉為正數為：{num[j]}");
            //    }
            //    j++;
            //}
            //Console.ReadKey();

            //p.56 判斷101-200之間有多少個質數，並輸出所有質數(for)
            //for (int i = 101; i <= 200; i++)
            //{
            //    bool isFind = false;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isFind = true;
            //        }
            //    }
            //    if (!isFind)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //p.56 判斷101-200之間有多少個質數，並輸出所有質數(while)
            //int i = 101;
            //while (i <= 200)
            //{
            //    bool isFind = false;
            //    int j = 2;
            //    while (j < i)
            //    {
            //        if (i % j == 0)
            //        {
            //            isFind = true;
            //        }
            //        j++;
            //    }
            //    if (!isFind)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //Console.ReadLine();

            //p.56 輸入一個數，輸出其質因數(for)
            //Console.WriteLine($"請輸入一個正整數");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine($"質因數有{i}");
            //    }

            //}
            //Console.ReadLine();

            //p.56 輸入一個數，輸出其質因數(while)
            //Console.WriteLine($"請輸入一個正整數");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //while (i < n)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine($"質因數有{i}");
            //    }
            //    i++;
            //}
            //Console.ReadLine();

            //p.56 求100到300中可以被3與7整除的個數(for)
            //for (int i = 100; i <= 300; i++)
            //{
            //    if (i % 3 == 0 && i % 7 == 0) {
            //        int sum = i;
            //        Console.WriteLine($"可以被3與7整除的值為{sum}");
            //    }
            //}
            //Console.ReadKey();

            //p.56 求100到300中可以被3與7整除的個數(while)
            //int i = 100;
            //while ( i <= 300)
            //{
            //    if (i % 3 == 0 && i % 7 == 0)
            //    {
            //        int sum = i;
            //        Console.WriteLine($"可以被3與7整除的值為{sum}");
            //    }
            //    i++;
            //}
            //Console.ReadKey();

            // p.65 ch4 while迴圈指令
            //Console.WriteLine($"請輸入一個數");
            //int x = Convert.ToInt32(Console.ReadLine());

            //while (x >= 0) {
            //    Console.WriteLine($"這個{ x }值大於0");
            //    break;
            //}
            //if (x <= 0)
            //{
            //    Console.WriteLine($"這個{ x }值小於0");
            //}
            //Console.ReadKey();

            // p.67 ch4 while迴圈:最大公約數
            //Console.WriteLine($"最大公約數:");
            //Console.WriteLine($"請輸入第一個數");
            //int M = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"請輸入第二個數");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int x = M;
            //int y = N;
            //while (x!=y)
            //{
            //    if (x > y)
            //    {
            //        x = x - y;
            //    }
            //    else 
            //    { 
            //        y = y - x; 
            //    }
            //}
            //Console.WriteLine($"最大公因數為{x}");
            //Console.ReadKey();

            // p.67 ch4 while迴圈:最大公約數(輾轉相除法)
            //Console.WriteLine($"最大公約數:");
            //Console.WriteLine($"請輸入第一個數");
            //int M = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"請輸入第二個數");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int x;

            //if (N > M) {
            //    (M, N) = (N, M);
            //}
            //while (M % N != 0) {
            //    x = M % N;
            //    M = N;
            //    N = x;
            //}
            //Console.WriteLine($"兩數最大公因數為{N}");
            //Console.ReadKey();

            // p.71 ch4 while迴圈:N個數字的和
            //Console.WriteLine($"用while迴圈計算N個數字和");
            //Console.WriteLine($"請輸入數值");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int S = 0;

            //while (i <= N) {
            //    Console.WriteLine($"請再輸入數值");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    S += x;
            //    i++;
            //}
            //Console.WriteLine($"值為{S}");
            //Console.ReadKey();

            // p.73 ch4-2 while迴圈:N個數字的最大值
            //Console.WriteLine($"請問要輸入幾個數值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = 0;
            //int i = 1;

            //while (i <= n)
            //{
            //    Console.WriteLine($"第{i}個數值為");
            //    int x = Convert.ToInt32(Console.ReadLine());

            //    if (x > max) {
            //        max = x;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"最大值為{max}");
            //Console.ReadKey();

            // p.73 ch4-2 N個等差級數數字的和
            //Console.WriteLine($"請問要輸入幾個數值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"請輸入起始值");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"請輸入間隔");
            //int interval = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //while (n>0)
            //{
            //    sum += start;
            //    start += interval;
            //    n -=  1;
            //}
            //Console.WriteLine($"等差級數數字的和為{sum}");
            //Console.ReadKey();

            //p.73 ch4-3 讀入N個數字，然後找出所有小於13的數，再求這些數字的和
            //Console.WriteLine($"請問要輸入幾個數值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int i = 0;


            //while (n > 0)
            //{
            //    Console.WriteLine($"第{i+1}個數值為");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    i++;

            //    if (x < 13)
            //    {
            //        sum += x;
            //    }
            //    n -= 1;
            //}
            //Console.WriteLine($"小於13的和為{sum}");
            //Console.ReadKey();

            //p.80 ch4-4 讀入N個數字，找到第一個大於7而小於10的數字就停止，並列印出
            //Console.WriteLine($"請問要輸入幾個數值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;

            //while (n>0)
            //{
            //    Console.WriteLine($"第{i}個數值為");
            //    int x = Convert.ToInt32(Console.ReadLine());


            //    if (x > 7 && x < 10)
            //    {
            //        Console.WriteLine($"第一個大於7且小於10的數為{x}");
            //        break;
            //    }
            //    n -= 1;
            //    i++;

            //}
            //Console.WriteLine($"其他都沒有大於7且小於10");
            //Console.ReadKey();

            //p.80 ch4-5 讀入a1,a2,…,a5..，找到ai>bi就停止，並列印出
            //int n = 1;
            //while (n <= 5)
            //{
            //    Console.WriteLine($"請輸入a{n}值");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"請輸入b{n}值");
            //    int b = Convert.ToInt32(Console.ReadLine());

            //    if (a > b)
            //    {
            //        Console.WriteLine($"a{n}值 > b{n}值");
            //        break;
            //    }
            //    n++;
            //}
            //if (n > 5) {
            //    Console.WriteLine($"a值均無大於b值");
            //}
            //Console.ReadKey();

            //p.87 Eric 五分鐘吃漢堡
            //Console.WriteLine($"請輸入時間(分)");
            //int time = Convert.ToInt32(Console.ReadLine());

            //if (time >= 5)
            //{
            //    time = time / 5;
            //    Console.WriteLine($"這段時間已經吃完{time}次");
            //}
            //else {
            //    Console.WriteLine($"這段時間都沒吃完一個");
            //}
            //Console.ReadKey();

            //p.87 買房貸款
            //int price = 560;
            //int pay = 4;
            //int bonuses = 1;
            //int months = 0;

            //while (price > 0)
            //{
            //    price -= pay;
            //    if (months % 12 == 0)
            //    {
            //        price -= bonuses;
            //    }
            //    months++;
            //}
            //Console.WriteLine($"還清要 {months} 個月。");
            //Console.ReadKey();

            //p.87 終極密碼
            Console.WriteLine($"請輸入一個1~99內的數字");
            int x = Convert.ToInt32(Console.ReadLine());
            Random myObject = new Random();
            int ranNum = myObject.Next(1, 100);

            while (x != ranNum)
            {
                if (x < ranNum)
                {
                    Console.WriteLine($"猜得太大了");
                }
                else if (x > ranNum)
                {
                    Console.WriteLine($"猜得太小了");
                }
                else
                {
                    Console.WriteLine($"猜對了");
                }
                break;
            }
            Console.ReadKey();

        }
    }
}
