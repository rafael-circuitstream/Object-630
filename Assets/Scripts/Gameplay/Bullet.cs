using UnityEngine;
public class Bullet : MonoBehaviour
{
    //TODO: you need to create another variable time of existance
    protected float speed = 5f;
    protected int damage;
    protected string tagFilter;
    private void Start()
    {
        Destroy(gameObject, 3f);
    }
    public void SetupBullet(int damageParam, float speedParam)
    {
        speed = speedParam;
        damage = damageParam;
    }
    public void SetupBullet(int damageParam, float speedParam, string tagFilter)
    {
        speed = speedParam;
        damage = damageParam;
        this.tagFilter = tagFilter;
    }

    //This is to move the projectile forward
    public void MoveProjectile(float damage = 5)
    {
        
    }

    //move the projectile towards a target
    public void MoveProjectile(Transform target) 
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody.CompareTag(tagFilter)) //Make it compatible with weapons from players and enemies
        {
            collision.attachedRigidbody.GetComponent<IDamageable>().GetDamage(damage);
            Destroy(gameObject);
        }
        
    }

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
