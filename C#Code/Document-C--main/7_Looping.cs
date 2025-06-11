
for (int i = 0; i <= 5; i++) {
    Console.WriteLine(i);
}

int j = 0;
while (j < 3) {
    Console.WriteLine("Enter number:");
    int input = int.Parse(Console.ReadLine());
    if (input % 2 == 0)
        Console.WriteLine("Even");
    else
        Console.WriteLine("Odd");
    j++;
}

int x = 2;
do {
    Console.WriteLine("Hello from do-while");
} while (x == 3);
