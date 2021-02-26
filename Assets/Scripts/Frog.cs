using UnityEngine;
using UnityEngine.SceneManagement;
public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;


    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }

        else if (Input.GetKeyDown("a"))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }

        else if (Input.GetKeyDown("w"))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }

        else if (Input.GetKeyDown("s"))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Limit")
        {
            this.gameObject.transform.position = new Vector2(0, -4);
        }

        if (col.tag == "Car")
        {
            Score.CurrentLive -= 1;
            SceneManager.LoadScene("Main");
        }

        if (Score.CurrentLive == 0)
        {
            SceneManager.LoadScene("Exit");
        }

    }


}
