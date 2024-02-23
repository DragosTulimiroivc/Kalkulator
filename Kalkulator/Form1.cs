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
            int[] c = new int[32767];
            int[] d = new int[32767];
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
                    b1.ceo[b1.Ic] = 1;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 1;
                    b1.Id++;
                }
                broj1.Text += "1";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 1;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 1;
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
                    b1.ceo[b1.Ic] = 2;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 2;
                    b1.Id++;
                }
                broj1.Text += "2";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 2;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 2;
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
                    b1.ceo[b1.Ic] = 3;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 3;
                    b1.Id++;
                }
                broj1.Text += "3";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 3;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 3;
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
                    b1.ceo[b1.Ic] = 4;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 4;
                    b1.Id++;
                }
                broj1.Text += "4";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 4;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 4;
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
                    b1.ceo[b1.Ic] = 5;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 5;
                    b1.Id++;
                }
                broj1.Text += "5";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 5;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 5;
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
                    b1.ceo[b1.Ic] = 6;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 6;
                    b1.Id++;
                }
                broj1.Text += "6";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 6;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 6;
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
                    b1.ceo[b1.Ic] = 7;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 7;
                    b1.Id++;
                }
                broj1.Text += "7";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 7;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 7;
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
                    b1.ceo[b1.Ic] = 8;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 8;
                    b1.Id++;
                }
                broj1.Text += "8";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 8;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 8;
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
                    b1.ceo[b1.Ic] = 9;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 9;
                    b1.Id++;
                }
                broj1.Text += "9";
            }
            else if (brojB.Checked)
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 9;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 9;
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
                    b1.ceo[b1.Ic] = 0;
                    b1.Ic++;
                }
                else
                {
                    b1.decimalni[b1.Id] = 0;
                    b1.Id++;
                }
                broj1.Text += "0";
            }
            else if (brojB.Checked && (broj2.Text != "") && (broj2.Text!="-"))
            {
                if (b2.zapeta == false)
                {
                    b2.ceo[b2.Ic] = 0;
                    b2.Ic++;
                }
                else
                {
                    b2.decimalni[b2.Id] = 0;
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
                b1.zapeta = false;
                b1.ceo = new int[32767];
                b1.decimalni = new int[32767];
                b1.negativan = false;
            }
            else if (brojB.Checked)
            {
                broj2.Text = "";
                b2.zapeta = false;
                b2.ceo = new int[32767];
                b2.decimalni = new int[32767];
                b2.negativan = false;
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
        public int[] ceo;
        public int[] decimalni;
        public bool zapeta = false;
        public int Ic = 0;
        public int Id = 0;
        public bool negativan = false;
        public big() 
        {
            ceo = new int[32767];
            decimalni = new int[32767];
        }
        public static string saberi(big A, big B)
        {
            big C = new big();
            string rez = "";
            return rez;
        }
    }
}
