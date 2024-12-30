using SlayTheSpire.Game.Cards.Red;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards
{
    internal static class CardLibrary
    {
        static private Dictionary<string, Bitmap> CardImages = new Dictionary<string, Bitmap>()
        {
            ["Anger"] = Properties.Resources.anger,
            ["Barricade"] = Properties.Resources.barricade,
            ["Bash"] = Properties.Resources.bash,
            ["BattleTrance"] = Properties.Resources.battle_trance,
            ["BloodLetting"] = Properties.Resources.bloodletting,
            ["Bludgeon"] = Properties.Resources.bludgeon,
            ["BodySlam"] = Properties.Resources.body_slam,
            ["BurningPact"] = Properties.Resources.burning_pact,
            ["Cleave"] = Properties.Resources.cleave,
            ["Clothesline"] = Properties.Resources.clothesline,
            ["Corruption"] = Properties.Resources.corruption,
            ["DarkEmbrace"] = Properties.Resources.dark_embrace,
            ["Defend"] = Properties.Resources.defend,
            ["DemonForm"] = Properties.Resources.demon_form,
            ["Entrench"] = Properties.Resources.entrench,
            ["Exhume"] = Properties.Resources.exhume,
            ["FeelNoPain"] = Properties.Resources.feel_no_pain,
            ["Inflame"] = Properties.Resources.inflame,
            ["LimitBreak"] = Properties.Resources.limit_break,
            ["Offering"] = Properties.Resources.offering,
            ["PommelStrike"] = Properties.Resources.pommel_strike,
            ["PowerThrough"] = Properties.Resources.power_through,
            ["SecondWind"] = Properties.Resources.second_wind,
            ["ShrugItOff"] = Properties.Resources.shrug_it_off,
            ["SpotWeakness"] = Properties.Resources.spot_weakness,
            ["Strike"] = Properties.Resources.strike,
            ["TrueGrit"] = Properties.Resources.true_grit,
            ["Whirlwind"] = Properties.Resources.whirlwind,
            ["Burn"] = Properties.Resources.burn,
            ["Dazed"] = Properties.Resources.dazed,
            ["Slimed"] = Properties.Resources.slimed,
            ["Void"] = Properties.Resources._void,
            ["Wound"] = Properties.Resources.wound,
        };
        static private List<AbstractCard> Cards = new List<AbstractCard>()
        {
            Anger.Instance,
            Barricade.Instance,
            Bash.Instance,
            BattleTrance.Instance,
            BloodLetting.Instance,
            Bludgeon.Instance,
            BodySlam.Instance,
            BurningPact.Instance,
            Cleave.Instance,
            Clothesline.Instance,
            Corruption.Instance,
            DarkEmbrace.Instance,
            Defend.Instance,
            DemonForm.Instance,
            Entrench.Instance,
            Exhume.Instance,
            FeelNoPain.Instance,
            Inflame.Instance,
            LimitBreak.Instance,
            Offering.Instance,
            PommelStrike.Instance,
            PowerThrough.Instance,
            SecondWind.Instance,
            ShrugItOff.Instance,
            SpotWeakness.Instance,
            Strike.Instance,
            TrueGrit.Instance,
            Whirlwind.Instance,
            //Burn.Instance,
            //Dazed.Instance,
            //Slimed.Instance,
            //VoidCard.Instance,
            //Wound.Instance,
        };
        static public Bitmap GetCardImage(string name)
        {
            return CardImages[name];
        }
        static public List<AbstractCard> GetRandomCards(int num)
        {
            List<AbstractCard> cards = new List<AbstractCard>();
            Random rnd = new Random();
            while(num > 0)
            {
                AbstractCard card = Cards[rnd.Next(Cards.Count)];
                if (cards.Contains(card))
                    continue;
                else
                {
                    cards.Add(card);
                    num--;
                }
            }
            return cards;
        }
    }
}
