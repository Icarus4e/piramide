## Piramide
**  
Il compito consiste nello scrivere un programma che calcoli l'altezza massima di una piramide(in piani) e il numero di mattoni rimanenti, dati un certo numero di cubi:
 - I piani sono quadrati
 - La piramide è compatta, cioè non ci sono cavità al suo interno
 - Ogni piano ha una lunghezza laterale inferiore di due rispetto a quello sottostante
 - Il primo piano è sempre di un cubo
Il programma deve implementare i seguenti metodi:
 - int Piani(int mattoni): che torna il numero di piani della piramide che possono essere costruiti con il numero di cubi
 - int Rimanenti(int mattoni): che torna il numero di cubi rimanenti**

## Soluzione
La soluzione consiste in due cicli for annidati: il primo ciclo for scorre la stringa di cifre dall'inizio alla fine, il secondo ciclo for, che è interno al primo, scorre ogni serie di cifre di lunghezza span all'interno della stringa di cifre. In ogni iterazione del secondo ciclo for, viene calcolato il prodotto delle cifre nella serie utilizzando l'operatore di moltiplicazione. Se il prodotto ottenuto è maggiore del più grande prodotto calcolato fino a quel momento, il prodotto diventa il nuovo più grande prodotto. Prima di iniziare i cicli for, il metodo effettua alcune verifiche: se la lunghezza della serie di cifre span è negativa o supera la lunghezza della stringa di cifre digits, il metodo lancia un'eccezione. Inoltre, se la serie di cifre contiene caratteri non numerici, il metodo lancia un'altra eccezione.


    namespace Piramide {
    public static class Piramide {

        public static int Piani(int mattoni)
        {
            int piani =  0;
            int mattoniUsed = 0;
            while (mattoniUsed + (piani + 1) * (piani + 1) <= mattoni)
            {
                piani++;
                mattoniUsed += piani * piani;
            }
            return piani;
        }

        public static int Rimanenti(int mattoni)
        {
            int piani = Piani(mattoni);
            int mattoniUsed = 0;
            for (int i = 1; i <= piani; i++)
            {
                mattoniUsed += i * i;
            }
            return mattoni - mattoniUsed;
        }
    }
}

