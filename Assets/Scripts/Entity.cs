using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public string entityName;
    public int maxHealth;
    public int currentHealth;


    protected virtual void TakeDamage()
    {
        
    }
}
