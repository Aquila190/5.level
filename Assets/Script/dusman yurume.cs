using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player;  // Oyuncunun Transform'u
    public float moveSpeed = 3f;  // Düşmanın hareket hızı
    public float attackRange = 1.5f;  // Saldırı mesafesi

    private Rigidbody2D rb;
    private Animator animator;  // Animator bileşeni
    private bool isAttacking = false;  // Saldırı durumu
    private bool isWalking = false;    // Yürüyüş durumu

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Rigidbody2D bileşenini Start()'ta alıyoruz
        animator = GetComponent<Animator>();  // Animator bileşenini Start()'ta alıyoruz
    }

    private void Update()
    {
        // Oyuncu ile olan mesafeyi kontrol et
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        // Eğer oyuncu belli bir mesafeye girerse, saldırmaya başla
        if (distanceToPlayer <= attackRange)
        {
            Attack();
        }
        else
        {
            MoveTowardsPlayer(distanceToPlayer);
        }

        // Animasyonları güncelle
        UpdateAnimations();
    }

    // Oyuncuya doğru hareket et
    private void MoveTowardsPlayer(float distanceToPlayer)
    {
        // Eğer oyuncu mesafeye yakınsa, düşman onu kovalasın
        if (distanceToPlayer > attackRange)
        {
            isWalking = true;  // Yürüyüş animasyonu için isWalking true

            Vector2 direction = (player.position - transform.position).normalized;  // Oyuncuya doğru yön
            rb.linearVelocity = direction * moveSpeed;  // Düşmanı oyuncuya doğru hareket ettir
        }
        else
        {
            isWalking = false;  // Yürüyüş durumu false, saldırıya geçildi
            rb.linearVelocity = Vector2.zero;  // Düşmanın hareketini durdur
        }
    }

    // Saldırı animasyonunu başlat
    private void Attack()
    {
        isAttacking = true;
        rb.linearVelocity = Vector2.zero;  // Saldırırken hareket etmeyi durdur

        // Burada oyuncuya hasar vermek için kendi sağlık sisteminizi çağırabilirsiniz.
        Health playerHealth = player.GetComponent<Health>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(10);  // 10 örnek hasar
        }
    }

    // Animasyonları güncelle
    private void UpdateAnimations()
    {
        // Saldırı animasyonunu kontrol et
        animator.SetBool("isAttacking", isAttacking);

        // Yürüyüş animasyonunu kontrol et
        animator.SetBool("isWalking", isWalking);

        // Eğer saldırı yapmıyorsa, idle animasyonuna geç
        if (!isAttacking && !isWalking)
        {
            animator.SetBool("isIdle", true);  // Idle animasyonunu başlat
        }
        else
        {
            animator.SetBool("isIdle", false);  // Idle animasyonu durdur
        }
    }
}
