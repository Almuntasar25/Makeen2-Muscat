
Console.WriteLine("Enter a number:");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine("Your number is even");
} else {
    Console.WriteLine("Your number is odd");
}

int balanceValue = 50000;
Console.WriteLine("Enter option (1-Withdraw, 2-Deposit, 3-Transfer):");
int option = int.Parse(Console.ReadLine());

switch (option) {
    case 1:
        Console.WriteLine("Enter amount to withdraw:");
        int amount = int.Parse(Console.ReadLine());
        if (balanceValue >= amount) {
            balanceValue -= amount;
            Console.WriteLine($"Withdrawn {amount}, New balance: {balanceValue}");
        } else {
            Console.WriteLine("Insufficient funds");
        }
        break;
    case 2:
        Console.WriteLine("Deposit feature under development");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
