//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
    +"ежели бы вас послали вместо нашего милого Винценгероде,"
    +"вы бы взяли приступом согласие прусского короля."
    +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3]  //r

string Replace(string text, char oldValue, char newValue) //char - одиночный символ 16 бит oldValue (старое значение) newValue (новое значение)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length;i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ','|'); // задаем новую переменную newText и вызываем метод Replace в котором задействовано 3 аргумента text(....) oldValue( cимвол пробел) newValue(символ |)
Console.WriteLine(newText);// выводим результат в консоль
Console.WriteLine();
string newText3 = Replace(text, 'с','С'); //важно выбрать нужную раскладку текста чтобы сработала данная строка
Console.WriteLine(newText3); 
