using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float attackDistance;
    private int touchDamage;
    private Player player;
    private float timer;
    [SerializeField] private float shootCooldown = 3;

    protected override void Awake()
    {
        base.Awake();
        player = FindObjectOfType<Player>();
        timer = shootCooldown;
    }

    public void SetupEnemy(int health, float speed, int damage)
    {
        //weapon = new LaserWeapon();
        //this.speed = speed;

    }

    private void Update()
    {
        if(player != null)
        {
            float distance = Vector2.Distance(player.transform.position, transform.position);
            Vector2 directionToThePlayer = player.transform.position - transform.position;

            if (distance > attackDistance)
            {
                Move(directionToThePlayer.normalized, Mathf.Atan2(directionToThePlayer.y, directionToThePlayer.x) * Mathf.Rad2Deg);
            }
            else //means the enemy is close to the target
            {
                //DAMAGE THE PLAYER
                timer += Time.deltaTime;
                if (timer > shootCooldown)
                {
                    Shoot();
                    timer = 0;
                }

                //every 2 seconds
                //rigidBody.velocity = Vector2.zero;
            }
        }
    }

    public override void Shoot()
    {
        player.GetDamage(1);
        //weapon.Shoot(transform.position, transform.rotation, "Player");
    }

    public override void Move(Vector2 direction, float angleToRotate)
    {
        base.Move(direction, angleToRotate);
        //Debug.Log("Moving Enemy with speed of " + speed.ToString());
    }
    protected override void Die()
    {
        base.Die();
        //GameManager.singleton.AddScore();
    }


    public Enemy(float speedParam, int touchDamage, int healthPoints) : base(speedParam, healthPoints)
    {
        this.touchDamage = touchDamage;
    }
}
