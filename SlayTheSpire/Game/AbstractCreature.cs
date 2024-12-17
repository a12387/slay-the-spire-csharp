﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game
{
    internal abstract class AbstractCreature
    {
        public bool IsPlayer { get; }
        public string Name { get; }
        public int CurrentHealth { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int CurrentBlock {  get; protected set; }
        public int Money { get; protected set; }
        public List<AbstractPower> BuffList { get; protected set; }

        protected AbstractCreature(bool isPlayer, string name, int maxHealth ) 
        { 
            IsPlayer = isPlayer;
            Name = name;
            CurrentHealth = maxHealth;
            MaxHealth = maxHealth;
            CurrentBlock = 0;
            Money = 0;
            BuffList = new List<AbstractPower>();
        }
        public void Attack(int amount, AbstractCreature target)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Attack Damage amount must be large than 0");
            }
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnAttack(amount);
            }
            target.Hurt(amount);
        }
        public void Hurt(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Hurt Damage amount must be large than 0");
            }
            for (int i =0; i < BuffList.Count; i++)
            {
                BuffList[i].OnHurt(amount);
            }
            if (CurrentBlock > 0)
            {
                if(amount >= CurrentBlock)
                {
                    amount -= CurrentBlock;
                    LoseBlock(CurrentBlock);
                }
                else
                {
                    amount = 0;
                    LoseBlock(amount);
                }
            }
            CurrentHealth -= amount;
            if (CurrentHealth <= 0)
            {
                Die();
            }
        }
        public void LoseHealth(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot lose a negative amount of health!");
            }
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnLoseHealth(amount);
            }
            CurrentHealth -= amount;
            if (CurrentHealth <= 0)
            {
                Die();
            }
        }
        public void LoseBlock(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot lose a negative amount of block!");
            }

            CurrentBlock -= amount;
            if(CurrentBlock < 0)
            {
                CurrentBlock = 0;
            }
        }
        public void AddBlock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot gain a negative amount of block!");
            }

            CurrentBlock += amount;
            if (CurrentBlock > 999)
            {
                CurrentBlock = 999;
            }
        }
        public void Heal(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot heal a negative amount of health!");
            }

            CurrentHealth += amount;
            if(CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
        }
        public void Die()
        {

        }
    }
}
