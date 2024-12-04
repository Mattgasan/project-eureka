using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab; // Referência ao prefab da bala
    public Transform shootingPoint; // Ponto de onde as balas sairão
    public float fireRate = 0.5f;  // Taxa de disparo
    private float timeSinceLastShot = 0f; // Controle de tempo para disparo

    public int bulletsShot = 0; // Contador de tiros disparados
    public int playerLevel = 1; // Nível do jogador

    public GameObject levelUpScreen; // Tela de Level Up (a aparecer quando atingir o número de tiros)

    void Update()
    {
        // Verifica se o jogador pode atirar (clicando no botão de disparo)
        if (Input.GetButton("Fire1") && Time.time >= timeSinceLastShot + fireRate)
        {
            Shoot();
            timeSinceLastShot = Time.time;  // Resetando o tempo entre os tiros
        }

        // Verifica se o jogador atingiu 15 tiros e faz o "level up"
        if (bulletsShot >= 15)
        {
            LevelUp();
        }
    }

    void Shoot()
    {
        // Instancia a bala no ponto de tiro
        Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
        bulletsShot++;
    }

    void LevelUp()
    {
        if (playerLevel < 2)
        {
            playerLevel++; // Aumenta o nível
            ShowLevelUpScreen(); // Mostra a tela de nível
            bulletsShot = 0; // Reseta o contador de tiros
        }
    }

    void ShowLevelUpScreen()
    {
        levelUpScreen.SetActive(true); // Ativa a tela de escolha de card
    }
}
