using System;

public class GenericArray<T>
{
    private T[] array;

    public GenericArray(int size)
    {
        array = new T[size];
    }

    public void Add(T item)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
            {
                array[i] = item;
                return;
            }
        }
        throw new Exception("Массив полон");
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new Exception("Недопустимый индекс");
        }
        array[index] = default(T);
    }

    public T Get(int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new Exception("Недопустимый индекс");
        }
        return array[index];
    }

    public int Length
    {
        get { return array.Length; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);
        intArray.Add(4);
        intArray.Add(5);

        Console.WriteLine("Массив целых чисел:");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray.Get(i));
        }

        GenericArray<string> stringArray = new GenericArray<string>(3);
        stringArray.Add("Hello");
        stringArray.Add("World");
        stringArray.Add("C#");

        Console.WriteLine("Массив строк:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine(stringArray.Get(i));
        }

        GenericArray<double> doubleArray = new GenericArray<double>(2);
        doubleArray.Add(1.0);
        doubleArray.Add(2.0);

        Console.WriteLine("Массив чисел с плавающей точкой:");
        for (int i = 0; i < doubleArray.Length; i++)
        {
            Console.WriteLine(doubleArray.Get(i));
        }
    }
}
