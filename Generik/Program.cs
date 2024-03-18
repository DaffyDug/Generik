namespace Generik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class GenericArray<T>
    {
        private T[] Ts;

        public GenericArray()
        {
            Ts = new T[0];
        }

        public void Add(T item)
        {
            T[] ts2 = new T[Ts.Length + 1];
            for (int i = 0; i < Ts.Length; i++)
            {
                ts2[i] = Ts[i];
            }
            ts2[ts2.Length - 1] = item;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Ts.Length)
            {
                Console.WriteLine("такого индекса нет");
            }

            T[] newArray = new T[Ts.Length - 1];
            Array.Copy(Ts, newArray, index);
            Array.Copy(Ts, index + 1, newArray, index, Ts.Length - index - 1);
            Ts = newArray;
        }

        public T GetElement(int index)
        {
            if (index < 0 || index >= Ts.Length)
            {
                Console.WriteLine("такого индекса нет");
            }

            return Ts[index];
        }

        public int GetLength()
        {
            return Ts.Length;
        }
    }
}
//Напишите обобщенный класс, который может хранить в массиве объекты любого типа. Кроме того, 
//данный класс должен иметь методы для добавления данных в массив, удаления из массива, 
//получения элемента из массива по индексу и метод, возвращающий длину массива.
//Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления
