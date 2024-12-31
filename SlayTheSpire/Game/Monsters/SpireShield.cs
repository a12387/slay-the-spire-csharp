using SlayTheSpire.Game.Powers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Monsters
{
    internal class SpireShield : AbstractMonster
    {
        MonsterIntent LastMove { get; set; }
        public SpireShield() : base("Spire Shield", 110)
        {

        }

        public override void GenerateNewIntent(int round)
        {
            int intent = round % 3;
            switch (intent)
            {
                case 0:
                    Random random = new Random();
                    int randomValue = random.Next(0, 2);
                    if (randomValue == 0)
                    {
                        SetIntent(MonsterIntent.AttackDebuff);
                    }
                    else
                    {
                        SetIntent(MonsterIntent.Defend);
                    }
                    break;
                case 1:
                    if(LastMove== MonsterIntent.Defend)
                        SetIntent(MonsterIntent.AttackDebuff);
                    else
                        SetIntent(MonsterIntent.Defend);
                    break;
                case 2:
                    SetIntent(MonsterIntent.AttackDefend);
                    break;
            }
        }
        private void SetIntent(MonsterIntent moveType)
        {
            switch (moveType)
            {
                case MonsterIntent.AttackDebuff:
                    DamageAmount = 12;
                    DamageTimes = 1;
                    CurrentIntent = Game.MonsterIntent.AttackDebuff;
                    break;
                case MonsterIntent.AttackDefend:
                    DamageAmount = 34;
                    DamageTimes = 1;
                    CurrentIntent = Game.MonsterIntent.AttackDefend;
                    break;
                case MonsterIntent.Defend:
                    DamageAmount = 0;
                    DamageTimes = 0;
                    CurrentIntent = Game.MonsterIntent.Defend;
                    break;
            }
            LastMove = moveType;
        }
        public override void Act(AbstractPlayer player,List<AbstractMonster> monsters, int round)
        {
            switch (CurrentIntent)
            {
                case Game.MonsterIntent.Defend:
                    for(int i=0;i<monsters.Count; i++)
                    {
                        monsters[i].AddBlock(30);
                    }
                    break;
                case Game.MonsterIntent.AttackDebuff:
                    Attack(DamageAmount, player);
                    player.ApplyPower(new Strength(-1));
                    break;
                case Game.MonsterIntent.AttackDefend:
                    Attack(DamageAmount, player);
                    AddBlock(99);
                    break;
            }
        }
        public override void BeforeBattle()
        {
            base.BeforeBattle();
            GenerateNewIntent(0);
            ApplyPower(new Artifact(2));
        }
    }
}
