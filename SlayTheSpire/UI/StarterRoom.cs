﻿using SlayTheSpire.UI;
using SlayTheSpire.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheSpire
{
    public partial class StarterRoom : UserControl
    {
        // StarterRoom 是游戏开始的界面
        // 这里的三个按钮其实可以用一个按钮来实现
        // 只需要改为事件的 += 和 -=，同时更改Text即可
        const int NumCardsToGet = 15;
        public StarterRoom()
        {
            InitializeComponent();
        }

        public event Action? ShowMap;

        private void StartJourney(object sender, EventArgs e)
        {
            ShowMap?.Invoke();
        }

        private void buttonTalk_Click(object sender, EventArgs e)
        {
            buttonTalk.Enabled = false;
            buttonGetDeck.Visible = true;
            labelDialog.Text = "来挑战我吧……";
        }

        private void buttonGetDeck_Click(object sender, EventArgs e)
        {
            buttonGetDeck.Visible = false;
            buttonLeave.Visible = true;
            var cardSelection = new CardSelection(NumCardsToGet);
            Program.MainForm.AddPage(cardSelection, this);
            //playerInfo.BringToFront();
        }

        //private void CloseMap()
        //{
        //    if (map != null)
        //    {
        //        Program.MainForm.DeletePage(map);
        //    }
        //}

        //private void mapIcon_Click(object sender, EventArgs e)
        //{
        //    if (map != null)
        //    {
        //        CloseMap();
        //    }
        //    else
        //    {
        //        ShowMap();
        //    }
        //}
    }
}
