using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    
    public partial class A : Form
    {
        public A()
        {
            InitializeComponent();
        }

        rimski r1 = new rimski();
        rimski r2 = new rimski();
        big b1 = new big();
        big b2 = new big();

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void I_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (r1.cifre[0] <= 2)
                {
                    broj1.Text += 'I';
                    int p = r1.cifre[0];
                    for (int i = 0; i < 7;i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[0] = p + 1;
                }
            }
            else if (brojB.Checked)
            {
                if (r2.cifre[0] <= 2)
                {
                    broj2.Text += 'I';
                    int p = r2.cifre[0];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[0] = p + 1;
                }
            }
        }

        private void V_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if ((r1.cifre[1] == 0) && (r1.cifre[0] <= 0))
                {
                    broj1.Text += 'V';
                    int p = r1.cifre[1];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[1] = 1;
                }
                if ((r1.cifre[0] == 1) && (r1.cifre[1] == 0))
                {
                    broj1.Text += 'V';
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 6;
                    }
                }
            }
            else if (brojB.Checked)
            {
                if ((r2.cifre[1] == 0) && (r2.cifre[0] == 0))
                {
                    broj2.Text += 'V';
                    int p = r2.cifre[1];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[1] = 1;
                }
                if ((r2.cifre[0] == 1) && (r2.cifre[1] == 0))
                {
                    broj2.Text += 'V';
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 5;
                    }
                }
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if ((r1.cifre[2] <= 2) && (r1.cifre[1] == 0) && (r1.cifre[0] == 0))
                {
                    broj1.Text += 'X';
                    int p = r1.cifre[2];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[2] = p + 1;
                }
                if ((r1.cifre[0] == 1) && (r1.cifre[2] == 0))
                {
                    broj1.Text += 'X';
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 5;
                    }
                }
            }
            else if (brojB.Checked)
            {
                if ((r2.cifre[2] <= 2) && (r2.cifre[1] == 0) && (r2.cifre[0] == 0))
                {
                    broj2.Text += 'X';
                    int p = r2.cifre[2];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[2] = p + 1;
                }
                if ((r2.cifre[0] == 1) && (r2.cifre[2] == 0))
                {
                    broj2.Text += 'X';
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 5;
                    }
                }
            }
        }

        private void L_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if ((r1.cifre[3] == 0)&& (r1.cifre[1] == 0) && (r1.cifre[2] == 0) && (r1.cifre[0] == 0))
                {
                    broj1.Text += 'L';
                    int p = r1.cifre[3];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[3] = 1;
                }
                if ((r1.cifre[2] == 1) && (r1.cifre[3]) == 0)
                {
                    broj1.Text += 'L';
                    int p = r1.cifre[3];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[3] = p + 1;
                    r1.cifre[2] = 3;
                }
            }
            else if (brojB.Checked)
            {
                if ((r2.cifre[3] == 0) && (r2.cifre[1] == 0) && (r2.cifre[0] == 0))
                {
                    broj2.Text += 'L';
                    int p = r2.cifre[3];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[3] = 1;
                }
                if ((r2.cifre[2] == 1) && (r2.cifre[3]) == 0)
                {
                    broj2.Text += 'L';
                    int p = r2.cifre[3];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[3] = p + 1;
                    r2.cifre[2] = 3;
                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if ((r1.cifre[4] <= 2) && (r1.cifre[1] == 0) && (r1.cifre[0] == 0) && (r1.cifre[2] == 0) && (r1.cifre[3]==0))
                {
                    broj1.Text += 'C';
                    int p = r1.cifre[4];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[4] = p+1;
                }
                if ((r1.cifre[2] == 1) && (r1.cifre[4]) == 0)
                {
                    broj1.Text += 'C';
                    int p = r1.cifre[4];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[4] = p + 1;
                    r1.cifre[2] = 3;
                }

            }
            else if (brojB.Checked)
            {
                if ((r2.cifre[4] <= 2) && (r2.cifre[1] == 0) && (r2.cifre[0] == 0) && (r2.cifre[3] == 0))
                {
                    broj2.Text += 'C';
                    int p = r2.cifre[4];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[4] = p + 1;
                }
                if ((r2.cifre[2] == 1) && (r2.cifre[4]) == 0)
                {
                    broj2.Text += 'C';
                    int p = r2.cifre[4];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[4] = p + 1;
                    r2.cifre[2] = 3;
                }
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if ((r1.cifre[1] == 0) && (r1.cifre[0] == 0) && (r2.cifre[2] == 0) && (r1.cifre[3] == 0) && (r1.cifre[2] == 0) && (r1.cifre[4]<=0) && (r1.cifre[5] == 0))
                {
                    broj1.Text += 'D';
                    int p = r1.cifre[5];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[5] = p + 1;
                }
                if ((r1.cifre[4] == 1) && (r1.cifre[5]) == 0)
                {
                    broj1.Text += 'D';
                    int p = r1.cifre[6];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[5] = p + 1;
                    r1.cifre[4] = 3;
                }

            }
            else if (brojB.Checked)
            {
                if ((r2.cifre[1] == 0) && (r2.cifre[0] == 0) && (r2.cifre[3] == 0) && (r2.cifre[2] == 0) && (r2.cifre[4] <= 0) && (r2.cifre[5] == 0))
                {
                    broj2.Text += 'D';
                    int p = r2.cifre[5];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[5] = p + 1;
                }
                if ((r2.cifre[4] == 1) && (r2.cifre[5]) == 0)
                {
                    broj2.Text += 'D';
                    int p = r2.cifre[6];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[5] = p + 1;
                    r2.cifre[4] = 3;
                }
            }
        }

        private void M_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if ((r1.cifre[4] <= 0) && (r1.cifre[1] == 0) && (r1.cifre[0] == 0) && (r1.cifre[3] == 0) && (r1.cifre[2] == 0) && (r1.cifre[4] == 0) && (r1.cifre[5] == 0) && (r1.cifre[6] <= 3))
                {
                    broj1.Text += 'M';
                    int p = r1.cifre[6];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[6] = p + 1;
                }
                if ((r1.cifre[4] == 1) && (r1.cifre[6]) == 0)
                {
                    broj1.Text += 'M';
                    int p = r1.cifre[6];
                    for (int i = 0; i < 7; i++)
                    {
                        r1.cifre[i] = 0;
                    }
                    r1.cifre[6] = p + 1;
                    r1.cifre[4] = 3;
                }
            }
            else if (brojB.Checked)
            {
                if ((r2.cifre[4] <= 0) && (r2.cifre[1] == 0) && (r2.cifre[0] == 0) && (r2.cifre[2] == 0) && (r2.cifre[3] == 0) && (r2.cifre[4] == 0) && (r2.cifre[5] == 0) && (r2.cifre[6] <= 3))
                {
                    broj2.Text += 'M';
                    int p = r2.cifre[6];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[6] = p + 1;
                }
                if ((r2.cifre[4] == 1) && (r2.cifre[6]) == 0)
                {
                    broj2.Text += 'M';
                    int p = r2.cifre[6];
                    for (int i = 0; i < 7; i++)
                    {
                        r2.cifre[i] = 0;
                    }
                    r2.cifre[6] = p + 1;
                    r2.cifre[4] = 3;
                }
            }
        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                broj1.Text = "";
                for (int i = 0; i < 7; i++)
                {
                    r1.cifre[i] = 0;
                }
            }
            else if (brojB.Checked)
            {
                broj2.Text = "";
                for (int i = 0; i < 7; i++)
                {
                    r2.cifre[i] = 0;
                }
            }
        }

        private void rimski_CheckedChanged(object sender, EventArgs e)
        {
            if (rimski.Checked)
            {
                cifrerim.Visible = true;
            }
            else
            {
                cifrerim.Visible = false;
            }
            broj1.Text = "";
            broj2.Text = "";
        }

        private void veliki_CheckedChanged(object sender, EventArgs e)
        {
            if (veliki.Checked)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
            broj1.Text = "";
            broj2.Text = "";
        }

        private void svich_Click(object sender, EventArgs e)
        {
            string p = broj1.Text;
            broj1.Text = broj2.Text;
            broj2.Text = p;
            bool g = b1.zapeta;
            b1.zapeta = b2.zapeta;
            b2.zapeta = g;
            List<int> c = new List<int>();
            List<int> d = new List<int>();
            c = b1.ceo;
            b1.ceo = b2.ceo;
            b2.ceo = c;
            d = b1.decimalni;
            b1.ceo = b2.decimalni;
            b2.decimalni = d;
            g = b1.negativan;
            b1.negativan = b2.negativan;
            b2.negativan = g;

        }

        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) return "Ne postoji taj broj";
            else if (number < 1) return string.Empty;
            else if (number >= 1000) return "M" + ToRoman(number - 1000);
            else if (number >= 900) return "CM" + ToRoman(number - 900);
            else if (number >= 500) return "D" + ToRoman(number - 500);
            else if (number >= 400) return "CD" + ToRoman(number - 400);
            else if (number >= 100) return "C" + ToRoman(number - 100);
            else if (number >= 90) return "XC" + ToRoman(number - 90);
            else if (number >= 50) return "L" + ToRoman(number - 50);
            else if (number >= 40) return "XL" + ToRoman(number - 40);
            else if (number >= 10) return "X" + ToRoman(number - 10);
            else if (number >= 9) return "IX" + ToRoman(number - 9);
            else if (number >= 5) return "V" + ToRoman(number - 5);
            else if (number >= 4) return "IV" + ToRoman(number - 4);
            else if (number >= 1) return "I" + ToRoman(number - 1);
            else return "Ne postoji taj broj";
        }
        private void broj1_TextChanged(object sender, EventArgs e)
        {
            if (rimski.Checked)
            {
                int A = 0;
                for (int i = 0; i < broj1.Text.Length - 1; i++)
                {
                    if (broj1.Text[i] == 'I')
                    {
                        if (((broj1.Text[i + 1] == 'V') || (broj1.Text[i + 1] == 'X')) && ((i) < broj1.Text.Length))
                        {
                            A--;
                        }
                        else
                        {
                            A++;
                        }
                    }
                    else if (broj1.Text[i] == 'V')
                    {
                        A += 5;
                    }
                    else if (broj1.Text[i] == 'X')
                    {
                        if (((broj1.Text[i + 1] == 'L')) && ((i) < broj1.Text.Length))
                        {
                            A -= 10;
                        }
                        else
                        {
                            A += 10;
                        }
                    }
                    else if (broj1.Text[i] == 'C')
                    {
                        if (((broj1.Text[i + 1] == 'D') || (broj1.Text[i + 1] == 'M')) && ((i) < broj1.Text.Length))
                        {
                            A -= 100;
                        }
                        else
                        {
                            A += 100;
                        }
                    }
                    else if (broj1.Text[i] == 'L')
                    {
                        A += 50;
                    }
                    else if (broj1.Text[i] == 'D')
                    {
                        A += 500;
                    }
                    else if (broj1.Text[i] == 'M')
                    {
                        A += 1000;
                    }
                }
                if (broj1.Text.Length == 0) A = 0;
                else if (broj1.Text[broj1.Text.Length - 1] == 'I')
                {
                    A++;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'V')
                {
                    A += 5;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'X')
                {
                    A += 10;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'L')
                {
                    A += 50;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'C')
                {
                    A += 100;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'D')
                {
                    A += 500;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'M')
                {
                    A += 1000;
                }
                int B = 0;
                for (int i = 0; i < broj2.Text.Length - 1; i++)
                {
                    if (broj2.Text[i] == 'I')
                    {
                        if (((broj2.Text[i + 1] == 'V') || (broj2.Text[i + 1] == 'X')) && ((i) < broj2.Text.Length))
                        {
                            B--;
                        }
                        else
                        {
                            B++;
                        }
                    }
                    else if (broj2.Text[i] == 'V')
                    {
                        B += 5;
                    }
                    else if (broj2.Text[i] == 'X')
                    {
                        if (((broj2.Text[i + 1] == 'L')) && ((i) < broj2.Text.Length))
                        {
                            B -= 10;
                        }
                        else
                        {
                            B += 10;
                        }
                    }
                    else if (broj2.Text[i] == 'C')
                    {
                        if (((broj2.Text[i + 1] == 'D') || (broj2.Text[i + 1] == 'M')) && ((i) < broj2.Text.Length))
                        {
                            B -= 100;
                        }
                        else
                        {
                            B += 100;
                        }
                    }
                    else if (broj2.Text[i] == 'L')
                    {
                        B += 50;
                    }
                    else if (broj2.Text[i] == 'D')
                    {
                        B += 500;
                    }
                    else if (broj2.Text[i] == 'M')
                    {
                        B += 1000;
                    }
                }
                if (broj2.Text.Length == 0) B = 0;
                else if (broj2.Text[broj2.Text.Length - 1] == 'I')
                {
                    B++;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'V')
                {
                    B += 5;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'X')
                {
                    B += 10;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'L')
                {
                    B += 50;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'C')
                {
                    B += 100;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'D')
                {
                    B += 500;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'M')
                {
                    B += 1000;
                }
                sabiranje.Text = ToRoman(A + B);
                oduzimanje.Text = ToRoman(A - B);
                mnozenje.Text = ToRoman(A * B);
                if ((B != 0) && ((A % B) == 0))
                {
                    deljenje.Text = ToRoman(A / B);
                }
                else deljenje.Text = "Nece da moze";
            }
            else if (veliki.Checked)
            {

                if (b1.negativan && b2.negativan)
                {
                    sabiranje.Text = "-" + big.saberi(b1, b2);
                    oduzimanje.Text = "-" + big.oduzmi(b2, b1);
                    mnozenje.Text = big.mnozi(b1, b2);
                    deljenje.Text = big.deli(b1, b2);

                }
                else if (b1.negativan && !b2.negativan)
                {
                    sabiranje.Text = big.oduzmi(b2, b1);
                    oduzimanje.Text = "-" + big.saberi(b1, b2);
                    mnozenje.Text = "-" + big.mnozi(b1, b2);
                    deljenje.Text = "-" + big.deli(b1, b2);
                }
                else if (b2.negativan && !b1.negativan)
                {
                    sabiranje.Text = big.oduzmi(b1, b2);
                    oduzimanje.Text = big.saberi(b1, b2);
                    mnozenje.Text = "-" + big.mnozi(b1, b2);
                    deljenje.Text = "-" + big.deli(b1, b2);
                }
                else
                {
                    sabiranje.Text = big.saberi(b1, b2);
                    oduzimanje.Text = big.oduzmi(b1, b2);
                    mnozenje.Text = big.mnozi(b1, b2);
                    deljenje.Text = big.deli(b1, b2);

                }
            }
        }

        private void broj2_TextChanged(object sender, EventArgs e)
        {
            if (rimski.Checked)
            {
                int A = 0;
                for (int i = 0; i < broj1.Text.Length - 1; i++)
                {
                    if (broj1.Text[i] == 'I')
                    {
                        if (((broj1.Text[i + 1] == 'V') || (broj1.Text[i + 1] == 'X')) && ((i) < broj1.Text.Length))
                        {
                            A--;
                        }
                        else
                        {
                            A++;
                        }
                    }
                    else if (broj1.Text[i] == 'V')
                    {
                        A += 5;
                    }
                    else if (broj1.Text[i] == 'X')
                    {
                        if (((broj1.Text[i + 1] == 'L')) && ((i) < broj1.Text.Length))
                        {
                            A -= 10;
                        }
                        else
                        {
                            A += 10;
                        }
                    }
                    else if (broj1.Text[i] == 'C')
                    {
                        if (((broj1.Text[i + 1] == 'D') || (broj1.Text[i + 1] == 'M')) && ((i) < broj1.Text.Length))
                        {
                            A -= 100;
                        }
                        else
                        {
                            A += 100;
                        }
                    }
                    else if (broj1.Text[i] == 'L')
                    {
                        A += 50;
                    }
                    else if (broj1.Text[i] == 'D')
                    {
                        A += 500;
                    }
                    else if (broj1.Text[i] == 'M')
                    {
                        A += 1000;
                    }
                }
                if (broj1.Text.Length == 0) A = 0;
                else if (broj1.Text[broj1.Text.Length - 1] == 'I')
                {
                    A++;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'V')
                {
                    A += 5;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'X')
                {
                    A += 10;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'L')
                {
                    A += 50;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'C')
                {
                    A += 100;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'D')
                {
                    A += 500;
                }
                else if (broj1.Text[broj1.Text.Length - 1] == 'M')
                {
                    A += 1000;
                }
                int B = 0;
                for (int i = 0; i < broj2.Text.Length - 1; i++)
                {
                    if (broj2.Text[i] == 'I')
                    {
                        if (((broj2.Text[i + 1] == 'V') || (broj2.Text[i + 1] == 'X')) && ((i) < broj2.Text.Length))
                        {
                            B--;
                        }
                        else
                        {
                            B++;
                        }
                    }
                    else if (broj2.Text[i] == 'V')
                    {
                        B += 5;
                    }
                    else if (broj2.Text[i] == 'X')
                    {
                        if (((broj2.Text[i + 1] == 'L')) && ((i) < broj2.Text.Length))
                        {
                            B -= 10;
                        }
                        else
                        {
                            B += 10;
                        }
                    }
                    else if (broj2.Text[i] == 'C')
                    {
                        if (((broj2.Text[i + 1] == 'D') || (broj2.Text[i + 1] == 'M')) && ((i) < broj2.Text.Length))
                        {
                            B -= 100;
                        }
                        else
                        {
                            B += 100;
                        }
                    }
                    else if (broj2.Text[i] == 'L')
                    {
                        B += 50;
                    }
                    else if (broj2.Text[i] == 'D')
                    {
                        B += 500;
                    }
                    else if (broj2.Text[i] == 'M')
                    {
                        B += 1000;
                    }
                }
                if (broj2.Text.Length == 0) B = 0;
                else if (broj2.Text[broj2.Text.Length - 1] == 'I')
                {
                    B++;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'V')
                {
                    B += 5;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'X')
                {
                    B += 10;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'L')
                {
                    B += 50;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'C')
                {
                    B += 100;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'D')
                {
                    B += 500;
                }
                else if (broj2.Text[broj2.Text.Length - 1] == 'M')
                {
                    B += 1000;
                }
                sabiranje.Text = ToRoman(A + B);
                oduzimanje.Text = ToRoman(A - B);
                mnozenje.Text = ToRoman(A * B);
                if ((B != 0) && ((A % B) == 0))
                {
                    deljenje.Text = ToRoman(A / B);
                }
                else deljenje.Text = "Nece da moze";
            }
            else if (veliki.Checked)
            {
               if (b1.negativan && b2.negativan)
                {
                    sabiranje.Text = "-" + big.saberi(b1, b2);
                    oduzimanje.Text = "-" + big.oduzmi(b2, b1);
                    mnozenje.Text = big.mnozi(b1, b2);
                    deljenje.Text = big.deli(b1, b2);

                }
                else if (b1.negativan && !b2.negativan)
                {
                    sabiranje.Text = big.oduzmi(b2, b1);
                    oduzimanje.Text = "-" + big.saberi(b1, b2);
                    mnozenje.Text = "-" + big.mnozi(b1, b2);
                    deljenje.Text = "-" + big.deli(b1, b2);
                }
                else if (b2.negativan && !b1.negativan)
                {
                    sabiranje.Text = big.oduzmi(b1, b2);
                    oduzimanje.Text = big.saberi(b1, b2);
                    mnozenje.Text = "-" + big.mnozi(b1, b2);
                    deljenje.Text = "-" + big.deli(b1, b2);
                }
                else
                {
                    sabiranje.Text = big.saberi(b1, b2);
                    oduzimanje.Text = big.oduzmi(b1, b2);
                    mnozenje.Text = big.mnozi(b1, b2);
                    deljenje.Text = big.deli(b1, b2);
                    
                }

            }
        }

        private void decimala_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false) { b1.zapeta = true; broj1.Text += "."; }
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false) { b2.zapeta = true; broj2.Text += "."; }
            }
        }

        private void jedan_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(1);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(1);
                    b1.Id++;
                }
                broj1.Text += "1";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(1);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(1);
                    b2.Id++;
                }
                broj2.Text += "1";
            }
        }

        private void dva_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(2);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(2);
                    b1.Id++;
                }
                broj1.Text += "2";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(2);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(2);
                    b2.Id++;
                }
                broj2.Text += "2";
            }
        }

        private void tri_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(3);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(3);
                    b1.Id++;
                }
                broj1.Text += "3";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(3);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(3);
                    b2.Id++;
                }
                broj2.Text += "3";
            }
        }

        private void cetiri_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(4);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(4);
                    b1.Id++;
                }
                broj1.Text += "4";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(4);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(4);
                    b2.Id++;
                }
                broj2.Text += "4";
            }
        }

        private void pet_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(5);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(5);
                    b1.Id++;
                }
                broj1.Text += "5";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(5);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(5);
                    b2.Id++;
                }
                broj2.Text += "5";
            }
        }

        private void sest_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(6);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(6);
                    b1.Id++;
                }
                broj1.Text += "6";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(6);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(6);
                    b2.Id++;
                }
                broj2.Text += "6";
            }
        }

        private void sedam_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(7);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(7);
                    b1.Id++;
                }
                broj1.Text += "7";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(7);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(7);
                    b2.Id++;
                }
                broj2.Text += "7";
            }
        }

        private void osam_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(8);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(8);
                    b1.Id++;
                }
                broj1.Text += "8";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(8);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(8);
                    b2.Id++;
                }
                broj2.Text += "8";
            }
        }

        private void devet_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(9);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(9);
                    b1.Id++;
                }
                broj1.Text += "9";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(9);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(9);
                    b2.Id++;
                }
                broj2.Text += "9";
            }
        }

        private void nula_Click(object sender, EventArgs e)
        {
            if (brojA.Checked && (broj1.Text!="") && (broj1.Text != "-"))
            {
                if (b1.zapeta == false)
                {
                    b1.ceo.Add(0);
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni.Add(0);
                    b1.Id++;
                }
                broj1.Text += "0";
            }
            else if (brojB.Checked && (broj2.Text != "") && (broj2.Text!="-"))
            {
                if (b2.zapeta == false)
                {
                    b2.ceo.Add(0);
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni.Add(0);
                    b2.Id++;
                }
                broj2.Text += "0";
            }
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            if (brojA.Checked)
            {
                broj1.Text = "";
                b1 = new big();
            }
            else if (brojB.Checked)
            {
                broj2.Text = "";
                b2 = new big();
            }
        }

        private void negativ_Click(object sender, EventArgs e)
        {
            if (brojA.Checked && (broj1.Text == ""))
            {
                b1.negativan = true;
                broj1.Text += "-";
            }
            else if (brojB.Checked && (broj2.Text == ""))
            {
                b2.negativan = true;
                broj2.Text += "-";
            }
        }
    }
    class rimski
    {
        public string s;
        public int br;
        public int[] cifre = { 0, 0, 0, 0, 0, 0, 0 };
        public rimski(string s)
        {
            this.s = s;
        }
        public rimski()
        {

        }
    }

    class big
    {
        public List<int> ceo;
        public List<int> decimalni;
        public bool zapeta = false;
        public int Ic = 0;
        public int Id = 0;
        public bool negativan = false;
        public big()
        {
            ceo = new List<int>(524288);
            this.ceo.Add(0);
            decimalni = new List<int>(524288);
            this.decimalni.Add(0);
        }
        public static string saberi(big A, big B)
        {
            big C = new big();
            int p = 0;
            if (A.decimalni.Count < B.decimalni.Count)
            {
                for (int i = 0; i < B.decimalni.Count; i++)
                {
                    C.decimalni.Add(0);
                }
                for (int i = B.decimalni.Count - 1; i >= A.decimalni.Count; i--)
                {
                    C.decimalni[i] = B.decimalni[i];
                }
                for (int i = A.decimalni.Count - 1; i >= 0; i--)
                {
                    int z = p + A.decimalni[i] + B.decimalni[i];
                    if (z >= 10) { p = 1; z -= 10; } else p = 0; ;
                    C.decimalni[i] = z;
                }
            }
            else if (A.decimalni.Count > B.decimalni.Count)
            {
                for (int i = 0; i < A.decimalni.Count; i++)
                {
                    C.decimalni.Add(0);
                }
                for (int i = A.decimalni.Count - 1; i >= B.decimalni.Count; i--)
                {
                    C.decimalni[i] = A.decimalni[i];
                }
                for (int i = B.decimalni.Count - 1; i >= 0; i--)
                {
                    int z = p + B.decimalni[i] + A.decimalni[i];
                    if (z >= 10) { p = 1; z -= 10; } else p = 0; ;
                    C.decimalni[i] = z;
                }
            }
            else if (B.decimalni.Count == A.decimalni.Count)
            {
                for (int i = 0; i < B.decimalni.Count; i++)
                {
                    C.decimalni.Add(0);
                }
                for (int i = B.decimalni.Count - 1; i >= 0; i--)
                {
                    int z = p + B.decimalni[i] + A.decimalni[i];
                    if (z >= 10) { p = 1; z -= 10; } else p = 0;
                    C.decimalni[i] = z;
                }
            }
            if (C.decimalni[0] == 1) { p = 1; }
            if (A.ceo.Count > B.ceo.Count)
            {
                C.ceo = new List<int>();
                for (int i = 0; i < A.ceo.Count; i++)
                {
                    C.ceo.Add(0);
                }
                for (int i = 0; i < B.ceo.Count; i++)
                {
                    int z = p + A.ceo[A.ceo.Count - i-1] + B.ceo[B.ceo.Count - i-1];
                    if (z >= 10) { p = 1; z -= 10; } else p = 0;
                    C.ceo[C.ceo.Count-i-1] = z;
                }
                for (int i = 0; i <= A.ceo.Count - B.ceo.Count - 1; i++)
                {
                    int z = p + A.ceo[i];
                    if (z >= 10) { p = 1; z -= 10; } else p = 0;
                    C.ceo[i] = z; 
                }
            }
            else if (A.ceo.Count < B.ceo.Count)
            {
                C.ceo = new List<int>();
                for (int i = 0; i < B.ceo.Count; i++)
                {
                    C.ceo.Add(0);
                }
                for (int i = 0; i < A.ceo.Count; i++)
                {
                    int z = p + A.ceo[A.ceo.Count - i-1] + B.ceo[B.ceo.Count - i-1];
                    if (z >= 10) { p = 1; z -= 10; } else p = 0;
                    C.ceo[C.ceo.Count - i-1] = z;
                }
                for (int i = 1; i <= B.ceo.Count - A.ceo.Count - 1; i++)
                {
                    int z = p + B.ceo[i];
                    if (z >= 10) { p = 1; z -= 10; } else p = 0;
                    C.ceo[i] = z;

                }
            }
            else if (A.ceo.Count == B.ceo.Count)
            {
                C.ceo = new List<int>();
                for (int i = 0; i < B.ceo.Count; i++)
                {
                    C.ceo.Add(0);
                }
                for (int i = 0; i < A.ceo.Count; i++)
                {
                    int z = p + A.ceo[A.ceo.Count - i-1] + B.ceo[B.ceo.Count - i-1];
                    if (z >= 10) { p = 1; z -= 10; } else p = 0;
                    C.ceo[C.ceo.Count -i- 1] = z;
                }
            }
            
            if (p == 1) { C.ceo[0]++; }
            string rez = "";
            for (int i = 0; i < C.ceo.Count; i++)
            {
                rez += C.ceo[i];
            }
            rez += ".";
            for (int i = 1; i < C.decimalni.Count; i++)
            {
                rez += C.decimalni[i];
            }
            return rez;
        }
        public static string oduzmi(big A,big B)
        {
            bool neg = false;
            big C = new big();
            if (A.ceo.Count > B.ceo.Count)
            {
                int r = A.ceo.Count - B.ceo.Count;
                C.ceo = new List<int>();
                for (int i = 0; i < A.ceo.Count; i++)
                {
                    C.ceo.Add(0);
                }
                for (int i = 0; i < r; i++)
                {
                    C.ceo[i] = A.ceo[i];
                }
                for (int i = r; i < A.ceo.Count; i++)
                {
                    int z = 0;
                    if (A.ceo[i] < B.ceo[i - r])
                    {
                        z = A.ceo[i] + 10 - B.ceo[i - r];
                        C.ceo[i - 1]--;
                    }
                    else
                    {
                        z = A.ceo[i] - B.ceo[i - r];
                    }
                    C.ceo[i] = z;
                }
            }
            else if (A.ceo.Count < B.ceo.Count)
            {
                neg = true;
                int r = B.ceo.Count - A.ceo.Count;
                C.ceo = new List<int>();
                for (int i = 0; i < B.ceo.Count; i++)
                {
                    C.ceo.Add(0);
                }
                for (int i = 0; i < r; i++)
                {
                    C.ceo[i] = B.ceo[i];
                }
                C.ceo[0] -= C.ceo[0] * 2;
                for (int i = r; i < B.ceo.Count; i++)
                {
                    int z = 0;
                    if (A.ceo[i - r] > B.ceo[i])
                    {
                        z = B.ceo[i] + 10 - A.ceo[i - r];
                        C.ceo[i - 1]--;
                    }
                    else
                    {
                        z = B.ceo[i] - A.ceo[i - r];
                    }
                    C.ceo[i] = z;

                }
            }
            else if ((A.ceo.Count == B.ceo.Count)&&(A.ceo.Count>1))
            {
                C.ceo = new List<int>();
                int j = 0;
                while ((A.ceo[j] == B.ceo[j]) && (j < A.ceo.Count-1))
                {
                    j++;
                }
                if (j < A.ceo.Count)
                {
                    if (A.ceo[j] < B.ceo[j]) neg = true;
                }
                else
                {
                    j = 0;
                    while ((A.decimalni[j] == B.decimalni[j]) || (j < A.decimalni.Count))
                    {
                        j++;
                    }

                    if (j < A.decimalni.Count)
                    {
                        if (A.decimalni[j] < B.decimalni[j]) neg = true;
                    }
                }
                for (int i = 0; i < B.ceo.Count; i++)
                {
                    C.ceo.Add(0);
                }
                if (A.ceo[0] < B.ceo[0])
                {
                    C.ceo[0] = A.ceo[0] - B.ceo[0];
                }
                for (int i = 1; i < A.ceo.Count; i++)
                {
                    int z = 0;
                    if (A.ceo[i] < B.ceo[i])
                    {
                        z = A.ceo[i] + 10 - B.ceo[i];
                        C.ceo[i - 1]--;
                    }
                    else
                    {
                        z = A.ceo[i] - B.ceo[i];
                    }
                    C.ceo[i] = z;
                }

            }
            if (A.decimalni[0] < B.decimalni[0])
            {
                C.ceo[C.ceo.Count - 1]--;
                C.decimalni.Add(10 + A.decimalni[0] - B.decimalni[0]);
            }
            else
            {
                C.decimalni.Add(A.decimalni[0] - B.decimalni[0]);
            }
            if (A.decimalni.Count < B.decimalni.Count)
            {
                for (int i = 1; i < A.decimalni.Count; i++)
                {
                    C.decimalni.Add(0);
                    int z = 0;
                    if (A.decimalni[i] < B.decimalni[i])
                    {
                        z = A.decimalni[i] + 10 - B.decimalni[i];
                        C.decimalni[i - 1]--;
                    }
                    else
                    {
                        z = A.decimalni[i] - B.decimalni[i];
                    }
                    C.decimalni[i] = z;
                }
                for (int i = A.decimalni.Count; i < B.decimalni.Count; i++)
                {
                    C.decimalni.Add(0);
                    C.decimalni[i]=(10 - B.decimalni[i]);
                    C.decimalni[i - 1]--;
                }
            }
            if (A.decimalni.Count > B.decimalni.Count)
            {
                for (int i = 1; i < B.decimalni.Count; i++)
                {
                    C.decimalni.Add(0);
                    int z = 0;
                    if (A.decimalni[i] < B.decimalni[i])
                    {
                        z = A.decimalni[i] + 10 - B.decimalni[i];
                        C.decimalni[i - 1]--;
                    }
                    else
                    {
                        z = A.decimalni[i] - B.decimalni[i];
                    }
                    C.decimalni[i] = z;
                }
                for (int i = B.decimalni.Count; i < A.decimalni.Count; i++)
                {
                    C.decimalni.Add(0);
                    C.decimalni[i]=(A.decimalni[i]);
                }
            }
            else if (A.decimalni.Count == B.decimalni.Count)
            {
                for (int i = 1; i < B.decimalni.Count; i++)
                {
                    C.decimalni.Add(0);
                    int z = 0;
                    if (A.decimalni[i] < B.decimalni[i])
                    {
                        z = A.decimalni[i] + 10 - B.decimalni[i];
                        C.decimalni[i - 1]--;
                    }
                    else
                    {
                        z = A.decimalni[i] - B.decimalni[i];
                    }
                    C.decimalni[i] = z;
                }
                if (A.decimalni.Count > 1)
                {
                    if (A.decimalni[1] < B.decimalni[1])
                    {
                        C.ceo[C.ceo.Count - 1]--;
                    }
                }
            }
            bool change = true;
            while (change != false)
            {
                change = false;
                for (int i = 0; i < C.ceo.Count;i++)
                {
                    if (C.ceo[i] == -1)
                    {
                        C.ceo[i]=9;
                        if (i != 0)
                        {
                            C.ceo[i - 1]--;
                        }
                        else neg = true;
                        change = true;
                        break;
                    }
                }
                for (int i = 0; i < C.decimalni.Count; i++)
                {
                    if (C.decimalni[i] == -1)
                    {
                        C.decimalni[i]=9;
                        if (i != 0)
                        {
                            C.decimalni[i - 1]--;
                        }
                        else
                        {
                            C.ceo[C.ceo.Count-1 ]--;
                        }
                        change = true;
                        break;
                    }
                }
            }
            string rez = "";
            if (neg) { rez = oduzmi(B, A);
                return "-" + rez;
            }
            
            for (int i = 0; i < C.ceo.Count; i++)
            {
                rez += C.ceo[i];
            }
            rez += ".";
            for (int i = 1; i < C.decimalni.Count; i++)
            {
                rez += C.decimalni[i];
            }
            return rez;
        }
        public static string mnozi(big A, big B)
        {
            List<int> C = new List<int>();
            List<int> ac = new List<int>();
            List<int> bc = new List<int>();
            List<int> ad = new List<int>();
            List<int> bd = new List<int>();
            for (int i = 0; i < A.ceo.Count; i++)
            {
                ac.Add(A.ceo[i]);
            }
            if (A.decimalni.Count > 1)
            {
                for (int i = 1; i < A.decimalni.Count; i++)
                {
                    ad.Add(A.decimalni[i]);
                }
            }
            for (int i = 0; i < B.ceo.Count; i++)
            {
                bc.Add(B.ceo[i]);
            }
            if (B.decimalni.Count > 1)
            {
                for (int i = 1; i < B.decimalni.Count; i++)
                {
                    bd.Add(B.decimalni[i]);
                }
            }
            string Ac = "";
            if (ac.Count == 0)
            {
                Ac = "0";
            }
            else
            {
                Ac = uString(ac);
            }
            string Ad = "";
            if (ad.Count == 0)
            {
                Ad = "0";
            }
            else
            {
                Ad = uString(ad);
            }
            string Bc = "";
            if (bc.Count == 0)
            {
                Bc = "0";
            }
            else
            {
                Bc = uString(bc);
            }
            string Bd = "";
            if (bd.Count == 0)
            {
                Bd = "0";
            }
            else
            {
                Bd = uString(bd);
            }
            string As = Ac + "." + Ad;
            string Bs = Bc + "." + Bd;
            string rez = Pomnozi(As,Bs);
            /*
            for (int i = 0; i < a.Count+b.Count; i++)
            {
                C.Add(0);
            }
            if ((a.Count > 1) && (b.Count > 1))
            {
                for (int i = b.Count - 1; i >= 0; i--)
                {
                    for (int j = a.Count - 1; j >= 0; j--)
                    {
                        int z = p + a[j] * b[i];
                        int c = z % 10;
                        p = z / 10;
                        C[i + j] += c;
                    }
                }
                C[0] += p;
            }
            else
            {
                C = new List<int>();
                C.Add(0);
                return "0";
            }
            string rez = "";/*
            for (int i = 0; i < C.Count-A.decimalni.Count - B.decimalni.Count + 1; i++)
            {
                rez += C[i];
            }
            rez += ".";
            if ((A.decimalni.Count > 1) || (B.decimalni.Count > 1))
            {
                for (int i = C.Count - A.decimalni.Count - B.decimalni.Count + 1; i < C.Count; i++)
                {
                    rez += C[i];
                }
            }*/
            return rez;
        }
        /*static string Divide(List<int> dividend, List<int> divisor, int precision)
        {
            if (IsZero(divisor))
            {
                // Divisor is zero, return 0
                return "Divisor cannot be zero.";
            }

            List<int> result = new List<int>();
            List<int> quotient = new List<int>();
            List<int> remainder = new List<int>(dividend);

            // Handle integral part
            while (IsGreaterOrEqual(remainder, divisor))
            {
                Subtract(remainder, divisor);
                Increment(quotient);
            }

            result.AddRange(quotient);
            if (result.Count == 0)
            {
                result.Add(0);
            }

            // Handle fractional part
            if (precision > 0)
            {
                result.Add(-1); // -1 represents the position of the decimal point

                // Add leading zeros for fractional part if necessary
                while (precision > remainder.Count)
                {
                    remainder.Add(0);
                }

                for (int i = 0; i < precision; i++)
                {
                    MultiplyBy10(remainder);
                    int digit = 0;
                    while (IsGreaterOrEqual(remainder, divisor))
                    {
                        Subtract(remainder, divisor);
                        digit++;
                    }
                    result.Add(digit);
                }
            }

            // Convert result list to string
            string resultString = "";
            bool pointInserted = false;
            foreach (int digit in result)
            {
                if (digit == -1)
                {
                    resultString += ".";
                    pointInserted = true;
                }
                else
                {
                    if (pointInserted)
                        resultString += digit.ToString();
                    else
                        resultString += digit.ToString();
                }
            }

            return resultString;
        }

        static bool IsGreaterOrEqual(List<int> a, List<int> b)
        {
            if (a.Count > b.Count)
                return true;
            if (a.Count < b.Count)
                return false;

            for (int i = a.Count - 1; i >= 0; i--)
            {
                if (a[i] > b[i])
                    return true;
                if (a[i] < b[i])
                    return false;
            }

            return true;
        }

        static void Subtract(List<int> a, List<int> b)
        {
            int borrow = 0;

            for (int i = 0; i < a.Count; i++)
            {
                int sub = a[i] - borrow - (i < b.Count ? b[i] : 0);
                if (sub < 0)
                {
                    sub += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }
                a[i] = sub;
            }

            while (a.Count > 1 && a[a.Count - 1] == 0)
            {
                a.RemoveAt(a.Count - 1);
            }
        }

        static void Increment(List<int> number)
        {
            int carry = 1;
            for (int i = 0; i < number.Count; i++)
            {
                int sum = number[i] + carry;
                number[i] = sum % 10;
                carry = sum / 10;
            }
            if (carry > 0)
            {
                number.Add(carry);
            }
        }

        static void MultiplyBy10(List<int> number)
        {
            number.Insert(0, 0);
        }

        static bool IsZero(List<int> number)
        {
            foreach (int digit in number)
            {
                if (digit != 0)
                    return false;
            }
            return true;
        }*/
        public static string deli(big A, big B)
        {

            /*List<int> c = new List<int>();
            big a = new big();
            big b = new big();
            for (int i = 0; i < A.ceo.Count; i++)
            {
                a.ceo.Add(A.ceo[i]);
            }
            for (int i = 0; i < B.ceo.Count; i++)
            {
                b.ceo.Add(B.ceo[i]);
            }
            if (A.decimalni.Count > B.decimalni.Count)
            {
                if (A.decimalni.Count > 1)
                {
                    for (int i = 1; i < A.decimalni.Count; i++)
                    {
                        a.ceo.Add(A.decimalni[i]);
                    }
                }
                if (B.decimalni.Count > 1)
                {
                    for (int i = 0; i < B.ceo.Count; i++)
                    {
                        b.ceo.Add(B.ceo[i]);
                    }
                }
                for (int i = 0; i< A.decimalni.Count - B.decimalni.Count; i++)
                {
                    b.ceo.Add(0);
                }
            }
            else if (A.decimalni.Count < B.decimalni.Count)
            {
                if (A.decimalni.Count > 1)
                {
                    for (int i = 1; i < A.decimalni.Count; i++)
                    {
                        a.ceo.Add(A.decimalni[i]);
                    }
                }
                if (B.decimalni.Count > 1)
                {
                    for (int i = 0; i < B.ceo.Count; i++)
                    {
                        b.ceo.Add(B.ceo[i]);
                    }
                }
                else return "";
                for (int i = 0; i < B.decimalni.Count - A.decimalni.Count; i++)
                {
                    a.ceo.Add(0);
                }
            }
            else
            {
                if (A.decimalni.Count > 1)
                {
                    for (int i = 1; i < A.decimalni.Count; i++)
                    {
                        a.ceo.Add(A.decimalni[i]);
                    }
                }
                if (B.decimalni.Count > 1)
                {
                    for (int i = 0; i < B.ceo.Count; i++)
                    {
                        b.ceo.Add(B.ceo[i]);
                    }
                }
                else return "";
            }
            string f = "";
            for (int i = 0; i < a.ceo.Count; i++) f += a.ceo[i];
            return f;
            //return Divide(a.ceo,b.ceo,30);
            
            for (int i = 0; i<a.ceo.Count+30; i++)
            {
                c.Add(0);
            }
            string rez = "";
            big nul = new big();
            big jed = new big();
            big dva = new big();
            big tri = new big();
            big cet = new big();
            big pet = new big();
            big ses = new big();
            big sed = new big();
            big osa = new big();
            big dev = new big();
            nul.ceo.Add(0);
            jed.ceo.Add(1);
            dva.ceo.Add(2);
            tri.ceo.Add(3);
            cet.ceo.Add(4);
            pet.ceo.Add(5);
            ses.ceo.Add(6);
            sed.ceo.Add(7);
            osa.ceo.Add(8);
            dev.ceo.Add(9);
            big[] brojevi = { nul, jed, dva, tri, cet, pet, ses, sed, osa, dev };
            if (a.ceo.Count == b.ceo.Count)
            {
                int br = 0;
                while ((a.ceo[1] != 0) || (c[c.Count - 1] != 0))
                {
                    int n = 0;
                    for (int i = 9; i >= 0; i--)
                    {
                        big D = new big();
                        for (int j = 0; j < mnozi(b, brojevi[i]).Length; j++)
                        {
                            D.ceo.Add(mnozi(b, brojevi[i])[j]);
                        }
                        if (oduzmi(a, D)[0] != '-')
                        {
                            n = i;
                            string s = oduzmi(a, D);
                            a.ceo = new List<int>();
                            for(int j = 0; j < s.Length; j++)
                            {
                                a.ceo.Add(s[j]);
                            }
                            a.ceo.Add(0);
                            break;
                        }
                    }
                    c[br] = n;
                    br++;
                }
                rez = c[0] + ".";
                if (c.Count > 1) {
                    for (int i = 1; i < c.Count; i++) 
                    {
                        rez += c[i];
                    } 
                }
            }
            
            return rez;*/
            if ((!A.zapeta) && !B.zapeta)
            {
                string a = uString(A.ceo);
                string b = uString(B.ceo);
                string c = Podeli(a, b);
                return c;
            }
            else if (!A.zapeta)
            {
                string Bc = uString(B.ceo);
                string Bd = uString(B.decimalni);
                Bd = Bd.Substring(1);
                if (Bd == "") { Bd = "0"; }
                string b = Bc + Bd;
                List<int> Ac = A.ceo;
                /*for (int i = 0; i < Bd.Length; i++)
                {
                    Ac.Add(0);
                }*/
                string a = uString(Ac);
                if ((Bc == "0") && (Bd == "1")) return (Pomnozi(a, "10"));
                if ((Bc == "0") && (Bd == "01")) return (Pomnozi(a, "100"));
                if ((Bc == "0") && (Bd == "001")) return (Pomnozi(a, "1000"));
                if ((Bc == "0") && (Bd == "0001")) return (Pomnozi(a, "10000"));
                if ((Bc == "0") && (Bd == "00001")) return (Pomnozi(a, "10000"));
                if ((Bc == "0") && (Bd == "000001")) return (Pomnozi(a, "100000"));
                if ((Bc == "0") && (Bd == "0000001")) return (Pomnozi(a, "1000000"));
                if ((Bc == "0") && (Bd == "00000001")) return (Pomnozi(a, "10000000"));
                if ((Bc == "0") && (Bd == "000000001")) return (Pomnozi(a, "100000000"));
                if ((Bc == "0") && (Bd == "0000000001")) return (Pomnozi(a, "1000000000"));
                string c = Podeli(a, b);
                if (c != "Ne mozete deliti sa 0")
                {
                    int e = c.IndexOf('.');
                    if (e != -1)
                    {
                        c = c.Remove(e, 1);
                    }
                    if (e == -1)
                    {
                        for (int i = 0; i < Bd.Length; i++)
                        {
                            c += "0";
                        }
                    }
                    else if (Bd.Length != 0)
                    {
                        c = c.Insert((e + Bd.Length), ".");
                    }
                }
                return c;
            }
            else if (!B.zapeta)
            {
                string Ac = uString(A.ceo);
                string Ad = uString(A.decimalni);
                Ad = Ad.Substring(1);
                if (Ad == "") { Ad = "0"; }
                string a = Ac + Ad;
                List<int> Bc = B.ceo;
                /*for (int i = 0; i < Ad.Length; i++)
                {
                    Bc.Add(0);
                }*/
                string b = uString(Bc);
                string c = Podeli(a, b);
                if (c != "Ne mozete deliti sa 0")
                {
                    int e = c.IndexOf('.');
                    if (e != -1)
                    {
                        c = c.Remove(e, 1);
                    }
                    if (e == -1)
                    {
                        c = c.Insert((c.Length-Ad.Length), ".");
                    }
                    else if (e > Ad.Length)
                    {
                        if (Ad.Length != 0)
                        {
                            c = c.Insert((e - Ad.Length), ".");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Ad.Length - e + 1; i++)
                        {
                            c = "0" + c;
                        }
                        c=c.Insert(1, ".");
                    }
                }
                return c;
            }
            else
            {
                string Ac = uString(A.ceo);
                string Ad = uString(A.decimalni);
                if (Ad == "") { Ad = "0"; }
                Ad = Ad.Substring(1);
                string a = Ac + Ad;
                string Bc = uString(B.ceo);
                string Bd = uString(B.decimalni);
                Bd = Bd.Substring(1);
                if (Bd == "") { Bd = "0"; }
                string b = Bc + Bd;
                /*if (a.Length > b.Length)
                {
                    for (int i = 0; i < a.Length - b.Length; i++)
                    {
                        b += '0';
                    }
                }
                else if (a.Length < b.Length)
                {
                    for (int i = 0; i < b.Length - a.Length; i++)
                    {
                        a += '0';
                    }
                }*/
                string c = Podeli(a, b);
                if (c != "Ne mozete deliti sa 0")
                {
                    int e = c.IndexOf(".");
                    if (e != -1)
                    {
                        c = c.Remove(e, 1);
                    }
                    if ((Bd.Length != 0) && (Ad.Length != 0))
                    {
                        if (e == -1)
                        {
                            c = c.Insert(c.Length + Bd.Length - Ad.Length, ".");
                        }
                        else if (e + Bd.Length - Ad.Length > 0)
                        {
                            c = c.Insert(e + Bd.Length - Ad.Length, ".");
                        }
                        else if (Ad.Length >= e + Bd.Length)
                        {
                            for (int i = 0; i < Ad.Length - Bd.Length ; i++)
                            {
                                c = "0" + c;
                            }
                            c = c.Insert(1, ".");
                        }
                    }
                }
                return c;
            }
        }
        public static string skratiNule(string a)
        {
            int i = 0;
            List<char> A = PrebaciUListu(a);
            if (a[0] != '0') return a;
            while (A[0] != 0)
            {
                for (int j = 1; j < A.Count; j++)
                {
                    A[j - 1] = A[j];
                }
                A.RemoveAt(A.Count - 1);
                i++;
                if (i == a.Length) 
                { 
                    return "0";  
                }
            }
            a = UString(A);
            return a;
        }
        public static string uString(List<int> A)
        {
            string s = string.Join("", A);
            skratiNule(s);
            return s;
        }
        public static string UString(List<char> A)
        {
            string s = "";
            for (int i = 0; i < A.Count; i++)
            {
                s += A[i];
            }
            return s;
        }
        public static string TrimZerosFromDecimal(string number)
        {
            int decimalIndex = number.IndexOf('.');

            if (decimalIndex == -1)
                return number;

            int endIndex = number.Length - 1;
            while (endIndex > decimalIndex && number[endIndex] == '0')
            {
                endIndex--;
            }

            if (number[endIndex] == '.')
            {
                endIndex--;
            }

            return number.Substring(0, endIndex + 1);
        }
        static List<char> PrebaciUListu(string input)
        {
            List<char> charList = new List<char>();
            foreach (char c in input)
            {
                charList.Add(c);
            }
            return charList;
        }
        public static string Podeli(string a, string b)
        {
            if ((b == "0") || (b=="00") || (b == "000") || (b == "0000") || (b == "00000") || (b == "000000") || (b == "0000000") || (b == "00000000") || (b == "000000000") || (b == "0000000000") || (b == "00000000000") || (b == "000000000000") || (b == "0000000000000") || (b == "00000000000000") || (b == "000000000000000") || (b == "0000000000000000") || (b == "00000000000000000") || (b == "000000000000000000") || (b == "0000000000000000000") || (b == "00000000000000000000") || (b == "000000000000000000000") || (b == "0000000000000000000000") || (b == "00000000000000000000000") || (b == "000000000000000000000000") || (b == "0000000000000000000000000") || (b == "00000000000000000000000000") || (b == "000000000000000000000000000") || (b == "0000000000000000000000000000") || (b == "00000000000000000000000000000") || (b == "000000000000000000000000000000")) return "Ne mozete deliti sa 0";
            string rez = string.Empty;
            string kol = Kolicnik(a, b);
            string temp = Oduzmi(a, Pomnozi(kol, b));
            if (temp == "0") return rez + kol;
            else rez = rez + kol + ".";
            //int br_decimala = int.Parse(Form1.form1instance.textBox4.Text);
            for (int i = 0; i < 42; i++)
            {
                if (temp == "0") break;
                temp = temp + "0";
                kol = Kolicnik(temp, b);
                rez = rez + kol;
                temp = Oduzmi(temp, Pomnozi(kol, b));
            }
            return rez;
        }
        public static string Kolicnik(string a, string b)
        {
            
            if (a == "0") return "0";
            skratiNule(a);
            skratiNule(b);
            if (Uporedi(a, b) == 2) return "0";
            string pom1 = a;
            string rez = string.Empty;
            if (b[0] == '0')
            {
                pom1 = "0" + pom1;
            }
            string s1 = pom1.Substring(0, b.Length);
            if (Uporedi(b, s1) == 1)
            {
                s1 = pom1.Substring(0, b.Length + 1);
            }
            int duzina = s1.Length;
            for (int i = duzina; i <= pom1.Length; i++)
            {
                int kol = Podeli_Medjurezultat(s1, b);
                rez = rez + kol;
                if (i == pom1.Length) break;
                s1 = Oduzmi(s1, Pomnozi(kol.ToString(), b));
                if (s1 == "0") { s1 = (pom1[i] - '0').ToString(); }
                else s1 = s1 + pom1[i];
            }
            return rez;
        }
        public static string Oduzmi(string a, string b)
        {
            

            if (a == b) return "0";
            if (!Decimalan(a) && !Decimalan(b))
            {
                string pom1 = a;
                string pom2 = b;
                pom1 = pom1 + "." + "0";
                pom2 = pom2 + "." + "0";
                string rez = Oduzmi(pom1, pom2);
                rez = rez.TrimEnd('0');
                rez = rez.Replace(".", string.Empty);
                return rez;

            }
            if (Decimalan(a) && Decimalan(b))
            {
                if (a == b) return "0";
                string pom1 = a;
                string pom2 = b;
                int mz1 = MestoZareza(a);
                int mz2 = MestoZareza(b);
                string minus = string.Empty;
                if (mz1 > mz2)
                {
                    for (int i = 0; i < (mz1 - mz2); i++) { pom2 = "0" + pom2; }
                }
                else if (mz1 < mz2)
                {
                    for (int i = 0; i < (mz2 - mz1); i++) { pom1 = "0" + pom1; }
                }
                int n1 = pom1.Length;
                int n2 = pom2.Length;
                if (n1 > n2)
                {
                    for (int i = 0; i < (n1 - n2); i++) { pom2 = pom2 + "0"; }
                }
                else if (n1 < n2)
                {
                    for (int i = 0; i < (n2 - n1); i++) { pom1 = pom1 + "0"; }
                }
                n1 = pom1.Length;
                for (int i = 0; i < n1; i++)
                {
                    if (pom1[i] > pom2[i]) break;
                    else if ((pom1[i] - '0') < (pom2[i] - '0'))
                    {
                        string temp = pom1;
                        pom1 = pom2;
                        pom2 = temp;
                        minus = "-";
                        break;
                    }
                }
                string rez = string.Empty;
                int prenesi = 0;
                n1 = pom1.Length;
                for (int i = n1 - 1; i >= 0; i--)
                {
                    int zbir = 0;
                    if (pom1[i] == 46) { rez = "." + rez; continue; }

                    if (((pom1[i] - '0') - (pom2[i] - '0') - prenesi) < 0)
                    {
                        zbir = 10 + (pom1[i] - '0') - (pom2[i] - '0') - prenesi;
                        prenesi = 1;
                    }
                    else
                    {
                        zbir = (pom1[i] - '0') - (pom2[i] - '0') - prenesi;
                        prenesi = 0;
                    }
                    rez = zbir.ToString() + rez;

                }
                rez = rez.TrimStart('0');
                if (rez[0] == 46) rez = "0" + rez;
                return minus + rez;
            }
            if (Decimalan(a) && !Decimalan(b))
            {
                string pom1 = a;
                string pom2 = b;
                pom2 = pom2 + "." + "0";
                return Oduzmi(pom1, pom2);
            }
            else
            {
                string pom1 = a;
                string pom2 = b;
                pom1 = pom1 + "." + "0";
                return Oduzmi(pom1, pom2);
            }
        }
        public static string Pomnozi(string num1, string num2)
        {
            int eks_prvi = Eksponent(num1);
            int eks_drugi = Eksponent(num2);
            int eks = eks_drugi + eks_prvi;

            List<char> prvi = Izbaci_Tacku(num1);
            List<char> drugi = Izbaci_Tacku(num2);

            string[] brojevi = new string[drugi.Count];
            int carry = 0;
            for (int i = drugi.Count; i > 0; i--)
            {
                for (int j = prvi.Count; j > 0; j--)
                {
                    int broj = Convert.ToInt32(char.GetNumericValue(drugi[i - 1])) * Convert.ToInt32(char.GetNumericValue(prvi[j - 1])) + carry;
                    carry = broj / 10;
                    brojevi[i - 1] = Convert.ToString(broj % 10) + brojevi[i - 1];
                }
                if (carry > 0) brojevi[i - 1] = Convert.ToString(carry) + brojevi[i - 1];
                carry = 0;
            }

            string dopuna = "0";
            for (int i = brojevi.Length; i > 1; i--)
            {
                string pom = brojevi[i - 2] + dopuna;
                brojevi[i - 2] = Saberi(brojevi[i - 1], pom);
                dopuna += "0";
            }
            string rez = brojevi[0];

            if (eks > 0)
            {
                rez = Dodaj_Tacku(rez, '.', rez.Length - eks);
            }

            return rez;


        }
        public static string Saberi(string num1, string num2)
        {

            string[] prvi = Split(num1);
            string[] drugi = Split(num2);

            List<char> prvi_ceo = PrebaciUListu(prvi[0]);
            List<char> drugi_ceo = PrebaciUListu(drugi[0]);
            Izjednaci_Liste(prvi_ceo, drugi_ceo);

            string celi = "";
            int carry = 0;

            for (int i = prvi_ceo.Count - 1; i >= 0; i--)
            {
                int Num1 = prvi_ceo[i] - '0';
                int Num2 = drugi_ceo[i] - '0';

                int sum = Num1 + Num2 + carry;
                carry = sum / 10;
                sum %= 10;

                celi = (char)(sum + '0') + celi;
            }

            if (carry > 0)
            {
                celi = (char)(carry + '0') + celi;
            }

            List<char> prvi_deci = PrebaciUListu(prvi[1]);
            List<char> drugi_deci = PrebaciUListu(drugi[1]);
            Izjednaci_Liste(prvi_deci, drugi_deci);

            string deci = "";
            carry = 0;

            for (int i = prvi_deci.Count - 1; i >= 0; i--)
            {
                int Num1 = prvi_deci[i] - '0';
                int Num2 = drugi_deci[i] - '0';

                int sum = Num1 + Num2 + carry;
                carry = sum / 10;
                sum %= 10;

                deci = (char)(sum + '0') + deci;
            }

            if (carry > 0)
            {
                deci = (char)(carry + '0') + deci;
            }

            if ((deci.Length > prvi[1].Length) && (deci.Length > drugi[1].Length))
            {
                int celi_p = Convert.ToInt32(celi);
                celi_p++;
                celi = Convert.ToString(celi_p);
                deci = deci.Substring(1);
            }

            string rez;
            if (deci == "0")
            {
                rez = celi;
            }
            else
            {
                rez = celi + "." + deci;
            }

            return rez;
        }

        public static int CompareDecimalStrings(string strNum1, string strNum2)
        {
            // Splitting the strings into integer and decimal parts
            string[] parts1 = strNum1.Split('.');
            string[] parts2 = strNum2.Split('.');

            // Padding the decimal parts with trailing zeros to ensure equal lengths
            if (parts1.Length == 1)
            {
                parts1 = new string[] { parts1[0], "0" };
            }
            if (parts2.Length == 1)
            {
                parts2 = new string[] { parts2[0], "0" };
            }

            int maxLengthInteger = Math.Max(parts1[0].Length, parts2[0].Length);
            int maxLengthDecimal = Math.Max(parts1[1].Length, parts2[1].Length);

            parts1[0] = parts1[0].PadLeft(maxLengthInteger, '0');
            parts2[0] = parts2[0].PadLeft(maxLengthInteger, '0');
            parts1[1] = parts1[1].PadRight(maxLengthDecimal, '0');
            parts2[1] = parts2[1].PadRight(maxLengthDecimal, '0');

            // Comparing integer parts
            for (int i = 0; i < maxLengthInteger; i++)
            {
                if (parts1[0][i] > parts2[0][i])
                {
                    return 1; // First number is larger
                }
                else if (parts1[0][i] < parts2[0][i])
                {
                    return 2; // Second number is larger
                }
            }

            // Comparing decimal parts
            for (int i = 0; i < maxLengthDecimal; i++)
            {
                if (parts1[1][i] > parts2[1][i])
                {
                    return 1; // First number is larger
                }
                else if (parts1[1][i] < parts2[1][i])
                {
                    return 2; // Second number is larger
                }
            }

            // If both numbers are equal
            return 0;
        }

        static void Izjednaci_Liste(List<char> list1, List<char> list2)
        {
            int maxLength = Math.Max(list1.Count, list2.Count);

            while (list1.Count < maxLength)
            {
                list1.Insert(0, '0');
            }

            while (list2.Count < maxLength)
            {
                list2.Insert(0, '0');
            }
        }

        public static string[] Split(string a)
        {
            bool ima_tacku = false;
            foreach (char c in a)
            {
                if (c == '.') ima_tacku = true;
            }

            string[] niz = new string[2];
            if (ima_tacku == true)
            {
                niz = a.Split('.');
            }
            else
            {
                niz[0] = a;
                niz[1] = "0";
            }
            return niz;
        }

        public static List<char> Izbaci_Tacku(string a)
        {
            List<char> chars = new List<char>();
            foreach (char c in a)
            {
                if (c == '.') continue;
                chars.Add(c);
            }
            return chars;
        }

        static string Dodaj_Tacku(string originalString, char charToInsert, int insertionIndex)
        {
            StringBuilder stringBuilder = new StringBuilder(originalString);
            stringBuilder.Insert(insertionIndex, charToInsert);
            return stringBuilder.ToString();
        }

        public static bool Decimalan(string s)
        {
            if (s.IndexOf('.') != -1)
            {
                return true;
            }
            else return false;
        }

        public static int MestoZareza(string s)
        {
            return s.IndexOf('.');
        }

        static int Eksponent(string s)
        {
            bool flag = false;
            int eks = 0;
            foreach (char c in s)
            {
                if (c == '.')
                {
                    flag = true;
                    continue;
                }
                if (flag == true)
                {
                    eks++;
                }
            }
            return eks;
        }

        public static string RemoveDot(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            string result = input.Replace(".", "");

            return result;
        }

        static int Uporedi(string pom1, string pom2)
        {
            skratiNule(pom1);
            skratiNule(pom2);
            int n1 = pom1.Length;
            int n2 = pom2.Length;
            if (n1 > n2)
            {
                for (int i = 0; i < (n1 - n2); i++) { pom2 = "0" + pom2; }
            }
            else if (n1 < n2)
            {
                for (int i = 0; i < (n2 - n1); i++) { pom1 = "0" + pom1; }
            }
            for (int i = 0; i < pom1.Length; i++)
            {
                if ((pom1[i] - '0') > (pom2[i] - '0')) return 1;
                if ((pom2[i] - '0') > (pom1[i] - '0')) return 2;
            }
            return 0;
        }

        public static int Podeli_Medjurezultat(string a, string b)
        {
            string razlika = Oduzmi(a, b);
            int t = 0;
            while (!(razlika[0] == 45))
            {
                if (razlika == "0") return t + 1;
                razlika = Oduzmi(razlika, b);
                t++;
            }
            return t;
        }

    }
}
