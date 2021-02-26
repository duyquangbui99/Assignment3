using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour
{
    public Text displayPlayerName;
    void Start()
    {
        displayPlayerName.text = SaveData.playerName;
    }
}
