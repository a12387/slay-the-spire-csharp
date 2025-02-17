﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlayTheSpire.Game;
using SlayTheSpire.Game.Cards.Red;

namespace SlayTheSpire.UI
{
    // IntentUI 是用于显示怪物意图的UI类
    // 通过PaintIntent方法来显示怪物意图
    // 通过MonsterIntent枚举来确定显示的图片
    // 通过damageAmount和damageTimes来确定显示的伤害数值
    // damageTimes = 0时不显示伤害数值
    // damageTimes = 1时显示damageAmount
    // damageTimes > 1时显示damageAmount * damageTimes （也就是多段伤害，比如6*2）
    public partial class IntentUI : UserControl
    {
        public IntentUI()
        {
            InitializeComponent();
            panel1.Parent = myPictureBox1;
        }
        internal void PaintIndent(MonsterIntent monsterIntent, int damageAmount, int damageTimes)
        {
            switch (monsterIntent)
            {
                case MonsterIntent.Attack:
                    myPictureBox1.Image = Properties.Resources.attack;
                    break;
                // case MonsterIntent.AttackBuff:
                case MonsterIntent.AttackDebuff:
                    myPictureBox1.Image = Properties.Resources.attackDebuff;
                    break;
                case MonsterIntent.AttackDefend:
                    myPictureBox1.Image = Properties.Resources.attackDefend;
                    break;
                case MonsterIntent.Buff:
                    myPictureBox1.Image = Properties.Resources.buff;
                    break;
                case MonsterIntent.StrongDebuff:
                case MonsterIntent.Debuff:
                    myPictureBox1.Image = Properties.Resources.debuff;
                    break;
                case MonsterIntent.Defend:
                    myPictureBox1.Image = Properties.Resources.defend1;
                    break;
                // case MonsterIntent.DefendBuff:
                // case MonsterIntent.DefendDebuff:
                // case MonsterIntent.Magic:
                default:
                    throw new NotImplementedException();
            }
            if (damageTimes > 0)
            {
                if (damageTimes == 1)
                {
                    label1.Text = damageAmount.ToString();
                }
                else
                {
                    label1.Text = damageAmount.ToString() + "*" + damageTimes.ToString();
                } 
                label1.Visible = true;
            }
            else
            {
                label1.Text = "";
                label1.Visible = false;
            }
        }
    }
}
