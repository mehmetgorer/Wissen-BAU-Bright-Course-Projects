using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Generic_Collections
{
    //Non-Generic klasik koleksiyonlar (ArrayList gibi), elemanlarını object olarak tuttuğundan boxing unboxing işlemleri nedeniyle performans kaybına ve her türlü veriyle çalışabildiklerinden veri türlerinin çakışması nedeniyle sorunlara yol açabilmektedirler.
    //Şablon (Generic Collections) türlerle çalışan koleksiyonlar, System.Collections.Generic kütüphanesini kullanırlar, çalışma anında istediğimiz türü seçebildiğimiz için hem türden bağımsız, hem performanslı, hem de tür güvenliği (strongly type) yüksek seviyede kullanma imkanı sağlarlar.
    public class Ornek<T>       //T -> Şablon Tür
    {
        public T Ozellik1 { get; set; }

        public T Metod(T sayi)
        {
            return sayi;
        }
        public int Metod(int sayi)
        {
            return sayi * sayi;
        }
    }
}
