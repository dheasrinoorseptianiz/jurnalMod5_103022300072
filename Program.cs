// See https://aka.ms/new-console-template for more information

using System;
class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDate;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDate = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDate.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi " + storedData[i] + " yang disimpan pada waktu UTC: " + inputDate[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(10);
        db.AddNewData(30);
        db.AddNewData(22);
        db.PrintAllData();
    }
}
