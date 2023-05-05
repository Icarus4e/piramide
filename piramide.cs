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