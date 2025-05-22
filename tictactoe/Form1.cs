using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private string currentPlayer = "X";//currentPlayer เป็นตัวแปรที่เก็บค่าผู้เล่นปัจจุบัน โดยเริ่มต้นเป็น "X"
        private string playerX = "X";
        private string playerO = "O";
        private Button[] buttons;
        private int scoreX = 0;//scoreX เป็นตัวแปรที่เก็บคะแนน X
        private int scoreO = 0;//scoreO เป็นตัวแปรที่เก็บคะแนน O
        private int draw = 0;//draw เป็นตัวแปรที่เก็บคะแนนเสมอ

        public Form1()
        {
            InitializeComponent();
            buttons = new Button[9];
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;//เป็นการกำหนดปุ่มในตาราง 3x3 โดยแต่ละปุ่มจะถูกเก็บไว้ในอาเรย์ buttons[] เพื่อให้สามารถเข้าถึงได้ง่ายในภายหลัง
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;//การแปลง sender เป็นปุ่มที่ถูกคลิก โดย sender คือวัตถุที่ส่งมาจากเหตุการณ์คลิกปุ่ม
                if (clickedButton.Text == "")// ตรวจสอบว่าปุ่มที่ถูกคลิกยังไม่มีข้อความอยู่หรือไม่
            {
                clickedButton.Text = currentPlayer;//ถ้าไม่มีข้อความ ให้ใส่ข้อความ "X" ลงไปในปุ่มที่ถูกคลิก
                clickedButton.Enabled = false;//ทำให้ปุ่มที่ถูกคลิกไม่สามารถกดได้อีก
                if (CheckWinner(currentPlayer))//ตรวจสอบว่าผู้เล่น X ชนะหรือไม่
                {
                    if (currentPlayer == "X")//ถ้า x ชนะ เพิ่มคะแนน x
                    {
                        scoreX++;//เพิ่มคะแนน X ขึ้น 1
                    }
                    else 
                    {
                        scoreO++;//เพิ่มคะแนน O ขึ้น 1
                    }

                        updatescore();//อัพเดทคะแนนผู้เล่น X และ O

                    MessageBox.Show("Player X wins!");//ถ้าชนะ ให้แสดงข้อความ
                    foreach (Button button in buttons)//วนลูปเพื่อทำให้ปุ่มทั้งหมดไม่สามารถกดได้
                    {
                        button.Enabled = false;//ทำให้ปุ่มทั้งหมดไม่สามารถกดได้
                    }
                }
                else if (CheckDraw())//ตรวจสอบว่าเกมเสมอหรือไม่
                {
                    draw++;
                        updatescore();//อัพเดทคะแนนเสมอ
                    MessageBox.Show("It's a draw!");//ถ้าเสมอ ให้แสดงข้อความ
                    foreach (Button button in buttons)//วนลูปเพื่อทำให้ปุ่มทั้งหมดไม่สามารถกดได้
                    {
                        button.Enabled = false;//ทำให้ปุ่มทั้งหมดไม่สามารถกดได้
                    }
                }
                else
                {
                    currentPlayer = (currentPlayer == "X") ? "O" : "X";//สลับผู้เล่นระหว่าง X และ O โดย ? = > : เป็นการใช้ ternary operator ในการตรวจสอบว่า playerX เป็น "X" หรือไม่ ถ้าใช่ให้เปลี่ยนเป็น "O" ถ้าไม่ใช่ให้เปลี่ยนเป็น "X"
                }
            }
        }
        private bool CheckWinner(string player)//string player เป็นตัวแปรที่เป็นค่าผู้เล่นที่จะตรวจสอบว่าชนะมั้ย โดยจะส่งค่าผู้เล่นที่จะตรวจสอบเข้ามา
        {
            int[,] setofwinning = new int [,]//จัดเก็บรูปแบบการชนะ โดย [,] => เป็นการสร้าง array 2 มิติ
            {
                { 0, 1, 2 }, // Row 1
                { 3, 4, 5 }, // Row 2
                { 6, 7, 8 }, // Row 3
                { 0, 3, 6 }, // Column 1
                { 1, 4, 7 }, // Column 2
                { 2, 5, 8 }, // Column 3
                { 0, 4, 8 }, // Diagonal \
                { 2, 4, 6 } // Diagonal /
            };
            for (int i = 0; i < setofwinning.GetLength(0); i++)//วนลูปเพื่อเช็คการชนะ
            {
                int a = setofwinning[i, 0];//เก็บค่าตำแหน่งของปุ่มใน array
                int b = setofwinning[i, 1];//เก็บค่าตำแหน่งของปุ่มใน array
                int c = setofwinning[i, 2];//เก็บค่าตำแหน่งของปุ่มใน array

                if (buttons[a].Text == player &&
                    buttons[b].Text == player &&    
                    buttons[c].Text == player)//ตรวจสอบว่าปุ่มที่ a,b,c เรียงเป็นอย่างไร
                {
                    return true;//ถ้าผู้เล่นชนะ ให้ return true
                }
            }
            return false;//ถ้าผู้เล่นไม่ชนะ ให้ return false
        }
        private bool CheckDraw()
        {
            foreach (Button clickbutton in buttons)//วนลูปเพื่อเช็คว่าเกมเสมอหรือไม่
            {
                if (clickbutton.Text == "")//ถ้าปุ่มที่ถูกคลิกยังไม่มีข้อความอยู่
                {
                    return false;//ถ้าไม่เสมอ ให้ return false
                }
            }
            return true;//ถ้าทุกปุ่มมีข้อความอยู่ ให้ return true
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newgame_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttons)//วนลูปเพื่อรีเซ็ตปุ่มทั้งหมด
            {
                button.Text = "";//ทำให้ปุ่มทั้งหมดไม่มีข้อความ
                button.Enabled = true;//ทำให้ปุ่มทั้งหมดสามารถกดได้
            }
            currentPlayer = "X";//รีเซ็ตผู้เล่น X เป็น "X"
        }
        private void updatescore()
        {
            scoreplayerX.Text = $"ScoreX = : {scoreX}";//อัพเดทคะแนนผู้เล่น X โดยใช้ string interpolation
            scoreplayerO.Text = $"ScoreO = : {scoreO}";//อัพเดทคะแนนผู้เล่น O โดยใช้ string interpolation
            Drawscore.Text = $"Draw = : {draw}";//อัพเดทคะแนนเสมอ โดยใช้ string interpolation
        }
    }
    
}
