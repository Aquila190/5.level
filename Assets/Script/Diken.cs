using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneOnCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
