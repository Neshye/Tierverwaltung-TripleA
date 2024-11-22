namespace TripleA
{
    public class Tierpfleger
    {
        private string name;
        private int anzFuetterungen = 0;
        private int lagerCounter = 0;

        public Tierpfleger(string name)
        {
            this.name = name;
        }
        public Tierpfleger() { }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getFuetterungen()
        {
            return anzFuetterungen;
        }

        public void setFuetterungen()
        {
            this.anzFuetterungen += 1;
        }

        public int getLagerCounter()
        {
            return lagerCounter;
        }

        public void setLagerCounter(int i)
        {
            this.lagerCounter += i;
        }

        public void resetLagerCounter()
        {
            this.lagerCounter = 0;
        }
    }
}
