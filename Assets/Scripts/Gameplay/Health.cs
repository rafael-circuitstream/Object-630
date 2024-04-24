using UnityEngine;
using UnityEngine.Events;
public class Health
{
    private int healthPoints;
    public UnityEvent<int> OnLifeChanged;
    public UnityEvent OnDie;

    public int GetHealth()
    {
        return healthPoints;
    }
    public int DecreaseHealth()
    {
        //checkinf if infinite life... if yes do not decrease

        return DecreaseHealth(1);
    }

    public int DecreaseHealth(int damage)
    {
        healthPoints -= damage;
        OnLifeChanged.Invoke(healthPoints);
        if (healthPoints <= 0)
        {
            OnDie.Invoke();
        }
        Debug.Log("Decreasing health to " + healthPoints);
        return healthPoints;
    }

    public int IncreaseHealth()
    {
        //Debug.Log("Increasing health");
        return IncreaseHealth(1);
    }

    public int IncreaseHealth(int toAdd)
    {
        healthPoints += toAdd;
        OnLifeChanged.Invoke(healthPoints);
        return healthPoints;
    }

    public Health(int maxHealth)
    {
        healthPoints = maxHealth;
        OnLifeChanged = new UnityEvent<int>();
        OnDie = new UnityEvent();

        OnLifeChanged.Invoke(healthPoints);
    }
}
