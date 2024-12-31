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
        int round = 0;

        public event Action Victory;
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
                var monster = Monsters[i];
                monster.BeforeBattle();
                monster.Die += () => 
                {
                    Monsters.Remove(monster);
                    if(Monsters.Count == 0)
                    {
                        Victory?.Invoke();
                    }
                };
            }
            PlayerTurnStart();


        }
        public void PlayerTurnStart()
        {
            Player.TurnStart();
        }
        public void MonstersTurnStart()
        {
            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].TurnStart();
                Monsters[i].UpdateBuff();
            }
            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].Act(Player, Monsters, round);
            }
            round++;
            for (int i = 0; i < Monsters.Count; i++)
            {
                Monsters[i].GenerateNewIntent(round);
            }
            PlayerTurnStart();
        }
    }
}
