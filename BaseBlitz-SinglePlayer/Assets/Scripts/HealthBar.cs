using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar
{
    //fields

    int currHealth;
    int currMaxHealth;

    //properties
    public int Health{
        get{
            return currHealth;
        }
        set{
            currHealth=value;
        }
    }

    public int MaxHealth{
        get{
            return currMaxHealth;
        }
        set{
            currMaxHealth=value;
        }
    }

    //constructor
    public HealthBar(int health, int maxHealth)
    {
        currHealth=health;
        currMaxHealth=maxHealth;

    }

    //method
    public void DamageUnit(int damageAmt){
        if(currHealth>0){
            currHealth-=damageAmt;
        }
    }

    public void HealHealth(int healAmt){
        if(currHealth<currMaxHealth){
            currHealth+=healAmt;
        }
        if(currHealth>currMaxHealth){
            currHealth=currMaxHealth;
        }
    }

}
