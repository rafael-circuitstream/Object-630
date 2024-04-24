using UnityEngine;

/// <summary>
/// Class used to control the player object
/// </summary>
public class Player : Character
{
    private float strength; //defines the damage of the player
    protected override void Awake()
    {
        base.Awake();
        //weapon = new Weapon(bulletPrefab, 1, 8.5f);
    }
    protected override void Die()
    {
        base.Die();
        GameManager.singleton.StopGame();
        //Debug.Log("RESETING GAME");
    }

    public override void Move(Vector2 direction, float angleToRotate)
    {
        base.Move(direction, angleToRotate);
        //Debug.Log("Moving Player with speed of " + speed.ToString());
    }
    public override void Shoot()
    {
        weapon.Shoot(transform.position, transform.rotation, "Enemy");
    }

    public Player()
    {
        healthPoints = new Health(4);
        //weapon = new Weapon();

        speed = 5;
    }

    public Player(float speedParameter, int amountOfHealth) : base(speedParameter, amountOfHealth)
    {
        //weapon = new Weapon();
    }
}


