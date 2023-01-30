Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 | num == 7){
    Console.WriteLine("Выходной!");
}
else
    Console.WriteLine("Точно не выходной!");