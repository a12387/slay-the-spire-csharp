using SlayTheSpire.Game;
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
    internal partial class CardButton : UserControl
    {
        private static Dictionary<CardRarity, Dictionary<CardType, Bitmap>> Frames = new()
        {
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
        };
        AbstractCard Card { get; }
        public CardButton(AbstractCard card)
        {
            InitializeComponent();
            Card = card;
            InitializeCard(card);
            
        }
        private void InitializeCard(AbstractCard card)
        {
            SetBackground(card.Type, card.Color);
            SetDescription(card.Description);
            SetFrame(card.Rarity, card.Type);
            SetImage(card.Name);
            SetName(card.Name);
            SetCost(card.Cost);
        }
        private void SetBackground(CardType type, CardColor color)
        {
            if(color == CardColor.Colorless)
            {
                pictureBoxCost.Image = Properties.Resources.bg_energy_colorless;
                BackgroundImage = Properties.Resources.bg_colorless;
            }
            else
            {
                pictureBoxCost.Image = Properties.Resources.bg_energy;
                switch (type)
                {
                    case CardType.Attack:
                        BackgroundImage = Properties.Resources.bg_attack;
                        break;
                    case CardType.Skill:
                        BackgroundImage = Properties.Resources.bg_skill;
                        break;
                    case CardType.Power:
                        BackgroundImage = Properties.Resources.bg_power;
                        break;
                    default:
                        throw new ArgumentException("Status must be colorless!");
                }
            }
        }
        private void SetDescription(string description)
        {
            labelDescription.Text = description;
        }
        private void SetFrame(CardRarity rarity, CardType type)
        {
            pictureBoxFrame.Image = Frames[rarity][type];
        }
        private void SetImage(string name)
        {
            pictureBoxImage.Image = CardLibrary.GetCardImage(name);
        }
        private void SetName(string name)
        {
            labelName.Text = name;
        }
        private void SetCost(int cost)
        {
            labelCost.Text = cost.ToString();
        }
    }
}
