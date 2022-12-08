// ВИДЫ МЕТОДОВ

// Вид 1. Метод "nothing in, nothing out"

void Method1()     // тело метода
{
    Console.WriteLine("Метод 1: 'nothing in, nothing out'");
}
//Method1();      // вызов метода


// Вид 2. Метод "something in, nothing out"

void Method2(string msg)   // тело метода
{
    Console.WriteLine(msg);
}
//Method2("Метод 2: 'something in, nothing out'");    // вызов метода

void Method2_1(string msg, int count)  // тело метода
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2_1("Метод 2_1: 'something in, nothing out' x count", 3); // вызов метода
// Method2_1(count: 2, msg: "Текст сообщения"); // вызов метода с именованными аргументами


// Вид 3. Метод "nothing in, something out"

int Method3()   // тело метода
{
    return DateTime.Now.DayOfYear;
}
// Console.WriteLine (Method3 ()); // вызов метода


// Вид 4. Метод "something in, something out"

string Method4(int count, string text)      // тело метода
{
    int i = 0;
    string resultLine = String.Empty;
    while (i < count)
    {
        resultLine = resultLine + text + " | ";
        i++;
    }
    return resultLine;
}
// Console.WriteLine(Method4(5, "Test Method4"));  // вызов метода


string Method4_1(int count, string text)      // тело метода с циклом for 
{
    string resultLine = String.Empty;
    for (int i = 0; i < count; i++)
    {
        resultLine = resultLine + text + " | ";
    }
    return resultLine;
}
//Console.WriteLine(Method4(5, "Test Method4_1"));  // вызов метода


// Цикл в цикле

// for (int i = 2; i < 10; i++)  
// {
//     for (int j = 1; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }

//     Console.WriteLine();
// }


// Задача: Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” 
// заменить большими “К”, а большие “С” заменить маленькими “с”.

string txt = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали"
            + " вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля."
            + " Вы так красноречивы. Вы дадите мне чаю?";

// адресация символов в строке и их вызов
// string s = "qwerty";
//             012345 - адресация символов
// s[5] --> "r" - вызов символа по адресу

string ReplaceCharInString(string text, char oldChar, char newChar)
{
    string newText = String.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldChar) newText = newText + newChar;
        else newText = newText + text[i];
    }
    return newText;
}

// вариант 1
string txt1 = ReplaceCharInString(txt, ' ', '_');  // !!! тип char выделяется апострофами '' !!!
string txt2 = ReplaceCharInString(txt1, 'к', 'К');
string txt3 = ReplaceCharInString(txt2, 'С', 'с');
Console.WriteLine(txt3);

// вариант 2
Console.WriteLine(ReplaceCharInString((ReplaceCharInString((ReplaceCharInString(txt, ' ', '_')), 'к', 'К')), 'С', 'с'));

// вариант 3
string newTxt = (ReplaceCharInString((ReplaceCharInString((ReplaceCharInString(txt, ' ', '_')), 'к', 'К')), 'С', 'с'));
Console.WriteLine(newTxt);