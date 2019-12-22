using System;

public class OutDemo{

 public void Outmethod(int x, int y ,out int c)
	 {
	 int temp;
	 temp=x+y;
	 c=200;
	 return temp;
	 }
 static void Main(){
 
    OutDemo outDemo;
	int num1;
	int num2;
	
	
	Console.WriteLine("enter the first number");
	num1=Int32.Parse(Console.ReadLine());
	
	Console.WriteLine("enter the second number");
	num2=Int32.Parse(Console.ReadLine());
	
	
	outDemo=new OutDemo();
	int a;
	int result=outDemo.Outmethod(ref num1,ref num2,out a );
	
	Console.WriteLine("num1="+num1+"num2="+num2+"c="+a);
 
 }
}
 