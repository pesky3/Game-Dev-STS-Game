using UnityEngine;
using TMPro;

public class HealthTextUpdate : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public Entity entity;



    public void UpdateHealth()
    {
        myText.text = entity.currentHealth + "/" + entity.maxHealth + " HP";
    }

}
