using SlayTheSpire.Game.Powers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Monsters
{
    // 尖塔之盾
    // 110生命值
    // 其行为规律是：每三轮为一个周期
    // 周期中，第一、二轮一个是痛击（12伤，-1力），另一个是加固（给所有敌人30点格挡）
    // 第三轮必定使用粉碎：造成34伤害并获得99格挡
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
