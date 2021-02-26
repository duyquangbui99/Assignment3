using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Main");
        Score.CurrentScore = 0;
        Score.CurrentLive = 1;

        SaveData.saveLastLive = 1;

        Resume();
    }

    public void saveGame()
    {
        PlayerPrefs.SetInt("score", Score.CurrentScore);

        PlayerPrefs.SetInt("live", Score.CurrentLive);

        PlayerPrefs.SetString("name", SaveData.playerName);

        //PlayerPrefs.Save();

        Debug.Log("Game is saved, Score: " + Score.CurrentScore + ", Live: " + Score.CurrentLive + ", Name: " + SaveData.playerName);
    }

    public void loadGame()
    {
        Score.CurrentScore = PlayerPrefs.GetInt("score");

        Score.CurrentLive = PlayerPrefs.GetInt("live");

        SaveData.playerName = PlayerPrefs.GetString("name");

        SceneManager.LoadScene("Main");
        Resume();

        Debug.Log("Load saved game!");

    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }


}
