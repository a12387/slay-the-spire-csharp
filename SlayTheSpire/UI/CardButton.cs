﻿using SlayTheSpire.Game;
using SlayTheSpire.Game.Cards;
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
    // CardButton 是用于显示卡牌的UI类
    // 由于对各种要素的叠加涉及很多细节，所以这里没有使用继承，而是直接在CardButton中实现了绘制
    internal partial class CardButton : UserControl
    {
        const int OriginX = 180;
        const int OriginY = 252;
        private float ScaleX;
        private float ScaleY;
        private static Dictionary<CardRarity, Dictionary<CardType, Bitmap>> Frames = new()
        {
            [CardRarity.Basic] = new Dictionary<CardType, Bitmap>()
            {
                [CardType.Attack] = Properties.Resources.frame_attack_common,
                [CardType.Skill] = Properties.Resources.frame_skill_common,
                [CardType.Power] = Properties.Resources.frame_power_common
            },
            [CardRarity.Common] = new Dictionary<CardType, Bitmap>()
            {
                [CardType.Attack] = Properties.Resources.frame_attack_common,
                [CardType.Skill] = Properties.Resources.frame_skill_common,
                [CardType.Power] = Properties.Resources.frame_power_common
            },
            [CardRarity.Uncommon] = new Dictionary<CardType, Bitmap>()
            {
                [CardType.Attack] = Properties.Resources.frame_attack_uncommon,
                [CardType.Skill] = Properties.Resources.frame_skill_uncommon,
                [CardType.Power] = Properties.Resources.frame_power_uncommon
            },
            [CardRarity.Rare] = new Dictionary<CardType, Bitmap>()
            {
                [CardType.Attack] = Properties.Resources.frame_attack_rare,
                [CardType.Skill] = Properties.Resources.frame_skill_rare,
                [CardType.Power] = Properties.Resources.frame_power_rare
            },
            [CardRarity.Special] = new Dictionary<CardType, Bitmap>()
            {
                [CardType.Status] = Properties.Resources.frame_skill_common,
            },
        };
        public AbstractCard Card { get; }
        public CardButton(AbstractCard card)
        {
            InitializeComponent();
            DoubleBuffered = true;
            Card = card;
        }
        private void SetBackground(PaintEventArgs e)
        {
            CardColor color = Card.Color;
            CardType type = Card.Type;
            Image img;
            if (color == CardColor.Colorless)
            {
                img = Properties.Resources.bg_colorless;
            }
            else
            {
                switch (type)
                {
                    case CardType.Attack:
                        img = Properties.Resources.bg_attack;
                        break;
                    case CardType.Skill:
                        img = Properties.Resources.bg_skill;
                        break;
                    case CardType.Power:
                        img = Properties.Resources.bg_power;
                        break;
                    default:
                        throw new ArgumentException("Status must be colorless!");
                }
            }
            e.Graphics.DrawImage(img, 0, 0, Width, Height);
        }
        private void SetImage(PaintEventArgs e)
        {
            e.Graphics.DrawImage(CardLibrary.GetCardImage(Card.Id), 18 * ScaleX, 36 * ScaleY, 240 * ScaleX, 183 * ScaleY);
        }
        private void SetFrame(PaintEventArgs e)
        {
            CardRarity rarity = Card.Rarity;
            CardType type = Card.Type;
            if (type == CardType.Power)
            {
                e.Graphics.DrawImage(Frames[rarity][type], 15 * ScaleX, 10 * ScaleY, 243 * ScaleX, 210 * ScaleY);
            }
            else
            {
                e.Graphics.DrawImage(Frames[rarity][type], 15 * ScaleX, 54 * ScaleY, 243 * ScaleX, 168 * ScaleY);
            }
        }
        private void SetBanner(PaintEventArgs e)
        {
            Image img;
            switch (Card.Rarity)
            {
                case CardRarity.Basic:
                case CardRarity.Special:
                case CardRarity.Common:
                    img = Properties.Resources.banner_common;
                    break;
                case CardRarity.Uncommon:
                    img = Properties.Resources.banner_uncommon;
                    break;
                case CardRarity.Rare:
                    img = Properties.Resources.banner_rare;
                    break;
                default:
                    throw new Exception("Illegal Rarity");
            }
            e.Graphics.DrawImage(img, 0F, 0F, 270 * ScaleX, 75 * ScaleY);
        }
        private void SetCost(PaintEventArgs e)
        {
            if (Card.Rarity == CardRarity.Special && Card.Cost == 1000)
            {
                return;
            }
            if(Card.Color == CardColor.Red)
            {
                e.Graphics.DrawImage(Properties.Resources.bg_energy, 0F, 0F, 48 * ScaleX, 48 * ScaleY);
            }
            else
            {
                e.Graphics.DrawImage(Properties.Resources.bg_energy_colorless, 0F, 0F, 48 * ScaleX, 48 * ScaleY);
            }
            Font stringFont = new Font("Arial", 16);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            if (Card.Cost != -1)
            {
                e.Graphics.DrawString(Card.Cost.ToString(), stringFont, Brushes.Black, new RectangleF(0, 0, 48 * ScaleX, 48 * ScaleY), stringFormat);
            }
            else
            {
                e.Graphics.DrawString("X", stringFont, Brushes.Black, new RectangleF(0, 0, 48 * ScaleX, 48 * ScaleY), stringFormat);
            }
        }
        private void SetName(PaintEventArgs e)
        {
            Font stringFont = new Font("Arial", 14);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(Card.Name, stringFont, Brushes.Black, new RectangleF(0, 6 * ScaleY, 270 * ScaleX, 45 * ScaleY), stringFormat);
        }
        private void SetDescription(PaintEventArgs e)
        {
            Font stringFont = new Font("Arial", 10);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(Card.Description, stringFont, Brushes.White, new RectangleF(30 * ScaleX, 225 * ScaleY, 210 * ScaleX, 135 * ScaleY), stringFormat);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ScaleX = Width / (OriginX * 1.5f);
            ScaleY = Height / (OriginY * 1.5f);
            SetBackground(e);
            SetImage(e);
            SetFrame(e);
            SetBanner(e);
            SetCost(e);
            SetName(e);
            SetDescription(e);
        }
    }
}
