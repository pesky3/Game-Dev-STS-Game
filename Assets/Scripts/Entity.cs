using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public string entityName;
    public int maxHealth;
    public int currentHealth;


    public virtual void TakeDamage(int damage)
    {
        
    }

    protected virtual void ReceiveHealing()
    {

    }

    protected virtual void Die()
    {

    }
}
