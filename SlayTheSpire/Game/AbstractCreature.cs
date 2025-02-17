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
        private int currentHealth;
        public int CurrentHealth
        {
            get { return currentHealth; }
            protected set
            {
                if (currentHealth != value)
                {
                    currentHealth = value;
                    CurrentHealthChanged?.Invoke(currentHealth);
                }
            }
        }
        private int maxHealth;
        public int MaxHealth
        {
            get { return maxHealth; }
            protected set
            {
                maxHealth = value;
                MaxHealthChanged?.Invoke(maxHealth);
            }
        }
        public int currentBlock;
        public int CurrentBlock 
        { 
            get { return currentBlock; }
            set 
            {
                if (currentBlock != value)
                {
                    currentBlock = value;
                    CurrentBlockChanged?.Invoke(currentBlock);
                }
            } 
        }
        public int Money { get; protected set; }
        public List<AbstractPower> buffList;
        public List<AbstractPower> BuffList 
        { 
            get { return buffList; }
            protected set
            {
                buffList = value;
                BuffListChanged?.Invoke(buffList);
            }
        }
        public event Action<int>? CurrentHealthChanged;
        public event Action<int>? MaxHealthChanged;
        public event Action<int>? CurrentBlockChanged;
        public event Action<List<AbstractPower>>? BuffListChanged;

        protected AbstractCreature(bool isPlayer, string name, int maxHealth)
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
                BuffList[i].OnAttack(ref amount, 1);
            }
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnAttack(ref amount, 2);
            }
            if (amount < 0) return;
            target.Hurt(amount);
        }
        public void Hurt(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Hurt Damage amount must be large than 0");
            }
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnHurt(ref amount);
            }
            if (CurrentBlock > 0)
            {
                if (amount >= CurrentBlock)
                {
                    amount -= CurrentBlock;
                    LoseBlock(CurrentBlock);
                }
                else
                {
                    LoseBlock(amount);
                    amount = 0;
                }
            }
            LoseHealth(amount);
        }
        public void LoseHealth(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot lose a negative amount of health!");
            }
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnLoseHealth(ref amount);
            }
            CurrentHealth -= amount;
            if (CurrentHealth <= 0 && Die != null)
            {
                Die();
            }
        }
        public void LoseBlock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot lose a negative amount of block!");
            }

            CurrentBlock -= amount;
            if (CurrentBlock < 0)
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
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnAddBlock(ref amount, 1);
            }
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnAddBlock(ref amount, 2);
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
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
        }
        public void ApplyPower(AbstractPower power)
        {
            if (power.Type == PowerType.Debuff)
            {
                int amount = power.Amount;
                for (int i = 0; i < BuffList.Count; i++)
                {
                    BuffList[i].OnAppliedDebuff(ref amount);
                }
                power.Amount = amount;
                if(power.Amount == 0)
                {
                    UpdateBuff();
                    return;
                }
            }
            int index = BuffList.FindIndex(pwr => pwr.Name.Equals(power.Name));
            if (index < 0)
            {
                BuffList.Add(power);
            }
            else
            {
                BuffList[index].Amount += power.Amount;
            }
            UpdateBuff();
        }
        public event Action? Die;
        public void UpdateBuff()
        {
            List<AbstractPower> ToRemove = new List<AbstractPower>();
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnUpdate(this, ToRemove);
            }
            BuffList = BuffList.Except(ToRemove).ToList();
            BuffListChanged?.Invoke(buffList);
        }
        public virtual void BeforeBattle()
        {
            CurrentHealthChanged?.Invoke(currentHealth);
            CurrentBlockChanged?.Invoke(currentBlock);
            MaxHealthChanged?.Invoke(maxHealth);
            BuffListChanged?.Invoke(buffList);
        }
    }
}
