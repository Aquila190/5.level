using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f;   
    public float currentHealth;      

    void Start()
    {
        currentHealth = maxHealth;  
    }

    
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;  

        
        if (currentHealth <= 0)
        {
            HandleDeath();
        }
    }

    
    void HandleDeath()
    {
        
        Debug.Log(gameObject.name + " öldü!");
        Destroy(gameObject);  
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "alevtopu")
        {
            TakeDamage(20);
        }
    }
}
