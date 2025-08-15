using UnityEngine;

public class Player : Entity
{
    public Stats stats; //to be assigned later through inspector
    public int maxMana;
    public int currentMana;
    public HealthTextUpdate healthUI;

    void Start()
    {
        entityName = stats.EntityName;
        maxHealth = stats.MaxHealth;
        baseStrength = stats.BaseStrength;
        maxMana = stats.MaxMana;
        currentMana = maxMana;
        currentHealth = maxHealth;
    }

    public override void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthUI.UpdateHealth();
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public override void ReceiveHealing(int heal)
    {
        currentHealth += heal;
        healthUI.UpdateHealth();
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    protected override void Die()
    {
        Destroy(gameObject);
    }



}
