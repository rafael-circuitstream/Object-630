using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal
{
    protected int damage;
    protected int health;

    public virtual void Eat()
    {
        //Eating

    }

    public abstract void Sleep();

    public abstract void Reproduce();

    public virtual void Move()
    {
        // I'm moving myself
    }

}
