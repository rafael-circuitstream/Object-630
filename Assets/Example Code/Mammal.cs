using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal
{

    public override void Eat()
    {
        base.Eat();
        health++;

        
    }
    public override void Move()
    {
        base.Move();
    }

    public override void Reproduce()
    {
        throw new System.NotImplementedException();
    }

    public override void Sleep()
    {

    }
}

public class Lion : Mammal
{

}

public class Bat : Mammal, IFly
{
    public void Fly()
    {
        
    }
}

public class Platypus : Mammal, ILayEggs
{
    public void LayEgg()
    {
        
    }
}



