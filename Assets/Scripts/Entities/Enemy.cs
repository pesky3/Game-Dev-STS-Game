using UnityEngine;

public class Enemy : Entity
{
    public Stats stats;

    void Start()
    {
        entityName = stats.EntityName;
        maxHealth = Mathf.RoundToInt(stats.MaxHealth * Difficulty.EnemyDifficultyMultipliers().healthMultiplier);
        baseStrength = stats.BaseStrength * Difficulty.EnemyDifficultyMultipliers().strengthMultiplier;
        currentHealth = maxHealth;


    }
    public override void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public override void ReceiveHealing(int heal)
    {
        currentHealth += heal;
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
