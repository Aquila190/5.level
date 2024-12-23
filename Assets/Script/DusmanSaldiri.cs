using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 10;
    public float attackCooldown = 1.0f;
    private float lastAttackTime = 0f;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Oyuncu"))
        {
            if (Time.time - lastAttackTime > attackCooldown)
            {
                Health playerHealth = collision.gameObject.GetComponent<Health>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(damage);
                }
                lastAttackTime = Time.time;
            }
        }
    }
}
