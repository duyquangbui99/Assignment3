using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public InputField inputfield;

    public Slider speedSlider;

    public Dropdown lvieDropdown; 

    public Text nameText;

    public Text speedText;

    public static string playerName = "Name";

    public static int saveLastLive = 1 ;

    public void saveName()
    {
        playerName = inputfield.text;
        Debug.Log("Updated inputfied");
    }

    public void displayName()
    {
        nameText.text = "WELCOME " + playerName + " TO THE GAME!";
        Debug.Log("Updated name");
    }

    public void updateSpeed(float value)
    {
        Car.speed = speedSlider.value;

        speedText.text = speedSlider.value.ToString("0");
    }

    public void liveChange()
    {
        switch (lvieDropdown.value)
        {
            default:
                Score.CurrentLive = 1;
                saveLastLive = 1;
                break;
            case 0:
                Score.CurrentLive = 1;
                saveLastLive = 1;
                break;
            case 1:
                Score.CurrentLive = 2;
                saveLastLive = 2;
                break;
            case 2:
                Score.CurrentLive = 3;
                saveLastLive = 3;
                break;
        }
    }

}
