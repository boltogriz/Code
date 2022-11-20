// See https://aka.ms/new-console-template for more information
using ITVDN_Essential;
using ITVDN_Essential.Parts;
using ITVDN_Essential.Doc.Parts2;

MyClass myClass = new MyClass("new");
MyClass myClass1 = new MyClass()
{
    Name = "1_Add in {}"
};
myClass.MyMethod();
myClass1.MyMethod();
new MyClass("third").MyMethod();
Console.WriteLine(new string('-', 30));
MyClass2 myClasses2 = new MyClass2();
MyClasses my;
my = new MyClasses();
myClasses2.CallMethod(my);
Console.WriteLine(new string('-', 30));

Title title = new Title() { Content = "Контракт" };
Body body = new Body();
Footer footer = new Footer() { Content = "Директор: Иванов И.И." };
Call call = new Call() { Content = "Call" };
Document document = new Document(title, body, footer, call);
document.Show();
Document document1 = new Document();
document1.Title = new Title() { Content = "Контракт № 2" };
document1.Body = new Body() { Content = "Текст контракта" };
document1.Footer = new Footer() { Content = "Подпись" };
document1.Call = new Call() { Content = "Call" };
document1.Show();


