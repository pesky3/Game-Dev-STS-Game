using UnityEngine;

[CreateAssetMenu(menuName = "Stats")]
public class Stats : ScriptableObject
{
    [SerializeField] private string entityName;
    [SerializeField] private int maxHealth;
    [SerializeField] private float baseStrength;
    [SerializeField] private int maxMana;

    public string EntityName { get => entityName; }
    public int MaxHealth { get => maxHealth; }
    public float BaseStrength { get => baseStrength; }
    public int MaxMana { get => maxMana; }

}
