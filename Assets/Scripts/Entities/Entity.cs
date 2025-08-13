using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public string entityName;
    public int maxHealth;
    public int currentHealth;
    public float baseStrength;


    public virtual void TakeDamage(int damage)
    {
        
    }

    public virtual void ReceiveHealing(int heal)
    {

    }

    protected virtual void Die()
    {

    }
}
