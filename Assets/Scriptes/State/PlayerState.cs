using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class PlayerState : State
{
    public int Lv { get; set; }
    public int CurrentExp { get; set; }
    public int MaxExp { get; set; }
    public int Gold { get; set; }
    public PlayerState(int Lv,int CurrentEXp,int MaxExp,int Gold ,int power, int defense, int health, int critical)
        : base(power, defense, health, critical)
    {
        this.Lv = Lv;
        this.CurrentExp = CurrentEXp;
        this.MaxExp = MaxExp;
        this.Gold = Gold;
        //this.Power = power;
        //this.Defense = defense;
        //this.health = health;
        //this.critical= critical;

    }

    public void AddLv(int _Lv)
    {
        this.Lv = _Lv;
    }
    public void AddExp(int _exp)
    {
        this.CurrentExp = _exp;
    }
    public void AddMaxExp(int _MaxExp)
    {
        this.MaxExp = _MaxExp;
    }
    public void AddGold(int _Gold)
    {
        this.Gold = _Gold;
    }


}
