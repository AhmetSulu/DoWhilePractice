

Console.WriteLine("Bir limit değeri giriniz. ");

int limit = int.Parse(Console.ReadLine());
int sayac = 0;

while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım.");

    sayac++;
}



//While döngüsünde önce koşula bakıldığı için -5 değeri ekrana cıktı vermez.
//Aşağıdaki do-while döngüsünde önçe cıktıya sonra koşula baktığı için -5 değerini 1 kere ekrana verir.


Console.WriteLine("Bir limit değeri giriniz:");
int limit2 = int.Parse(Console.ReadLine());

int sayac2 = 0;

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;

} while (sayac2 <= limit2);