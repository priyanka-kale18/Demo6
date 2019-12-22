using System;

public class DemoSwap{

 public void Swap(ref int x,ref int y)
	 {
	 int temp;
	 temp=x;
	 x=y;
	 y=temp;
	 }
 static void Main(){
 
    DemoSwap demoswap;
	int num1;
	int num2;
	
	
	Console.WriteLine("enter the first number");
	num1=Int32.Parse(Console.ReadLine());
	
	Console.WriteLine("enter the second number");
	num2=Int32.Parse(Console.ReadLine());
	
	Console.WriteLine("before swap num1="+num1+"num2="+num2);
	demoswap=new DemoSwap();
	
	demoswap.Swap(ref num1,ref num2);
	
	Console.WriteLine("after swap num1="+num1+"num2="+num2);
 
 }
}
 