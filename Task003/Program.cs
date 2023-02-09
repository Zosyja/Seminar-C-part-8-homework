// Пример частотного массива для текстовых данных:
// Символ пробел/space встречается 41 раз. Частота 12.28%
// Символ о встречается 38 раз. Частота 11.38%

char[] Uniqie(string text){
    string unique = string.Empty;
    for (int i=0; i<text.Length; i++){
        if (unique.IndexOf(text[i]) < 0)
            unique += text[i];
    }
    return unique.ToArray();
}
(char, int) []Dictionary(string text){
    return Uniqie(text).Select(e=>
    {
        int count = 0;
        for (int i=0; i<text.Length; i++){
            if (e==text[i]) count++;
        }
        return (symbol: e, count: count);
    }).ToArray();
}
void PrintDictionary (string text){
    var dict = Dictionary(text);
    foreach (var item in dict){
        Console.WriteLine($"Символ {item.Item1} встречается {item.Item2} раз. Частота {(1.000 * item.Item2 / text.Length * 100):F2} %");
    }
}

Console.Write("Введите текст для анализа: ");
string text = Console.ReadLine() ?? "0";
PrintDictionary(text);