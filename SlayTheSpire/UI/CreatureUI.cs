﻿using SlayTheSpire.Game;
using SlayTheSpire.Game.Monsters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheSpire.UI
{
    public partial class CreatureUI : UserControl
    {
        internal CreatureUI(AbstractCreature abstractCreature)
        {
            InitializeComponent();
            healthBar1.CurrentHealth = abstractCreature.CurrentHealth;
            healthBar1.MaxHealth = abstractCreature.MaxHealth;
            abstractCreature.CurrentHealthChanged += SetCurrentHealth;
            abstractCreature.MaxHealthChanged += SetMaxHealth;
            switch (abstractCreature.Name)
            {
                case "Ironclad":
                    pictureBox1.Image = Properties.Resources.ironclad;
                    break;
                case "Corrupt Heart":
                    pictureBox1.Image = Properties.Resources.CorruptHeart;
                    break;
                case "Spire Shield":
                    pictureBox1.Image = Properties.Resources.shield;
                    break;
                case "Spire Spear":
                    pictureBox1.Image = Properties.Resources.spear;
                    break;
            }
        }
        public void SetCurrentHealth(object? sender, int health)
        {
            healthBar1.CurrentHealth = health;
        }

        public void SetMaxHealth(object? sender, int health)
        {
            healthBar1.MaxHealth = health;
        }
    }
}