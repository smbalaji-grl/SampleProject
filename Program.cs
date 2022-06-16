// See https://aka.ms/new-console-template for more information
using DATA_SET;
Console.WriteLine("Hello, World!");
UserInput u1 = new UserInput();
u1.getUserData();
Measure m1=new Measure(u1);
m1.measureSpeed();
ShowResults sr= new ShowResults(m1);
sr.method1();


