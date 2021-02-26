using UnityEngine;

public class BoarderLimit : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D()
    {
        player.gameObject.transform.position = new Vector2(0, -4);
    }
}
