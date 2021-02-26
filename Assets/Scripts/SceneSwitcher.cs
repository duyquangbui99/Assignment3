using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{

    public void LoadStart()
    {
        SceneManager.LoadScene("Main");
        Score.CurrentScore = 0;
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void resetGame()
    {
        SceneManager.LoadScene("Main");
        Score.CurrentScore = 0;
        Score.CurrentLive = 1;

        SaveData.saveLastLive = 1;
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
}
