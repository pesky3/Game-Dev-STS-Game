using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    public GameObject difficultyMenu;
    public void ClickPlayButton()
    {
        SceneManager.LoadScene(1);
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
        Difficulty.DifficultySetting = Difficulty.DifficultyEnum.Hard;
        Debug.Log(Difficulty.DifficultySetting);
    }

    public void ClickNormalMode()
    {
        Difficulty.DifficultySetting = Difficulty.DifficultyEnum.Normal;
        Debug.Log(Difficulty.DifficultySetting);
    }
}
