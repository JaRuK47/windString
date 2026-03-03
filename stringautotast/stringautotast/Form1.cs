namespace stringautotast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first, second;
            try
            {
                first = this.firstWord.Text.ToLower();
                second = this.secondWord.Text.ToLower();
            }
            catch (FormatException)
            {
                return;
            }
            List<string> results = Logic.Result(first, second);
            MessageBox.Show(string.Join(" ", results));
        }
    }

    public class Logic
    {
        public static List<string> Result(string first, string second)
        {
            var simvolF = new HashSet<char>();
            var simvolS = new HashSet<char>();

            for (int i = 0; i < first.Length; i++)
            {
                simvolF.Add(first[i]);
            }
            for (int i = 0; i < second.Length; i++)
            {
                simvolS.Add(second[i]);
            }

            List<string> results = new List<string>();

            foreach (char c in simvolF)
            {
                if (simvolS.Contains(c))
                {
                    results.Add("да");
                }
                else
                {
                    results.Add("нет");
                }
            }
            return results;
        }
    }
}
