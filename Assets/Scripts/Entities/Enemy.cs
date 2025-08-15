using UnityEngine;

public class Enemy : Entity
{
    public Stats stats;
    public HealthTextUpdate healthUI;

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
