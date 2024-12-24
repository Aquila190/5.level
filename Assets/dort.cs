using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTransition3 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Oyuncu"))
        {

            SceneManager.LoadScene("4");
        }
    }
}
