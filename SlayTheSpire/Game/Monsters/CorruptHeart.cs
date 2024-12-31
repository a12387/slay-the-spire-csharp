using SlayTheSpire.Game.Cards.Red;
using SlayTheSpire.Game.Powers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SlayTheSpire.Game.Monsters
{
    // 腐化之心
    // 800生命值
    // 其行为规律是：每三轮为一个周期，进行强化、攻击、攻击
    // 每个周期中的第二、三轮中，有一个是重击，另一个则是连击
    // 心脏的第一次强化是强力debuff（上虚弱、脆弱、易伤，并塞五张状态牌）
    // 第二次强化加两层人工制品
    // 第三次强化加一层律动
    // 第四次强化加疼痛戳刺
    // 第五次强化加10力量
    // 以后的强化都是加50力量
    internal class CorruptHeart : AbstractMonster
    {
        enum MoveType
        {
            None,
            Bash,
            Combo
        }
        MoveType LastMove { get; set; }
        public CorruptHeart() : base("Corrupt Heart", 800)
        {
            LastMove = MoveType.None;
        }
        public override void GenerateNewIntent(int round)
        {
            int intent = round % 3;
            if (intent == 0)
            {
                if (round == 0)
                {
                    CurrentIntent = MonsterIntent.StrongDebuff;
                }
                else
                {
                    CurrentIntent = MonsterIntent.Buff;
                }
                LastMove = MoveType.None;
            }
            else//攻击回合
            {
                switch (LastMove)
                {
                    case MoveType.None:
                        Random random = new Random();
                        int randomValue = random.Next(0, 2);
                        if (randomValue == 0)
                        {
                            SetAttackIntent(MoveType.Bash);
                        }
                        else
                        {
                            SetAttackIntent(MoveType.Combo);
                        }
                        break;
                    case MoveType.Bash:
                        SetAttackIntent(MoveType.Combo);
                        break;
                    case MoveType.Combo:
                        SetAttackIntent(MoveType.Bash);
                        break;
                }
            }
        }
        public override void Act(AbstractPlayer player, List<AbstractMonster> monsters, int round)
        {
            switch (CurrentIntent)
            {
                case MonsterIntent.Attack:
                    for (int i = 0; i < DamageTimes; i++)
                    {
                        Attack(DamageAmount,player);
                    }
                    break;
                case MonsterIntent.StrongDebuff:
                    player.ApplyPower(new Powers.Vulnerable(2));
                    player.ApplyPower(new Powers.Weak(2));
                    player.ApplyPower(new Powers.Frail(2));
                    //player.UpdateBuff();
                    player.DrawPile.Add(new Burn());
                    player.DrawPile.Add(new Dazed());
                    player.DrawPile.Add(new Slimed());
                    player.DrawPile.Add(new VoidCard());
                    player.DrawPile.Add(new Wound());
                    player.DrawPile.Shuffle();
                    break;
                case MonsterIntent.Buff:
                    for(int i = 0; i < BuffList.Count; i++)
                    {
                        if(BuffList[i].Name == "Strength" && BuffList[1].Amount < 0)
                        {
                            BuffList[i].Amount = 0;
                        }
                    } //清空负力量
                    ApplyPower(new Strength(2));
                    switch (round / 3)
                    {
                        case 1: ApplyPower(new Artifact(2)); break;
                        case 2: ApplyPower(new BeatOfDeath(1)); break;
                        case 3: ApplyPower(new PainfulStabs()); break;
                        case 4: ApplyPower(new Strength(10)); break;
                        default:
                            ApplyPower(new Strength(50)); break;
                    }
                    UpdateBuff();
                    break;
            }
        }
        private void SetAttackIntent(MoveType move)
        {
            if (move == MoveType.Bash)
            {
                DamageAmount = 40;
                DamageTimes = 1;
                LastMove = MoveType.Bash;
            }
            else if (move == MoveType.Combo)
            {
                DamageAmount = 2;
                DamageTimes = 12;
                LastMove = MoveType.Combo;
            }
            else
            {
                DamageTimes = 0;
            }
            CurrentIntent = MonsterIntent.Attack;
        }
        public override void BeforeBattle()
        {
            base.BeforeBattle();
            GenerateNewIntent(0);
            ApplyPower(new Invincible(300));
            ApplyPower(new BeatOfDeath(1));
        }
    }
}
