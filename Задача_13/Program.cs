Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int size = 0;
int numUsed = num;

// Определяем количество разрядов
while(numUsed != 0){
    numUsed = numUsed/10;
    size++;
}

if (size > 2){
    // готовим делитель для выделения третьего числа
    int div = 10;
    for (int i = 0; i < size - 4; i++){
        div = div * 10;
    }
    Console.WriteLine($"Третье число: {num/(div)%10}");
}
else
    Console.WriteLine($"Число двухзначное");