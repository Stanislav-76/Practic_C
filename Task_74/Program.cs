// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита 


int n = 0;
void FindWords(string alfavit, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new string(word)}"); return;
    }
    for (int i = 0; i < alfavit.Length; i++)
    {
        word[length] = alfavit[i];
        FindWords(alfavit, word, length + 1);
    }
}
FindWords("аисв", new char[3]);




string[] alfavit1 = { "а", "и", "с", "в" };
int n1 = 3;
string x = String.Empty;
void slovo(string[] alfav, string x, int n)
{
    if (n == x.Length)
    {
        Console.WriteLine(x); return;
    }
    for (int k = 0; k < alfav.Length; k++)
    {
        string d = x + alfav[k];
        slovo(alfav, d, n);
    }
}
slovo(alfavit1, x, n1);