// See https://aka.ms/new-console-template for more information

// In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programmi principali.
// void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina

Console.WriteLine("Quanti numeri vuoi inserire nell'array?");
int grandezzaArray = int.Parse(Console.ReadLine());
int[] arrayDiNumeri = ArrayUtente(grandezzaArray);
StampaArreyInteri(arrayDiNumeri);

void StampaArreyInteri(int[] arrayInteri)
{
    for (int i = 0; i < arrayInteri.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
            Console.Write(arrayInteri[0]);
            Console.Write(",");
        }
        else if (i > 0 && i < arrayInteri.Length - 1)
        {
            Console.Write(arrayInteri[i] + ",");
        }
        else
        {
            Console.Write(arrayInteri[i] + "]");
        }

    }
}
Console.WriteLine();
Console.WriteLine();

// int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.



int Quadrato(int numero)
{
    int n = (numero * numero);
    return n;
}

Console.WriteLine();

// int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.

StampaArreyInteri(ElevaArrayAlQuadrato(arrayDiNumeri));
Console.WriteLine();
StampaArreyInteri(arrayDiNumeri);


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayClone = (int[])array.Clone();

    for (int i = 0; i < arrayClone.Length; i++)
    {
        arrayClone[i] = (Quadrato(arrayClone[i]));
    }

    return arrayClone;

}

Console.WriteLine();
Console.WriteLine();

// int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.


Console.WriteLine(sommaElementiArray(arrayDiNumeri));

int sommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + (array[i]);
    }

    return somma;
}

Console.WriteLine();

// Stampa somma numeri al quadrato

Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrayDiNumeri)));

// A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.



int[] ArrayUtente(int grandezzaArray)
{
    int[] arrey = new int[grandezzaArray];
    for (int i = 0; i<grandezzaArray; i++)
    {
        Console.WriteLine("Inseriesca il numero:");
        int numeroUtente = int.Parse(Console.ReadLine());
        arrey[i] = numeroUtente;
    }
    return arrey;
}



