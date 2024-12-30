using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game
{
    internal class Battle
    {
        public AbstractPlayer Player { get; }
        public List<AbstractMonster> Monsters { get; }
        public int CurrentFloor { get; }
        private int turn = 1;

        public Battle(AbstractPlayer player, List<AbstractMonster> monsters, int currentFloor)
        {
            Player = player;
            Monsters = monsters;
            CurrentFloor = currentFloor;
        }

        public void Enter()
        {
            Player.BeforeBattle();
            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].BeforeBattle();
                Monsters[i].Die += () => Monsters.RemoveAt(i);
            }
            PlayerTurnStart();


        }
        public void PlayerTurnStart()
        {
            Player.TurnStart();
        }
        public void MonstersTurnStart()
        {
            for(int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].Act(Player);
                Monsters[i].GenerateNewIntent(++turn);
            }
            PlayerTurnStart();
        }
    }
}
