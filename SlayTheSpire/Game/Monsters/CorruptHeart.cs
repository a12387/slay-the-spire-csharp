using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SlayTheSpire.Game.Monsters
{
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
        public override void Act(AbstractPlayer player)
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
                    //debuff
                    break;
                case MonsterIntent.Buff:
                    //buff
                    break;
            }
        }
        private void SetAttackIntent(MoveType move)
        {
            CurrentIntent = MonsterIntent.Attack;
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
        }
    }
}
