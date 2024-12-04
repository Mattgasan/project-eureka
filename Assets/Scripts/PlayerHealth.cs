using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Vida máxima do jogador
    public int currentHealth;  // Vida atual do jogador

    void Start()
    {
        // Define a vida atual como a vida máxima no início
        currentHealth = maxHealth;
    }

    // Método para receber dano
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Reduz a vida do jogador
        Debug.Log("Vida atual: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Método para curar o jogador
    public void Heal(int amount)
    {
        currentHealth += amount; // Aumenta a vida do jogador
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth; // Garante que a vida não exceda o máximo
        }

        Debug.Log("Vida atual: " + currentHealth);
    }

    // Método chamado quando a vida chega a zero
    void Die()
    {
        Debug.Log("O jogador morreu!");

        // Salva o índice da cena atual para reiniciar (opcional)
        PlayerPrefs.SetInt("CurrentLevel", SceneManager.GetActiveScene().buildIndex);

        // Carrega a cena de Game Over
        SceneManager.LoadScene("GameOver");
    }


}
