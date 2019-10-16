using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Jason_Calismasi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /* generic liste kullanılması  
    genaric listeler içerisine sonsuz eleman alabilirler bir sonu yoktur.
    Sürekli büyüyen verileri çekmekte ve saklamakta kullanılar bilirler.

    **** lis kullanımı ****
    List<int>isim = new List<int>(); yada 
    var isim = new list<int>();
    
    **** içerisine elaman eklerken****
    
        List <int> sayilar = new List<int> { 1,2,3,4,5,6 .... } ; 

        List <String> meyveler = new List<String> { "elma","armut","kivi" .... } ; 

   Not: list içerisinde sınıf da tutabiliriz  sınıf içerisindeki bilgileri alabilirz

    *** LİST İLE KULLANILAN METODAR ***
   
    *  Items ve Count 
    *  Add()
    *  AddRabge()
    *  IndexOf()
    *  Remove()
    *  RemoveAt()
    *  Insert()
    *  
    */

    // örek cınıf elemanlarını ekleme 
    
    public partial class MainWindow : Window
    {

        class ogrenci
    {
        public string  ad;
        public  string soyad;

    }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // örnek 1
            var sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);

            //örnek 2
            var isimler = new List<string>() { "leyla", "samet", "mecnun" }; // bu şekide direk olarakda eklene bilir.  
            isimler.Add("emir");
            isimler.Add("can");
            isimler.Add("arslan");

            //örnek 3 class dan veri ekleme
            var ogrenciler = new List<ogrenci>(); // sınıf türünde liste oluşturduk.
            ogrenciler.Add(new ogrenci() { ad = "murat", soyad = "yılmaz" });
            ogrenciler.Add(new ogrenci() { ad = "can", soyad = "seker" });
            ogrenciler.Add(new ogrenci() { ad = "musa", soyad = "ağaç" });


 //******** EKRANA YAZDIRMA İŞLEMLERİ *********

            // for ile yazdırma 
            for (int i = 0; i < isimler.Count; i++)
            {
                list1.Items.Add(isimler[i]);
            }

            //forech ile yazdırma 
            foreach (var ogrenci in ogrenciler)
            {
                list1.Items.Add("öğrenci ad : "+ ogrenci.ad +"  öğrenci soyad :" + ogrenci.soyad);
            }

            // tek bir veriyi yazdırırken 
            MessageBox.Show(sayilar[2].ToString());


            //************** METOTLARIN KULLANIMI *********** 

            var sayilar2 = new List<int>();

            // add : ekleme işlemi için kullanılır.
            sayilar2.Add(80);


            //addRange başka bir sınıfı başka sınıfın üstüne yazabilir 
            sayilar.AddRange(sayilar2); // sayılar1 listesinin üstüne ayrıca sayılar2 listesinide ekledi 

            //Insert bunun ile yeni ekleyeceğimiz veriyi istedğimiz index numarasına göre ekleye biliriz 
            sayilar2.Insert(0, 70); // ilk önce hangi index e ekleneceği daha sonra değer. 

            //InsertRange burada ise yine istediğimiz index e ekleme yaparız ama bu sefer başka bir dizinin bütün elemanlarını ekleye biliriz 
            sayilar.InsertRange(0, sayilar2);

            // Sort burada ise sıralama yapar string ifadeleri alfabeye göre sayıları ise küçükten büyüğe yazdırır 
            sayilar.Sort();

            //remove burada girilen değeri siler 
            isimler.Remove("emir");

            //romveAt burada ise girilem index e göre silme işlemi yapılır 
            isimler.RemoveAt(0);

            // clear ise bütün elemanları siler 


             

        }
    }
}
