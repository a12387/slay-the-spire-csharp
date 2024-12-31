using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlayTheSpire.Game;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.UI
{
    public partial class BuffUI : UserControl
    {
        public BuffUI()
        {
            InitializeComponent();
            panelBuffUI.Parent = myPictureBox1;
            //label1.Parent = myPictureBox1;
        }

        internal void PaintBuff(AbstractPower power)
        {
            switch (power.Name)
            {
                case "Artifact":
                    myPictureBox1.Image = Properties.Resources.Artifact;
                    break;
                case "BackAttackLeft":
                    myPictureBox1.Image = Properties.Resources.BackAttackLeft;
                    break;
                case "BackAttackRight":
                    myPictureBox1.Image = Properties.Resources.BackAttackRight;
                    break;
                case "BarricadePower":
                    myPictureBox1.Image = Properties.Resources.PowerBarricade;
                    break;
                case "BeatOfDeath":
                    myPictureBox1.Image = Properties.Resources.BeatOfDeath;
                    break;
                case "CorruptionPower":
                    myPictureBox1.Image = Properties.Resources.PowerCorruption;
                    break;
                case "DarkEmbracePower":
                    myPictureBox1.Image = Properties.Resources.PowerDarkEmbrace;
                    break;
                case "DemonFormPower":
                    myPictureBox1.Image = Properties.Resources.PowerDemonForm;
                    break;
                case "FeelNoPainPower":
                    myPictureBox1.Image = Properties.Resources.PowerFeelNoPain;
                    break;
                case "Frail":
                    myPictureBox1.Image = Properties.Resources.Frail;
                    break;
                case "Invincible":
                    myPictureBox1.Image = Properties.Resources.Invincible;
                    break;
                case "NoDraw":
                    myPictureBox1.Image = Properties.Resources.NoDraw;
                    break;
                case "PainfulStabs":
                    myPictureBox1.Image = Properties.Resources.PainfulStab;
                    break;
                case "Strength":
                    myPictureBox1.Image = Properties.Resources.Strength;
                    break;
                case "Surrounded":
                    myPictureBox1.Image = Properties.Resources.Surrounded;
                    break;
                case "Vulnerable":
                    myPictureBox1.Image = Properties.Resources.Vulnerable;
                    break;
                case "Weak":
                    myPictureBox1.Image = Properties.Resources.Weak;
                    break;
            }
            label1.Text = power.Amount.ToString();
        }
    }
}
