using System.Numerics;
using System.Security.Cryptography;

namespace TI_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string s = "";
        string fileName;
        byte[] byteArray;
        byte[] byteArrayOut;
        string extension;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0) && (textBox_K.Text.Length > 0) )
            {
                BigInteger p = BigInteger.Parse(textBox_p.Text);
                BigInteger q = BigInteger.Parse(textBox_q.Text);
                BigInteger K = BigInteger.Parse(textBox_K.Text);
                if (MillerRabinTest(p, 100) && MillerRabinTest(q, 100))
                {
                    if (p == q)
                    {
                        MessageBox.Show("Числа должны быть разные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    BigInteger n;
                    try
                    {
                        n = p * q;
                        ushort.Parse(n.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Числа больше чем 2 байта!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    BigInteger m = (p - 1) * (q - 1);
                    BigInteger ko;
                    if (findNodEvclid(K, m)!=1)
                    {
                        MessageBox.Show("Функция эйлера и ключ должны быть взаимно простыми!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ko = Calculate_ko(m, K);
                    if (ko > 1 && ko < m && p>0 && q>0)
                    {
                        textBox_n.Text = n.ToString();
                        textBox_m.Text = m.ToString();
                        textBox_ko.Text = ko.ToString();
                        byte[] encodedBytes = textBoxInput.Text.Split(' ').Select(byte.Parse).ToArray();
                        int[] Cipher = new int[encodedBytes.Length];
                        for (int i = 0; i < encodedBytes.Length; i++)
                        {
                            string temp1 = encodedBytes[i].ToString();
                            BigInteger result = BigInteger.Parse(temp1);
                            Cipher[i] = ((int)BinaryPower(result, ko, n));
                        }
                        int temp = fileName.IndexOf(extension);
                        string pathout = fileName.Remove(temp, extension.Length);
                        pathout = pathout + "Output" + extension;
                        writeCipheredWord(pathout, Cipher);
                        textBoxOutput.Text = string.Join(" ", Cipher);
                    }
                    else {
                        MessageBox.Show("Неверные данные");
                    }
                }
                else
                {
                    MessageBox.Show("Неверные данные");
                }
            }
        }

        BigInteger findNodEvclid(BigInteger m, BigInteger n) {
            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }
            return n;
        }

        void writeCipheredWord(string path, int[] Cipher)
        {
            byte[] arr = new byte[Cipher.Length * 2];
            int j = -1;
            for (int i = 0; i < Cipher.Length; i++)
            {
                arr[++j] = (byte)(Cipher[i] >> 8);
                arr[++j] = (byte)(Cipher[i] & 255);
            }
            File.WriteAllBytes(path, arr);
        }

        private int BinaryPower(BigInteger basement, BigInteger exp, BigInteger mod)
        {
            BigInteger test;
            for (test = 1; exp > 0; exp >>= 1)
            {
                if ((exp & 1) == 1)
                    test = ((test % mod) * (basement % mod)) % mod;
                basement = ((basement % mod) * (basement % mod)) % mod;
            }
            return (int)test;
        }

        private BigInteger Calculate_ko(BigInteger m, BigInteger K)
        {
            if ((K % m != 0) || (m % K != 0))
            {
                BigInteger d0 = m;
                BigInteger d1 = K;
                BigInteger x0 = 1;
                BigInteger y0 = 0;
                BigInteger x1 = 0;
                BigInteger y1 = 1;
                BigInteger q;
                BigInteger d2;
                BigInteger x2;
                BigInteger y2;
                while (d1 > 1)
                {
                    q = d0 / d1;
                    d2 = d0 % d1;
                    x2 = x0 - q * x1;
                    y2 = y0 - q * y1;
                    d0 = d1;
                    d1 = d2;
                    x0 = x1;
                    x1 = x2;
                    y0 = y1;
                    y1 = y2;
                }
                if (y1 < 0)
                {
                    y1 += m;
                }
                return y1;
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
            return -1;
        }

        public bool MillerRabinTest(BigInteger n, int k)
        {
            if (n == 2 || n == 3)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;
            BigInteger t = n - 1;
            int s = 0;
            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }
            for (int i = 0; i < k; i++)
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] _a = new byte[n.ToByteArray().LongLength];
                BigInteger a;
                do
                {
                    rng.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= n - 2);
                BigInteger x = BigInteger.ModPow(a, t, n);
                if (x == 1 || x == n - 1)
                    continue;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }
                if (x != n - 1)
                    return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBoxInput.Text ="";
            textBoxOutput.Text = "";
            fileName = openFileDialog1.FileName;
            byte[] a = File.ReadAllBytes(fileName);
            textBoxInput.Text = String.Join(" ", a);
             extension = Path.GetExtension(fileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox_r.Text.Length > 0) && (textBox_ks.Text.Length > 0))
            {
                BigInteger r = BigInteger.Parse(textBox_r.Text);
                try
                {
                    ushort.Parse(r.ToString());
                }
                catch
                {
                    MessageBox.Show("r больше чем 2 байта!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                BigInteger ks = BigInteger.Parse(textBox_ks.Text);
                if (ks > 1 && ks < r)
                {
                    int[] ints = textBoxInput.Text.Split(' ').Select(int.Parse).ToArray();
                    byte[] Cipher = new byte[ints.Length];
                    for (int i = 0; i < ints.Length; i++)
                    {
                        string temp1 = ints[i].ToString();
                        BigInteger result = BigInteger.Parse(temp1);
                        Cipher[i] = (byte)BinaryPower(result, ks, r);
                    }
                    textBoxOutput.Text = String.Join(" ", Cipher);
                    int temp = fileName.IndexOf(extension);
                    string pathout = fileName.Remove(temp, extension.Length);
                    pathout = pathout + "Output" + extension;
                    byte[] OutText = new byte[Cipher.Length];
                    OutText = Cipher.Select(x => (byte)x).ToArray();
                    File.WriteAllBytes(pathout, OutText);
                }
                else {
                    MessageBox.Show("Неверные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = openFileDialog1.FileName;
            byte[] arr = File.ReadAllBytes(fileName);
            long size = new FileInfo(fileName).Length;
             size /= 2;
            int[] result = new int[size];
            int j = -1;
            for (int i = 0; i < size; i++)
                result[i] = (arr[++j] << 8) + arr[++j];
            textBoxInput.Text = string.Join(" ", result);
            extension = Path.GetExtension(fileName);
        }

        private void textBox_p_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_q_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_K_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_r_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_ks_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_p_TextChanged(object sender, EventArgs e)
        {

        }
    }
}