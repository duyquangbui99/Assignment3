using UnityEngine.UI;
using UnityEngine;

public class MusicOnOff : MonoBehaviour
{
    public Text musicText;
    public AudioClip gameMusic;
    public AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void pauseMusic()
    {
        audiosource.Pause();
    }

    public void resumeMusic()
    {
        audiosource.UnPause();
    }
}
