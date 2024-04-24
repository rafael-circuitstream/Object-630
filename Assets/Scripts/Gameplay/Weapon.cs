using UnityEngine;


[CreateAssetMenu]
public class Weapon : ScriptableObject
{
    [SerializeField] private string name;

    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] protected int damage;
    [SerializeField] protected float bulletSpeed;
    [SerializeField] protected float range;
    [SerializeField] protected float fireRate;

    /// <summary>
    /// Method to shoot a bullet with some damage and direction
    /// </summary>
    /// 
    public virtual void StartShooting()
    {

    }

    public virtual void Shoot()
    {

    }
    public virtual void StopShooting()
    {
        Debug.Log("Weapon stopped shooting");
    }

    public virtual void Shoot(Vector2 spawnPos, Quaternion aim, string tag)
    {
        //need a position (probably from the player)
        //direction that the player is looking
        Bullet b = GameObject.Instantiate(bulletPrefab, spawnPos, aim);
        b.SetupBullet(damage, bulletSpeed, tag);

        //Debug.Log(mySound);
        //Instantiate new bullet
    }


}




