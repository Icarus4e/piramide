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
La soluzione del problema consiste nell'implementare due metodi in un programma: "Piani" e "Rimanenti".

Il metodo "Piani" calcola l'altezza massima della piramide (in piani) che può essere costruita con un dato numero di cubi di pietra. Il metodo fa uso di un ciclo while che decrementa il numero di cubi di pietra disponibili ad ogni piano costruito, finché non diventa insufficiente per costruire il piano successivo. In questo modo, il metodo restituisce il numero di piani completati.

Il metodo "Rimanenti" calcola il numero di cubi di pietra rimanenti dopo la costruzione completa della piramide. Per farlo, il metodo utilizza la formula aritmetica per la somma dei quadrati, che calcola il numero totale di cubi di pietra utilizzati per la costruzione della piramide, e lo sottrae dal numero di cubi di pietra disponibili.

```C#
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
```
