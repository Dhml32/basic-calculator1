// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");





 Console.WriteLine("Enter first number: " );
Double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Scoend number: " );
  Double number2 = Convert.ToDouble(Console.ReadLine());
   
   Console.Write("Choose an operation: ");
   Double result = 0;
   
   switch (Console.ReadLine()) 
   {

     case "+":
      result = number1 + number2;
    Console.WriteLine($"Yoer result: {number1} + {number2} = " + result );
     break;

     case "-":
      result = number1 - number2;
    Console.WriteLine($"Yoer result: {number1} - {number2} = " + result );
     break;
     
     case "*":
      result = number1 * number2;
    Console.WriteLine($"Yoer result: {number1} * {number2} = " + result );
     break;
     
     case "/":
      result = number1 / number2;
    Console.WriteLine($"Yoer result: {number1} / {number2} = " + result );
     break;
      
      default:
       Console.WriteLine("You must choose between : +,-,*,/ ");
       break;
   }





  