//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int[] numbers = new int[5] {1,2,3,4,5};
int count =5;
List<int> evenNumbers = new List<int>(); 
int index =0;

Console.WriteLine ("My");
for(int i = 0; i<count; i++){
   Console.WriteLine (numbers[i]); 
}

Console.WriteLine ("Your");
while (index<count) {

    if (numbers[index]%2==0) {
        Console.WriteLine ($"numbers[{index}]={numbers[index]}");
       // Console.WriteLine (numbers[index]);     
       evenNumbers.Add(numbers[index]);
    }

    index = index+1;
    Console.WriteLine($"index={index}");  
}
Console.WriteLine ($"evenNumbers={evenNumbers.ToString()}");

foreach (int c in evenNumbers)
{
    Console.WriteLine(c);
}
