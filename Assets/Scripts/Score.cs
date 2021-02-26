using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    public static int CurrentLive = 1;

    public Text scoreText;

    public Text liveText;

    private void Start()
    {
        scoreText.text = CurrentScore.ToString();

        liveText.text = "Live: "+ CurrentLive.ToString();

    }
}
