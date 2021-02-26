using UnityEngine;
using UnityEngine.UI;

public class LastPlay : MonoBehaviour
{
    public Text lastScore;

    public Text lastLive;

    private void Start()
    {
        lastScore.text = "Score: " + Score.CurrentScore.ToString();

        lastLive.text = "Live: " + SaveData.saveLastLive.ToString();
    }

}
