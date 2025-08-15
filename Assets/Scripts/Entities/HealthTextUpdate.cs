using UnityEngine;
using TMPro;

public class HealthTextUpdate : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public Entity entity;
    void Start()
    {
        myText.text = entity.currentHealth + "/" + entity.maxHealth + " HP";
    }


    public void UpdateHealth()
    {
        myText.text = entity.currentHealth + "/" + entity.maxHealth + " HP";
    }

}
