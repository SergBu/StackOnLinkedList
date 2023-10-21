// See https://aka.ms/new-console-template for more information

using StackOnLinkedList;

var stack = new StackOnLinkedList<string>();
stack.Push("Tom");
stack.Push("Alice");
stack.Push("Bob");
stack.Push("Kate");

foreach (var item in stack)
{
    Console.WriteLine(item);
}
Console.WriteLine();
string header = stack.Peek();
Console.WriteLine($"Верхушка стека: {header}");
Console.WriteLine();

header = stack.Pop();
foreach (var item in stack)
{
    Console.WriteLine(item);
}

