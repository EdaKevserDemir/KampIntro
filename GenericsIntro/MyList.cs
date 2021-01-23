using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor default olarak çalışır.
        public MyList()
        {
            items = new T[0]; //yeni oluşturulan arrayi 0 eleman olarak verdim
        }

        public void Add(T item)
        {
            T[] tempArray = items; //referans nosunu kaybetmemek için oluşturduk.

            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];   //tempArray de geçici olarak tutulan değerleri eski sıralarıyla yeni oluşturulan referansa ekliyoruz 
            }

            items[items.Length - 1] = item;  //eklenecek olan son değerin eklenme işlemi asıl olarak burada yapılıyor.
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
