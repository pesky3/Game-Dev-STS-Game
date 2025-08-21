using UnityEngine;
using TMPro;

public class MenuTextUpdate : MonoBehaviour
{
    public TextMeshProUGUI myText;

    public void Start()
    {
        UpdateText();
    }
    public void UpdateText()
    {
        myText.text = "Your Chosen Difficulty is " + Difficulty.DifficultySetting;
    }
}
