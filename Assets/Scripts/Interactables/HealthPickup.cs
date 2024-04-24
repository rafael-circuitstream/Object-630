using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : PickUp
{
    [SerializeField] private int amountOfHealth;
    public override void PickMe(Character character)
    {
        if (character is Player)
        {
            
            character.GetHealthInformation().IncreaseHealth(amountOfHealth);
            base.PickMe(character);
        }
            
    }
}
