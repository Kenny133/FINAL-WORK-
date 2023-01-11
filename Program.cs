using System;
class HelloWorld 
{
    static void Main() 
    {
                string[] A = new string[]{"Hello","2","World",":-)"};
        foreach(string a in A)
        Console.Write(a + " ");
        int i = 0;
        string[] B = new string[A.Length];
        foreach (string a in A)
        if(a.Length <= 3)
        {
            B [i] = a;
            i = i + 1;
        }
        Console.WriteLine(" ");
        foreach(string a in B)
        Console.Write(a + "; ");
        Array.Resize(ref A, i);
    }
}