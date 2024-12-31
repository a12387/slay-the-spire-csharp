using SlayTheSpire.Game;
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
        private AbstractCreature creature;
        public PictureBox CreatruePictureBox { get { return pictureBoxCreature; } }
        internal AbstractCreature Creature { get { return creature; } }
        internal CreatureUI(AbstractCreature abstractCreature)
        {
            InitializeComponent();
            creature = abstractCreature;
            abstractCreature.CurrentHealthChanged += SetCurrentHealth;
            abstractCreature.MaxHealthChanged += SetMaxHealth;
            abstractCreature.CurrentBlockChanged += SetCurrentBlock;
            abstractCreature.BuffListChanged += buffBar.PaintBuffs;
            var monster = creature as AbstractMonster;
            if (monster != null)
            {
                monster.MonsterIntentChanged += intentui1.PaintIndent;
            }
            switch (abstractCreature.Name)
            {
                case "Ironclad":
                    pictureBoxCreature.Image = Properties.Resources.ironclad;
                    break;
                case "Corrupt Heart":
                    pictureBoxCreature.Image = Properties.Resources.CorruptHeart;
                    break;
                case "Spire Shield":
                    pictureBoxCreature.Image = Properties.Resources.shield;
                    break;
                case "Spire Spear":
                    pictureBoxCreature.Image = Properties.Resources.spear;
                    break;
            }
        }
        public void SetCurrentHealth(int health)
        {
            healthBar.CurrentHealth = health;
        }

        public void SetMaxHealth(int health)
        {
            healthBar.MaxHealth = health;
        }

        public void SetCurrentBlock(int block)
        {
            healthBar.CurrentBlock = block;
            if (block == 0)
            {
                pictureBoxWithLabel1.Hide();
            }
            else
            {
                pictureBoxWithLabel1.labelText = block.ToString();
                pictureBoxWithLabel1.Show();
            }
        }
    }
}
