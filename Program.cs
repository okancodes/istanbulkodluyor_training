Console.Clear();
Console.WriteLine("Pair 2 grubunun ödevine hoşgeldiniz. Başlamak için ENTER a basın.");
Console.ReadLine();

work();
static void work()
{
    Console.Clear();
    problemList(); 
    Console.WriteLine("");
    Console.WriteLine("Görüntülemek istediğiniz problemin sayısını girin (1-8): ");
    
    int worknr = Convert.ToInt32(Console.ReadLine());
switch (worknr){ 
    case 1:
/*1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş 
edildiğini belirleyen algoritma yazınız. */
Console.Clear();
Console.WriteLine("==================================================");
Console.WriteLine("Sipariş Numarasına Göre Hangi Ürün Sipariş Edildi");
Console.WriteLine("==================================================");

Console.WriteLine("Sipariş Numaranızı Giriniz (1-9): ");
int orderid = Convert.ToInt32(Console.ReadLine());
Console.Write("Sipariş ettiğiniz ürün: ");

switch (orderid){
    case 1:
        Console.WriteLine("Bilgisayar");
    break;
    case 2:
        Console.WriteLine("Cep Telefonu");
    break;
    case 3:
        Console.WriteLine("Tablet");
    break;
    case 4:
        Console.WriteLine("Televizyon");
    break;
    case 5:
        Console.WriteLine("Buzdolabı");
    break;
    case 6:
        Console.WriteLine("Çamaşır Makinesi");
    break;
    case 7:
        Console.WriteLine("Bulaşık Makinesi");
    break;
    case 8:
        Console.WriteLine("Fırın");
    break;
    case 9:
        Console.WriteLine("Derin Dondurucu");
    break;
    default:
        fail();
    break;
    

}again();
break;

case 2:
//2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak 
//toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)
Console.Clear();
Console.WriteLine("================================================");
Console.WriteLine("For Döngüsü ile Ürün Sayısı ve Fiyatı Hesaplama");
Console.WriteLine("================================================");

Console.WriteLine("Kaç adet ürün almak istersiniz?");
int productUnit = Convert.ToInt32(Console.ReadLine());
double result = 0;
for(int a = 1; a <= productUnit ; a++)
{
    Console.WriteLine(a + ". ürünün fiyatı:");
    result += Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Toplam tutar: " + result);
again();
break;
case 3:
Console.Clear();
Console.WriteLine("=======================================");
Console.WriteLine("Do-While ve While Döngüleri Örnekleri");
Console.WriteLine("=======================================");
//3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
    Console.WriteLine("1- While ile 5 ile 100 arasındaki sayıların toplamı örneği");
    Console.WriteLine("2- Do - While ile 5 ile 100 arasındaki çift sayıların toplamı örneği");
    Console.Write("Lütfen görüntülemek istediğiniz döngünün numarasını girin: ");
    int dwAndWhile = Convert.ToInt32(Console.ReadLine());
    if (dwAndWhile == 1){
    Console.Clear();
Console.WriteLine("While ile 5 ile 100 arasındaki sayıların toplamı örneği;");

int summ = 0;
int b = 5;
while (b < 100)
{
    summ += b;
    b++;
}
Console.WriteLine("int summ = 0;");
Console.WriteLine("int b = 5;");
Console.WriteLine("while (b < 100)");
Console.WriteLine("{");
Console.WriteLine("summ += b;");
Console.WriteLine("i++;");
Console.WriteLine("}");
Console.WriteLine("5 ile 100 arasındaki sayıların toplamı: " +summ);
    again();}
    
    else if (dwAndWhile == 2){
    Console.Clear();
Console.WriteLine("Do while ile 5 ile 100 arasındaki çift sayıların toplamı:");

int c = 5;
int tot = 0;
do
{
    if (c % 2 == 0)
    tot += c;
    c++;
} while (c < 100);
Console.WriteLine("int c = 5;");
Console.WriteLine("int tot = 0;");
Console.WriteLine("do");
Console.WriteLine("{");
Console.WriteLine("if (c % 2 == 0)");
Console.WriteLine("tot += c;");
Console.WriteLine("c++;");
Console.WriteLine("} while (c < 100);");
Console.WriteLine("5 ile 100 arasındaki çift sayıların toplamı= " +tot);
    again();}
    
    else { 
        fail();
        again();
        }
break;
case 4:
Console.Clear();
Console.WriteLine("======================");
Console.WriteLine("Mükemmel Sayı Kontrolü");
Console.WriteLine("======================");
//4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

int sum = 0;
int i = 1;
Console.Write("Lütfen bir sayı giriniz: ");
int value = Convert.ToInt32(Console.ReadLine());
for (i= 1; i < value; i++) 
{
    if(value % i == 0)
    {
        sum = sum + i;
    } 
}   
if (sum == value)
    {
        Console.WriteLine("{0} sayısı, mükemmel sayıdır.", value);
        again();
        return;
        
    }
else 
    {
        Console.WriteLine("{0} sayısı, mükemmel sayı değildir.", value);
        again();
        return;
    }
    
case 5:
Console.Clear();
Console.WriteLine("================");
Console.WriteLine("String Metodları");
Console.WriteLine("================");
//5- String metotlarını araştırınız. Her bir metot için örnek yapınız.
Console.WriteLine("");
Console.WriteLine("'Pair 2' Ödev Çalışması");
Console.WriteLine("");
string text = "'Pair 2' Ödev Çalışması";
Console.WriteLine("-----");
Console.WriteLine("Contains öd:");
bool example = text.Contains("Öd");
Console.WriteLine(example);
Console.WriteLine("-----");
Console.WriteLine("EndsWith asi:");
bool example2 = text.EndsWith("asi");
Console.WriteLine(example2);
Console.WriteLine("-----");
Console.WriteLine("StartsWith P:");
bool example3 = text.StartsWith("P");
Console.WriteLine(example3);
Console.WriteLine("-----");
Console.WriteLine("Insert:");
string example4 = text.Insert(6, "no ");
Console.WriteLine(example4);
Console.WriteLine("-----");
Console.WriteLine("Remove:");
example4 = example4.Remove(11);
Console.WriteLine(example4);
Console.WriteLine("-----");
string example5 = text.Remove(13,5);
Console.WriteLine(example5);
Console.WriteLine("-----");
Console.WriteLine("Replace:");
string example6 = text.Replace("ı","i");
Console.WriteLine(example6);
Console.WriteLine("-----");
Console.WriteLine("Substring:");
string example7 = text.Substring(10);
Console.WriteLine(example7);
Console.WriteLine("-----");
string example8 = text.Substring(6,6);
Console.WriteLine(example8);
Console.WriteLine("-----");
Console.WriteLine("ToLower:");
string example9 = text.ToLower();
Console.WriteLine(example9);
Console.WriteLine("-----");
Console.WriteLine("ToUpper:");
string example10 = text.ToUpper();
Console.WriteLine(example10);
Console.WriteLine("-----");
Console.WriteLine("");
Console.WriteLine("  Ödev,deneme,örnek,kelimeler    ");
string text2 = "  Ödev,deneme,örnek,kelimeler    ";
Console.WriteLine("");
Console.WriteLine("-----");
Console.WriteLine("Split:");
string[] example11 = text2.Split(",");
for(int d = 0; d<example11.Length; d++)
{
    Console.WriteLine(example11[d]);
}
string example12 = text2.Trim();
Console.WriteLine("-----");
Console.WriteLine("Trim:");
Console.WriteLine(example12);
Console.WriteLine("-----");
Console.WriteLine("TrimEnd:");
string example13 = text2.TrimEnd();
Console.WriteLine(example13);
Console.WriteLine("-----");
Console.WriteLine("TrimStart:");
string example14 = text2.TrimStart();
Console.WriteLine(example14);
Console.WriteLine("-----");
again();
break;
case 6:
Console.Clear();
Console.WriteLine("=================================");
Console.WriteLine("300 TL altı ürünlere Kargo 50 TL");
Console.WriteLine("=================================");
//6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır.
// ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.

Console.Write("Lütfen ürün fiyatını giriniz: ");
double price = Convert.ToDouble(Console.ReadLine());
double shippingPrice = 50;
if (price < 300 && price >= 0){
    
    Console.WriteLine("Ödemeniz gereken tutar: " + (price+shippingPrice) + " TL");
}
else if (price >= 300.00 ){
    
    Console.WriteLine("Ödemeniz gereken tutar: " + price + " TL");
}
else {
    fail();
}
again();
break;
case 7:
Console.Clear();
Console.WriteLine("===================================");
Console.WriteLine("500 TL üzeri 2. ürün %40 İndirimli");
Console.WriteLine("===================================");
//7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 
//2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.

Console.Write("1. Ürünün Fiyatını Giriniz: ");
double product1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2. Ürünün Fiyatını Giriniz: ");
double product2 = Convert.ToDouble(Console.ReadLine());
double total = product1 + product2;
if(total >= 500 && product1 >= product2 && product1 >=0 && product2 >=0){
    double discountedSum = product1 + (product2 * 0.6);
    Console.WriteLine("Toplam Tutar: " + discountedSum + " TL" );
}
else if(total >= 500 && product1 < product2 && product1 >=0 && product2 >=0){
    double discountedSum = product2 + (product1 * 0.6);
    Console.WriteLine("Toplam Tutar: " + discountedSum + " TL" );
}
else if(total < 500 && product1 >=0 && product2 >=0){
    Console.WriteLine("Toplam Tutar: "+total +" TL");
}
else {
    fail();
}
again();
break;
case 8:
Console.Clear();
Console.WriteLine("===============================");
Console.WriteLine("3 veya 5'e Tam Bölünen Sayılar");
Console.WriteLine("===============================");
//8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen 
//ve kaç adet olduğunu yazdıran programı yazınız.
List<int> list = new List<int>();
int amount1 = 1;
for(int amount = 1; amount<200; amount++){

    if(amount % 3 == 0 || amount % 5 == 0){
        list.Add(amount1);
        Console.WriteLine("Kalansız bölünen: " + amount);
    }
}
Console.WriteLine("Kalansız bölünen toplam sayı: {0}" , + list.Count());
again();
break;
default:
    fail();
    again();
break;

}

}
static void problemList (){
    Console.WriteLine("1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.");
    Console.WriteLine("2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)");
    Console.WriteLine("3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.");
    Console.WriteLine("4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.");
    Console.WriteLine("5- String metotlarını araştırınız. Her bir metot için örnek yapınız.");
    Console.WriteLine("6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.");
    Console.WriteLine("7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.");
    Console.WriteLine("8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.");
}
static void again()
{
     Console.WriteLine("Soruları yeniden görüntülemek ister misiniz? (E/H)");
            switch(Console.ReadLine())
            {
                case ("E"):
                case ("e"):
                    work();
                    break;
                case ("H"):
                case ("h"):
                    Environment.Exit(0);
                    break;
                default:
                    fail();
                    again();
                    break;
            } 
}
static void fail(){
    Console.WriteLine("Hatalı bir işlem yaptınız...");
}

