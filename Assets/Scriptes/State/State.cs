using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    public string name { get; set; }
    public int Power { get; set; }
    public int Defense { get; set; }
    public int health { get; set; }
    public int critical { get; set; }

    public State(string name,int power, int defense, int health, int critical)
    {
        this.name = name;
        this.Power = power;
        this.Defense = defense;
        this.health = health;
        this.critical = critical;
    }

    public  void  AddPower(int _power)
    {
        this.Power = _power;
    }
    public void AddDefense(int _Defense)
    {
        this.Defense = _Defense;
    }
    public void Addhealth(int _health)
    {
        this.health = _health;
    }
    public void Addcritical(int _critical)
    {
        this.critical = _critical;
    }


}
