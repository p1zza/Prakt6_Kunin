using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt6_Kunin
{
    public partial class Form1 : Form
    {
        readonly string alphabet = "__АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        readonly string whorngalphabet = "_ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        readonly int[] simple_numbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31,
                                               37, 41, 43, 47, 53, 59, 61, 67, 71, 73,
                                               79, 83, 89, 97, 101, 103, 107, 109, 113};

        int Coprime_i = 0;
        int exp = 0;
        int d = 0;
        int D_i = 0;
        int e = 0;
        int n = 0;
        int index1 = 0;
        int index2 = 0;
        int index3 = 0;

        Person[] people = new Person[3] ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Letter1_TextChanged(object sender, EventArgs e)
        {
            if (Letter1.TextLength != 0)
            {
                char[] letter1 = Letter1.Text.ToUpper().ToCharArray();

                if(checkletter( letter1[0]))
                {
                    index1 = alphabet.IndexOf(letter1[0]);
                    Letter1_Label.Text = "" + index1;
                }
                else
                {
                    Letter1_Label.Text = "Ошибка";
                }
            }
        }

        private void Letter2_TextChanged(object sender, EventArgs e)
        {
            if (Letter2.TextLength != 0)
            {
                char[] letter2 = Letter2.Text.ToUpper().ToCharArray();

                if (checkletter(letter2[0]))
                {
                    index2 = alphabet.IndexOf(letter2[0]);
                    Letter2_Label.Text = "" + index2;
                }
                else
                {
                    Letter2_Label.Text = "Ошибка";
                }
            }
        }

        private void Letter3_TextChanged(object sender, EventArgs e)
        {
            if (Letter3.TextLength != 0)
            {
                char[] letter3 = Letter3.Text.ToUpper().ToCharArray();

                if (checkletter(letter3[0]))
                {
                    index3 = alphabet.IndexOf(letter3[0]);
                    Letter3_Label.Text = "" + index3;
                }
                else
                {
                    Letter3_Label.Text = "Ошибка";
                }
            }
        }

        private bool checkletter(char letter)
        {
            return alphabet.Contains(letter)? true:false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            int Q = Convert.ToInt32(Box_For_q.Text);
            int P = Convert.ToInt32(Box_For_p.Text);

            if(simple_numbers.Contains(Q) && simple_numbers.Contains(P))
            {
                MethodStart(Q, P,0);
            }
        }

        private bool IsCoprime(int a, int b)
        {
            return a == b
                   ? a == 1
                   : a > b
                        ? IsCoprime(a - b, b)
                        : IsCoprime(b - a, a);
        }

        private void MethodStart(int q, int p,int person)
        {
            n = p * q;

            
            int Eller_Func = (p - 1) * (q - 1);
            

           
                for (; Coprime_i < simple_numbers.Length; Coprime_i++)
                {
                    e = simple_numbers[Coprime_i];
                    if (e < Eller_Func)
                    {
                        if (IsCoprime(e, Eller_Func))
                        {
                            exp = e;
                            Coprime_i+=2;
                            break;

                        }
                    }
                }

                if(person == 0)
                {
                    Person1_textBox.Text = "Открытый ключ:"+ "(" + exp + "; " + n + ") \n";
                }

                if (person == 1)
                {
                    Person2_textBox.Text = "Открытый ключ:" + "(" + exp + "; " + n + ") \n";
                }

                if(person ==2)
                {
                   
                    Person3_textBox.Text = "Открытый ключ:" + "(" + exp + "; " + n + ") \n";
                }

                
                for (; D_i < 10000; D_i++)
                {
                    if ((D_i * exp) % Eller_Func == 1)
                    {
                        d = D_i;
                        D_i++;
                        break;
                        
                    }
                }

                if (person == 0)
                {
                    Person1_textBox.AppendText(" \n Закрытый ключ: " + "(" + d + "; " + n + ") \n");
                }

                if (person == 1)
                {
                    Person2_textBox.AppendText (" \n Закрытый ключ: " + "(" + d + "; " + n + ") \n");
                }

                if (person == 2)
                {
                    Person3_textBox.AppendText(" \n Закрытый ключ: " + "(" + d + "; " + n + ") \n");

                }


            if (person == 0)
            {
                e = 7;
                d = 43;
                Person person1 = new Person(e, d, index1);
                people[0] = person1;

            }

            if (person == 1)
            {
                e = 11;
                d = 71;
                Person person2 = new Person(e, d, index2);
                people[1] = person2;
            }
            if (person == 2)
            {
                e = 13;
                d = 97;
                Person person3 = new Person(e, d, index3);
                people[2] = person3;

                Alghorytm_Start();
            }
            
                if (person <=2)
                {
                    MethodStart(q, p, person + 1);
                }
        }

        private void Alghorytm_Start()
        {
            //Человек 1 добавляет случайное x = 6 к своему символу, шифрует с помощью открытого ключа человека 2 и отсылает ему.

            double a = people[0].symbol + 6.0;

            double message = Math.Pow(a, people[1].openkey_e) % n;

            //Человек 2 принимает message дешифрует с помощью своего зкарытого ключа, добавляет к нему свой символ и шифрует
            //с помощью открытого ключа человека 3 и отсылает ему

            double inmessage = Math.Pow(message, people[1].closedkey_d) % n;

            double message2 = Math.Pow((inmessage + people[1].symbol), people[2].openkey_e) % n;

            //Человек 3 получает message2 дешифрует его с помощью своего закрытого ключа, 
            //добавляет к нему свой символ и шифрует с помощью открытого ключа человека 1 и отсылает ему

            double inmessage1 = Math.Pow(message2, people[2].closedkey_d) % n;

            double message3 = Math.Pow((inmessage1 + people[2].symbol), people[0].openkey_e) % n;

            //Человек 1 получает message3 дешифрует его с помощью закрытого ключа, отнимает х и считает среднее

            double inmessage2 = Math.Pow(message3, people[0].closedkey_d) % n;

            double outmessage = inmessage2 - 6;

            label1.Text = "После алгоритма получено среднее значение:" + outmessage / 3.0;

            double abc = people[0].symbol + people[1].symbol + people[2].symbol;
            label2.Text = "Фактически равно: " + (abc / 3);
        }
    }

    public class Person
    {
        public double openkey_e;
        public double closedkey_d;
        public double symbol;
        public Person(double e, double d, double s)
        {
            openkey_e = e;
            closedkey_d = d;
            symbol = s;
        }
        public Person()
        { }

    }
}
