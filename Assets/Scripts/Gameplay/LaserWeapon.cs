using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LaserWeapon : Weapon
{
    [SerializeField] private bool charging;

    public override void Shoot()
    {
        //base.Shoot();
        Debug.Log("CHARGIN LASER");
        charging = true;
        //when timer complete
        //ShootLaser();
    }
    
    private void ShootLaser()
    {
        StopShooting();
    }

    public override void StopShooting()
    {
        base.StopShooting();
        //RESET CHARGING BAR
        charging = false;
    }

    public void StartCooldown()
    {
        damage = 2;
    }
}
