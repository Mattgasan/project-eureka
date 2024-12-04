using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab; // Refer�ncia ao prefab da bala
    public Transform shootingPoint; // Ponto de onde as balas sair�o
    public float fireRate = 0.5f;  // Taxa de disparo
    private float timeSinceLastShot = 0f; // Controle de tempo para disparo

    public int bulletsShot = 0; // Contador de tiros disparados
    public int playerLevel = 1; // N�vel do jogador

    public GameObject levelUpScreen; // Tela de Level Up (a aparecer quando atingir o n�mero de tiros)

    void Update()
    {
        // Verifica se o jogador pode atirar (clicando no bot�o de disparo)
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
            playerLevel++; // Aumenta o n�vel
            ShowLevelUpScreen(); // Mostra a tela de n�vel
            bulletsShot = 0; // Reseta o contador de tiros
        }
    }

    void ShowLevelUpScreen()
    {
        levelUpScreen.SetActive(true); // Ativa a tela de escolha de card
    }
}
