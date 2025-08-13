using UnityEngine;
using static Difficulty;

public class MainMenuController : MonoBehaviour
{
    public GameObject difficultyMenu;
    public void ClickPlayButton()
    {
        
    }
    public void ClickSettingsButton()
    {
        difficultyMenu.SetActive(true);
    }
    public void ClickExitButton()
    {
        Application.Quit();
    }

    public void ClickReturnButton()
    {
        difficultyMenu.SetActive(false);
    }

    public void ClickHardMode()
    {
        Difficulty.DifficultySetting = DifficultyEnum.Hard;
    }

    public void ClickNormalMode()
    {
        Difficulty.DifficultySetting = DifficultyEnum.Normal;
    }
}
