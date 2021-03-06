﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        int ItemCount;
        int time;
        int highscore;
        int score = 0;
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;　//プログラム計算式
        const int ItemIndex = EnemyIndex + EnemyMax;　//プログラム計算式

        const string PlayerText = "(*^-^*)";
        const string EnemyText = "■";
        const string ItemText = "☆";


        static Random rand = new Random();
        
        enum State
        {
            None = -1,        //無効
            Title,        //タイトル
            Game,       //ゲーム
            Gameover,    //ゲームオーバー
            Clear,       // クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        const int SpeedMax = 20;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        [DllImport("user32.dll")]

        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();
            
            for (int i = 0; i < ChrMax; i++)//見分け方
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = tenplabel.Font;
                Controls.Add(chrs[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initProc();
            }

            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if (currentState == State.Game)
            {
                UpdateGame();
            }


        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;
            chrs[PlayerIndex].Text = PlayerText;

            zanki.Text = "☆" + ItemCount;

            if (time > 0)
            {
                Time.Text = time.ToString();
                                time = time - 1;

            }
            if(time <= 0)
            {
                nextState = State.Gameover;

            }



            for (int i= EnemyIndex; i < ChrMax; i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);

                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);

                }
                if (chrs[i].Right >= ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);

                }
                if (chrs[i].Bottom >= ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
             
                if(       (mp.X >= chrs[i].Left)
                &&    (mp.X < chrs[i].Right)
                &&    (mp.Y >= chrs[i].Top)
                &&    (mp.Y < chrs[i].Bottom)
                )
                 

            {
                //MessageBox.Show("あたったね");
                //敵か？
                if(i<ItemIndex)
                {
                        nextState = State.Gameover;
                }
                else
                {
                        //アイテム
                        chrs[i].Visible = false;
                        ItemCount = ItemCount - 1;
                        if(ItemCount <= 0)
                        {
                            nextState = State.Clear;
                        }
                        vx[i] = 0;
                        vy[i] = 0;
                        chrs[i].Left = 10000;
                }
            }
                
                    

            }
            //TODO; mpがプレイヤーの中心になるように設定
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    daimei.Visible = true;
                    START.Visible = true;
                    gameover.Visible = false;
                    Highscore.Visible = true;
                    Time.Visible = true;
                    zanki.Visible = true;
                    name.Visible = true;
                    END.Visible = false;
                    clearlabel.Visible = false;
                    tenplabel.Visible = false;
                    ItemCount = 10;
                    scorelabel.Visible = true;
                    break;

                case State.Game:
                    daimei.Visible = false;
                    START.Visible = false;
                    name.Visible = false;
                    Highscore.Visible = false;
                    clearlabel.Visible = false;
                    scorelabel.Visible = false;
                    time = 100;
                    
                    for (int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        chrs[i].Visible = true;
                    }
                    break;
                    
                case State.Gameover:
                    gameover.Visible = true;
                    END.Visible = true;
                    break;

                case State.Clear:
                    clearlabel.Visible = true;
                    END.Visible = true;
                    Highscore.Visible = true;
                    scorelabel.Visible = true;
                    scorelabel.Text = "score" + scorelabel;
                    if(time < score)
                    {
                        scorelabel = Highscore;

                    }

                    break;
            }
        }

        private void START_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void END_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void gameover_Click(object sender, EventArgs e)
        {

        }

    }
}
