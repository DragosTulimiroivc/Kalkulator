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

                }
                else if (b1.negativan && !b2.negativan)
                {
                    sabiranje.Text = big.oduzmi(b2, b1);
                    oduzimanje.Text = "-" + big.saberi(b1, b2);
                    mnozenje.Text = "-" + big.mnozi(b1, b2);
                }
                else if (b2.negativan && !b1.negativan)
                {
                    sabiranje.Text = big.oduzmi(b1, b2);
                    oduzimanje.Text = big.saberi(b1, b2);
                    mnozenje.Text = "-" + big.mnozi(b1, b2);
                }
                else
                {
                    sabiranje.Text = big.saberi(b1, b2);
                    oduzimanje.Text = big.oduzmi(b1, b2);
                    mnozenje.Text = big.mnozi(b1, b2);

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

                }
                else if (b1.negativan && !b2.negativan)
                {
                    sabiranje.Text = big.oduzmi(b2, b1);
                    oduzimanje.Text = "-" + big.saberi(b1, b2);
                    mnozenje.Text = "-" + big.mnozi(b1, b2);
                }
                else if (b2.negativan && !b1.negativan)
                {
                    sabiranje.Text = big.oduzmi(b1, b2);
                    oduzimanje.Text = big.saberi(b1, b2);
                    mnozenje.Text = "-" + big.mnozi(b1, b2);
                }
                else
                {
                    sabiranje.Text = big.saberi(b1, b2);
                    oduzimanje.Text = big.oduzmi(b1, b2);
                    mnozenje.Text = big.mnozi(b1, b2);

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
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            int p = 0;
            for (int i = 0; i < A.ceo.Count; i++)
            {
                a.Add(A.ceo[i]);
            }
            if (A.decimalni.Count > 1)
            {
                for (int i = 1; i < A.decimalni.Count; i++)
                {
                    a.Add(A.decimalni[i]);
                }
            }
            for (int i = 0; i < B.ceo.Count; i++)
            {
                b.Add(B.ceo[i]);
            }
            if (B.decimalni.Count > 1)
            {
                for (int i = 1; i < B.decimalni.Count; i++)
                {
                    b.Add(B.decimalni[i]);
                }
            }
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
            string rez = "";
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
            }
            return rez;
        }
    }
}
