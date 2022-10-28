MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();
MyNamespace.SubNamespace.SubClass.SubMethod();
MyAbstractClassImpl myAbstractClassImpl = new MyAbstractClassImpl();
MyAbstractClass myAbstractClass = new MyAbstractClassImpl();
myAbstractClassImpl.Method();
myAbstractClass.Method2();
myAbstractClassImpl.Method2();
myAbstractClass.Method3();
myAbstractClassImpl.Method3();
myAbstractClass.Method4();
myAbstractClassImpl.Method4();

string fileName = @"C:\Users\jialinl\Desktop\a.txt";
string text = """
    First line
    Second line
    Third line
    Forth line
    Fifth line
    Sixth line
    Seventh line
    Eighth line
    Ninth line
    Tenth line
    Eleventh line
    Twelfth line
    """;
long start = DateTime.Now.Ticks;
await FileClassAsync.WriteFile(fileName, text);
await FileClassAsync.ReadFile(fileName);
long end = DateTime.Now.Ticks;
Console.WriteLine($"cost time: {end - start} ms");

fileName = @"C:\Users\jialinl\Desktop\b.txt";
start = DateTime.Now.Ticks;
//FileClass.WriteFile(fileName, text);
//FileClass.ReadFile(fileName);
await FileClassAsync.WriteFile(fileName, text);
await FileClassAsync.ReadFile(fileName);
end = DateTime.Now.Ticks;
Console.WriteLine($"cost time: {end - start} ms");

fileName = @"C:\Users\jialinl\Desktop\c.txt";
start = DateTime.Now.Ticks;
await FileClassAsync.WriteFile(fileName, text);
await FileClassAsync.ReadFile(fileName);
end = DateTime.Now.Ticks;
Console.WriteLine($"cost time: {end - start} ms");

Microsoft.Win32.RegistryKey key;
key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("New name");
key.SetValue("Name", "Isabella");
key.Close();
public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello World!");
    }

}

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
        }
    }

    namespace SubNamespace
    {
        class SubClass
        {
            public static void SubMethod()
            {
                Console.WriteLine("Hello World from MyNamespace.SubNamespace.SubClass.SubMethod!");
            }
        }
    }
}

public abstract class MyAbstractClass
{
    public abstract void Method();

    public void Method2()
    {
        Console.WriteLine("Method2 in MyAbstractClass");
    }

    public virtual void Method3()
    {
        Console.WriteLine("Method3 in MyAbstractClass");
    }

    public virtual void Method4()
    {
        Console.WriteLine("Method4 in MyAbstractClass");
    }
}

public class MyAbstractClassImpl : MyAbstractClass
{
    public override void Method()
    {
        Console.WriteLine("Method in MyAbstractClassImpl");
    }

    public new void Method2()
    {
        Console.WriteLine("Method2 in MyAbstractClassImpl");
    }

    public override void Method3()
    {
        Console.WriteLine("Method3 in MyAbstractClassImpl");
    }

    public sealed override void Method4()
    {
        Console.WriteLine("Method4 in MyAbstractClassImpl");
    }
}

public class FileClass
{
    public static void ReadFile(string fileName)
    {
        string text = File.ReadAllText(fileName);
        Console.WriteLine(text);
    }

    public static void WriteFile(string fileName, string text)
    {
        if (!File.Exists(fileName))
        {
            File.Create(fileName);
        }
        File.WriteAllText(fileName, text);
    }
}

public class FileClassAsync
{
    public static async Task ReadFile(string fileName)
    {
        string text = await File.ReadAllTextAsync(fileName);
        Console.WriteLine(text);
    }

    public static async Task WriteFile(string fileName, string text)
    {
        await File.WriteAllTextAsync(fileName, text);
    }
}