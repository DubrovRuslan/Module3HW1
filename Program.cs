using Module3HW1;
using Module3HW1.Helpers;

var myCollection1 = new MyCollection<int>();
myCollection1.Add(4);
myCollection1.Add(5);
myCollection1.Add(6);
var myCollection2 = new MyCollection<int> { 1, 2, 3 };
myCollection1.AddRange(myCollection2);
myCollection1.Sort(new MyCollectionIntComparer());
foreach (var item in myCollection1)
{
    Console.WriteLine(item);
}

myCollection1.Remove(4);
myCollection1.RemoveAt(0);
Console.WriteLine();
foreach (var item in myCollection1)
{
    Console.WriteLine(item);
}
