using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
   Scene scene;
    public int sceneIndex;
    
    
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; 
        SceneManager.LoadScene(5, LoadSceneMode.Additive);
       
    }

    void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; 
        SceneManager.UnloadSceneAsync(5); 
    }
        
        
    void Start()
    {
        
    }

    
   
    
    public void Levelscene()
        {
            SceneManager.LoadScene(sceneIndex);
        }

    public void DurdurmaFonk()
    {
        SceneManager.LoadScene(1);
    }

    public void SoonFonk()
    {
        SceneManager.LoadScene(4);
    }

    public void ExitFonk()
    {
        Application.Quit();
    }

    public void PauseFonk()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(1);
    }

    public void ResumeFonk()
    {
        
        SceneManager.UnloadSceneAsync(5);
    }

    public void RestartFonk()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(0);
    }
}
