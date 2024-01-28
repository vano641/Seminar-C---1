//====== ЗАДАЧА 1 "Работа с Текстом"
//Дан текст. В тексте нужно Все ПРОБЕЛЫ заменить ЧЕРТОЧКАМИ,
//маленькие буквы "к" заменить большими "К",
// Большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3] = r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        //если i совпало со старым значением, то положить туда новое значение
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";// в другом случае оставить все как есть
    }
    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();// отделим задиния друд от друга

newText = Replase(text, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();// отделим задиния друд от друга

newText = Replase(text, 'с', 'С');
Console.WriteLine(newText);