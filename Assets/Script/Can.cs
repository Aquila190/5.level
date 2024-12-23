using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; 
    public int currentHealth; 
    public HealthManager healthManager; 

    void Start()
    {
        currentHealth = maxHealth; 
        if (healthManager != null)
        {
            healthManager.UpdateHealthUI(currentHealth); 
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        if (healthManager != null)
        {
            healthManager.UpdateHealthUI(currentHealth);
        }

        Debug.Log($"Can Azaldý! Mevcut Can: {currentHealth}");
    }

    public void Heal(int amount)
    {
       
        if (currentHealth < 70)
        {
            currentHealth += amount;
        }
        else
        {
            
            currentHealth = Mathf.Min(currentHealth + amount, 100);
        }

        if (healthManager != null)
        {
            healthManager.UpdateHealthUI(currentHealth); 
        }

        Debug.Log($"Can Arttý! Mevcut Can: {currentHealth}");
    }
}
