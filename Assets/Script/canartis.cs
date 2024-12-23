using UnityEngine;
using TMPro; 

public class PlayerController : MonoBehaviour
{
    public Health playerHealth; 
    public int healAmount = 30; 
    public float healCooldown = 60f; 
    private float lastHealTime = 0f; 
    private float timeRemaining; 
    public TextMeshProUGUI countdownText; 

    void Start()
    {
        timeRemaining = healCooldown; 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            if (Time.time - lastHealTime >= healCooldown)
            {
                Heal();
                lastHealTime = Time.time; 
                timeRemaining = healCooldown; 
            }
            else
            {
                
                Debug.Log("You have to wait 60 saeconds to press the F key");
            }
        }

        
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; 
            UpdateCountdownText(timeRemaining); 
        }
        else
        {
            timeRemaining = 0; 
        }
    }

    
    void Heal()
    {
        if (playerHealth != null)
        {
            playerHealth.Heal(healAmount);
        }
    }

    
    void UpdateCountdownText(float time)
    {
        int seconds = Mathf.CeilToInt(time); 
        countdownText.text = "Press to F: " + seconds.ToString() + " second"; 
    }
}
