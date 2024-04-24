using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bird : Animal, ILayEggs
{
    public override void Eat()
    {
        base.Eat();
    }

    public void LayEgg()
    {
        //Spawn an egg in my position
    }

    public override void Move()
    {
        base.Move();
    }

    public override void Reproduce()
    {
       
    }

    public override void Sleep()
    {

    }

}

public class Eagle : Bird, IFly
{
    public void Fly()
    {
        
    }
}

public class Chicken : Bird
{

}



