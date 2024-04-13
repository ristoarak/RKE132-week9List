string folderPath = @"C:\data";
string fileName = "shoppinList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();

if(File.Exists(filePath))
{
 myShoppingList = GetItemFromUsers();
File.WriteAllLines(filePath, myShoppingList);

}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} file has been created.");
    myShoppingList = GetItemFromUsers();
    File.WriteAllLines(filePath,myShoppingList);
}




static List<string> GetItemFromUsers()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add anitem ( add/Exit  (Exit):");
        string userChoice = Console.ReadLine();
        if (userChoice == "add")
        {
            Console.WriteLine(" Enter anItem:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int ListLength = someList.Count;
    Console.WriteLine($"You have {ListLength} added item to your shopping list.");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}