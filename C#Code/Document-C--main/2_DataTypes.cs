
// Primitive Types:
string name = "yousif";
int age = 27;
string address = "alexandria";
bool hasJob = true;
string jobDesc = null;

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine($"{name}, {age}, {address}, {hasJob}, {jobDesc}");

string result = $"Your name is {name}, your age is {age}, and your address is {address}. " +
                $"You have a job: {hasJob}, Description: {jobDesc}";
Console.WriteLine(result);

// Object (Non-Primitive Type)
var personalInfo = new {
    Id = 1,
    YouName = "ahmed",
    YourAge = 27,
    YourJob = "developer",
    IsMarried = false
};

Console.WriteLine(personalInfo.YouName);

// Arrays
int[] arr1 = {1, 2, 3, 4, 5, 6, 89};
string[] arr2 = {"usif", "usif", "usif"};

var arr3 = new[] {
    new {Id = 1, YouName = "ahmed", YourAge = 27, YourJob = "developer", IsMarried = false},
    new {Id = 2, YouName = "ali", YourAge = 28, YourJob = "designer", IsMarried = true}
};

string[][] arr4 = {
    new[] {"1", "2", "3", "4"},
    new[] {"7amo", "wa23", "mni"}
};

Console.WriteLine(arr1[0]);
Console.WriteLine(arr2[1]);
Console.WriteLine(arr3[0].YourAge);
Console.WriteLine(arr4[1][0]);
