using SlayTheSpire.Game.Cards.Red;
using SlayTheSpire.Game.Powers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Monsters
{
    internal class SpireSpear : AbstractMonster
    {
        MonsterIntent LastMove;
        public SpireSpear() : base("Spire Spear", 10)
        {

        }
        public override void GenerateNewIntent(int round)
        {
            if(round == 0)
            {
                SetIntent(MonsterIntent.AttackDebuff);
                return;
            }
            int intent = round % 3;
            switch (intent)
            {
                case 0:
                    if(LastMove == MonsterIntent.AttackDebuff)
                        SetIntent(MonsterIntent.Buff);
                    else
                        SetIntent(MonsterIntent.AttackDebuff);
                    break;
                case 1:
                    SetIntent(MonsterIntent.Attack);
                    break;
                case 2:
                    Random random = new Random();
                    int randomValue = random.Next(0, 2);
                    if (randomValue == 0)
                        SetIntent(MonsterIntent.Buff);
                    else
                        SetIntent(MonsterIntent.AttackDebuff);
                    break;
            }
        }
        private void SetIntent(MonsterIntent Intent)
        {
            switch (Intent)
            {
                case MonsterIntent.Attack:
                    CurrentIntent = MonsterIntent.Attack;
                    DamageAmount = 10;
                    DamageTimes = 3;
                    break;
                case MonsterIntent.Buff:
                    CurrentIntent = MonsterIntent.Buff;
                    DamageAmount = 0;
                    DamageTimes = 0;
                    break;
                case MonsterIntent.AttackDebuff:
                    CurrentIntent = MonsterIntent.AttackDebuff;
                    DamageAmount = 5;
                    DamageTimes = 2;
                    break;
            }
            LastMove = Intent;
        }
        public override void Act(AbstractPlayer player, List<AbstractMonster> monsters, int round)
        {
            switch(CurrentIntent)
            {
                case MonsterIntent.Attack:
                    for (int i = 0; i < DamageTimes; i++)
                    {
                        Attack(DamageAmount, player);
                    }
                    break;
                case MonsterIntent.Buff:
                    monsters.ForEach(monster =>
                    { 
                        monster.ApplyPower(new Strength(2));
                        //monster.UpdateBuff();
                    });
                    break;
                case MonsterIntent.AttackDebuff:
                    for (int i = 0; i < DamageTimes; i++)
                    {
                        Attack(DamageAmount, player);
                        player.DiscardPile.Add(new Burn());
                    }
                    break;
            }
        }
        public override void BeforeBattle()
        {
            GenerateNewIntent(0);
            ApplyPower(new Artifact(2));
        }
    }
}
