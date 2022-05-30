// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
/*
string[] fruit = { "Apple", "peach", "lemon", "Orange", "avocado", "apricot" };

int WordVowel(string[] words)
{
    int count = 0;
    string[] vowel = { "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "y" };

    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < vowel.Length; j++)
            if ($"{words[i][0]}" == $"{vowel[j]}") count++;
    }
    return count;
}

int amount = WordVowel(fruit);
Console.Write($"Количество слов, начинающихся с гласной буквы - {amount}");
*/

// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] word = { "qwe", "wer", "ert", "rty", "tyu", "yui", "asd", "hio" };

string[] CombinationWords(string[] words)
{
    string[] newWords = new string[words.Length / 2];

    for (int i = 0, j = 0; j < words.Length - 1; i++, j += 2) newWords[i] = words[j] + words[j + 1];
    return newWords;
}

void PrintMassiv(string[] wrd)
{
    for (int i = 0; i < wrd.Length; i++) Console.Write(wrd[i] + " ");
}

string[] newW = CombinationWords(word);
PrintMassiv(newW);


