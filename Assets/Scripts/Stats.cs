using UnityEngine;

[CreateAssetMenu(menuName = "Stats")]
public class Stats : ScriptableObject
{
    [SerializeField] private string entityName;
    [SerializeField] private int maxHealth;
    [SerializeField] private int baseStrength;

    public string EntityName { get => entityName; }
    public int MaxHealth { get => maxHealth; }
    public int BaseStrength { get => baseStrength; }

}
