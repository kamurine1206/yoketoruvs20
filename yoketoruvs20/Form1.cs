using System;
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
        const bool isDebug = true;

        
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

        [DllImport("user32.dll")]

        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState != State.None)
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
                    break;

                case State.Game:
                    daimei.Visible = false;
                    START.Visible = false;
                    name.Visible = false;
                    Highscore.Visible = false;
                    clearlabel.Visible = false;
                    break;

                case State.Gameover:
                    gameover.Visible = true;
                    END.Visible = true;
                    break;

                case State.Clear:
                    clearlabel.Visible = true;
                    END.Visible = true;
                    Highscore.Visible = true;
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
    }
}
