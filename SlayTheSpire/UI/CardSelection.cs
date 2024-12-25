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
using SlayTheSpire.Game;
namespace SlayTheSpire.UI
{
    public partial class CardSelection : UserControl
    {
        CardButton Option1, Option2, Option3;
        int Rounds;
        public CardSelection(int rounds)
        {
            InitializeComponent();
            Rounds = rounds;
            GenerateNewSelection();
            DoubleBuffered = true;
        }
        private void GenerateNewSelection()
        {
            if (Rounds <= 0)
            {
                Program.MainForm.DeletePage(this);
                return;
            }
            Rounds--;
            Task.Run(() =>
            {
                List<AbstractCard> cards = CardLibrary.GetRandomCards(3);
                Option1 = new CardButton(cards[0]);
                Option2 = new CardButton(cards[1]);
                Option3 = new CardButton(cards[2]);
                Option1.MouseClick += Select;
                Option2.MouseClick += Select;
                Option3.MouseClick += Select;
                Invoke(() =>
                {
                    panel1.Controls.Add(Option1);
                    panel3.Controls.Add(Option2);
                    panel2.Controls.Add(Option3);
                    Option1.BringToFront();
                    Option2.BringToFront();
                    Option3.BringToFront();
                });
            });
        }
        private void Select(object? sender, MouseEventArgs e)
        {
            var btn = sender as CardButton;
            //if (btn != null)
            //{
            //    var card = btn.Card;
            //    Dungeon.Player.MasterDeck.Add(card);
            //}
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            Update();
            GenerateNewSelection();
        }
    }
}
