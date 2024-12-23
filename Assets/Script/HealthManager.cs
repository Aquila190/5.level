using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public Slider healthSlider; // Slider bile�eni
    public TextMeshProUGUI healthText; // TextMeshPro bile�eni
    public int currentHealth; // Mevcut can

    public void UpdateHealthUI(int newHealth)
    {
        currentHealth = newHealth;
        healthSlider.value = currentHealth;
        healthText.text = $"Health: {currentHealth}";
        Debug.Log($"UI g�ncellendi. Mevcut can: {currentHealth}");
    }
}
