﻿using SlayTheSpire.UI;
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
        SlayTheSpire.UI.GameMap? map;

        public StarterRoom()
        {
            InitializeComponent();
        }

        private void StartJourney(object sender, EventArgs e)
        {
            ShowMap();
        }
        private void ShowMap()
        {
            map = new GameMap();
            Program.MainForm.AddPage(map, this);
            playerInfo.BringToFront();
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
        }

        private void CloseMap()
        {
            if (map != null)
            {
                Program.MainForm.DeledePage(map);
            }
        }

        private void mapIcon_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                CloseMap();
            }
            else
            {
                ShowMap();
            }
        }
    }
}