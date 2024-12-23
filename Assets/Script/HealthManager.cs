using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public Slider healthSlider; // Slider bileþeni
    public TextMeshProUGUI healthText; // TextMeshPro bileþeni
    public int currentHealth; // Mevcut can

    public void UpdateHealthUI(int newHealth)
    {
        currentHealth = newHealth;
        healthSlider.value = currentHealth;
        healthText.text = $"Health: {currentHealth}";
        Debug.Log($"UI güncellendi. Mevcut can: {currentHealth}");
    }
}
