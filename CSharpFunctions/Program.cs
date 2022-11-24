// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programmi principali.
//void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina

int [] arreyDiNumeri = { 9, 8, 7, 6, 5, 4};
StampaArreyInteri(arreyDiNumeri);

void StampaArreyInteri(int[] arrayInteri)
{
    for (int i = 0; i< arrayInteri.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
            Console.Write(arrayInteri[0]);
            Console.Write(",");
        } else if (i>0 && i< arrayInteri.Length - 1)
        {
            Console.Write(arrayInteri[i] + ",");
        } else
        {
            Console.Write(arrayInteri[i] + "]");
        }



    }
}