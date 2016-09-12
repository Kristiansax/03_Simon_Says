namespace _03_Simon_Says
{
    public class Simon
    {
        public string Echo(string x)
        {
            if (x == "hello")
                return "hello";
            else
                return "bye";
        }
        public string Shout(string x)
        {
            return x=x.ToUpper();
        }
        public string Repeat(string x)
        {
            return (x + " " + x);
        }
        public string Repeat(string x, int y)
        {
            string z = x;
            for (int i = 1; i < y; i++)
            {
                z = z + " " + x;
            }
            return z;

        }
        public string StartOfWord(string x, int y)
        {
            string z = "";
            for (int i = 0; i < y; i++)
            {
                z = z + x[i];
            }
            return z;
        }
        public string FirstWord(string x)
        {
            int y = 0;
            string z = "";
            while (!char.IsWhiteSpace(x[y]))
            {
                z = z + x[y++];
            }
            return z;
        }
    }
}