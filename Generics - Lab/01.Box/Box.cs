using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> Data { get; set; }=new List<T>();

        public int Count => Data.Count;

        public void Add(T element)
        {
           this.Data.Add(element);
        }

        public T Remove()
        {
            var lastElement = this.Data[Data.Count - 1];
            this.Data.RemoveAt(Data.Count-1);
            return lastElement;
        }
    }
}
