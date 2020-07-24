﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test {
    public partial class Form1 : Form {
        string ans;
        uint num = 1;
        double success = 0;
        public Form1() {
            InitializeComponent();
            button2.Enabled = false;
        }
        class questions {
            internal string question;
            internal string answer1;
            internal string answer2;
            internal string answer3;
            internal string answer4;
            internal string ra;
            public questions(string que, string ans1, string ans2, string ans3, string ans4, string rA) {
                question = que;
                answer1 = ans1;
                answer2 = ans2;
                answer3 = ans3;
                answer4 = ans4;
                ra = rA;
            }

        }
        void func(questions que) {
            richTextBox1.Text = que.question;
            radioButton1.Text = que.answer1;
            radioButton2.Text = que.answer2;
            radioButton3.Text = que.answer3;
            radioButton4.Text = que.answer4;
            radioButton1.Checked = true;
        }
        questions[] que;
        private void button1_Click(object sender, EventArgs e) {
            //загрузка файла
            string[] str = File.ReadAllLines("E:\\test.txt");
            //MessageBox.Show(str[1]);
            //string s1 = "hello world";
            //string subString = "wwwaeas";
            //int indexOfSubstring = s1.IndexOf(subString); // равно 6
            //MessageBox.Show(indexOfSubstring.ToString());
            //string[] que1 = { "1) Укажите тип данных, которое определяет служебное слово struct", "2) Укажите тип данных, которое определяет служебное слово struct" };
            //string[] ans1 = { "Массив данных с различной структурой", "Массив данных с различной структурой" };
            //string[] ans2 = { "Тип функций, которые могут иметь различную структуру параметров" ,"Тип функций, которые могут иметь различную структуру параметров" };
            //string[] ans3 = { "Тип данных, которые могут менять свою структуру" , "Тип данных, которые могут менять свою структуру" };
            //string[] ans4 = { "Составной объект, к которому могут входить элементы различных типов" , "Составной объект, к которому могут входить элементы различных типов" };
            //char[] rA = { '4' , '2'};
            //que = new questions[rA.Length];
            //for(int i = 0;i < que1.Length; i++) {
            //    que[i] = new questions(que1[i], ans1[i], ans2[i], ans3[i], ans4[i], rA[i]);
            //}
            //que[0] = new questions(que1, ans1, ans2, ans3, ans4, rA);
            List<string> que1 = new List<string>(), 
            ans1 = new List<string>(), 
            ans2 = new List<string>(), 
            ans3 = new List<string>(), 
            ans4 = new List<string>(), 
            rA = new List<string>();
            foreach(string st in str) {
                if(st.IndexOf("que") == 0) {
                    que1.Add(st.TrimStart(new char[] {'q','u','e'}));
                }
                if(st.IndexOf("ans1") == 0) {
                    ans1.Add(st.TrimStart(new char[] { 'a', 'n', 's', '1' }));
                }
                if(st.IndexOf("ans2") == 0) {
                    ans2.Add(st.TrimStart(new char[] { 'a', 'n', 's', '2' }));
                }
                if(st.IndexOf("ans3") == 0) {
                    ans3.Add(st.TrimStart(new char[] { 'a', 'n', 's', '3' }));
                }
                if(st.IndexOf("ans4") == 0) {
                    ans4.Add(st.TrimStart(new char[] { 'a', 'n', 's', '4' }));
                }
                if(st.IndexOf("ra") == 0) {
                    rA.Add(st.TrimStart(new char[] { 'r', 'a' }));
                }
            }
            que = new questions[que1.Count];
            for(int i = 0; i < que1.Count; i++) {
                que[i] = new questions(que1[i], ans1[i], ans2[i], ans3[i], ans4[i], rA[i]);
            }
            func(que[0]);
            button2.Enabled = true;
            button1.Enabled = false;
            radioButton1.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e) {
            if(num < que.Length) {
                if(ans == que[num - 1].ra) {
                    MessageBox.Show("Правильно!!");
                    success++;
                }
                else {
                    MessageBox.Show("НЕПРАВИЛЬНО!!");
                }
                num++;
                func(que[num - 1]);
            }
            else {
                if(num == que.Length) {
                    if(ans == que[num - 1].ra) {
                        MessageBox.Show("Правильно!!");
                        success++;
                    }
                    else {
                        MessageBox.Show("НЕПРАВИЛЬНО!!");
                    }
                    num++;
                    double proc = (Convert.ToDouble(success / que.Length) * 100);
                    MessageBox.Show("Вы ответили на всё! Ваш результат: " + " " + Math.Round(proc, 2) + "%");
                    button2.Enabled = false;
                }
                
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            ans = "1";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            ans = "2";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            ans = "3";
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            ans = "4";
        }
    }
}
