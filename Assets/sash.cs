using UnityEngine;
using UnityEngine.SceneManagement;  

public class SceneTransition : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Oyuncu"))
        {
          
            SceneManager.LoadScene("ikinci"); 
        }
    }
}
