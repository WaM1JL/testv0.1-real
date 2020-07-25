using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Test {
    public partial class Form1 : Form {
        string ans; //Выбранный ответ
        uint num = 1; //Номер вопроса
        double success = 0; //Правильных ответов
        public Form1() {
            InitializeComponent();
            enterAnsButton.Enabled = false;
        }
        class questions {
            internal string question; //Вопрос
            internal string answer1;
            internal string answer2;
            internal string answer3;
            internal string answer4;
            internal string ra;  //Номер правильного ответа 
            public questions(string que, string ans1, string ans2, string ans3, string ans4, string rA) {
                question = que;
                answer1 = ans1;
                answer2 = ans2;
                answer3 = ans3;
                answer4 = ans4;
                ra = rA;
            }

        }
        void interf(questions que) {  //Интерфейс вопроса
            richTextBoxQue.Text = que.question;
            radioButtonAns1.Text = que.answer1;
            radioButtonAns2.Text = que.answer2;
            radioButtonAns3.Text = que.answer3;
            radioButtonAns4.Text = que.answer4;
            radioButtonAns1.Checked = true;
        }
        questions[] que;
        private void loadTestButton_Click(object sender, EventArgs e) {
            string[] str = File.ReadAllLines("E:\\test.txt");
            List<string> que1 = new List<string>(), 
            ans1 = new List<string>(), 
            ans2 = new List<string>(), 
            ans3 = new List<string>(), 
            ans4 = new List<string>(), 
            rA = new List<string>();
            foreach(string st in str) { //Заполнение списка вопросов
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
            for(int i = 0; i < que1.Count; i++) { //Заполнение класса вопроса
                que[i] = new questions(que1[i], ans1[i], ans2[i], ans3[i], ans4[i], rA[i]);
            }
            interf(que[0]);
            enterAnsButton.Enabled = true;
            loadTestButton.Enabled = false;
            radioButtonAns1.Checked = true;
        }
        private void enterAnsButton_Click(object sender, EventArgs e) {//Кнопка ответа на вопрос
            if(num < que.Length) {
                if(ans == que[num - 1].ra) {
                    MessageBox.Show("Правильно!!");
                    success++;
                }
                else {
                    MessageBox.Show("НЕПРАВИЛЬНО!!");
                }
                num++;
                interf(que[num - 1]);
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
                    enterAnsButton.Enabled = false;
                }
                
            }
        }
        private void radioButtonAns1_CheckedChanged(object sender, EventArgs e) {
            ans = "1";
        }
        private void radioButtonAns2_CheckedChanged(object sender, EventArgs e) {
            ans = "2";
        }
        private void radioButtonAns3_CheckedChanged(object sender, EventArgs e) {
            ans = "3";
        }
        private void radioButtonAns4_CheckedChanged(object sender, EventArgs e) {
            ans = "4";
        }
    }
}
