using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject bombEnemyPrefab; // O prefab do inimigo
    public Transform player;          // Refer�ncia ao jogador
    public float spawnRadius = 10f;   // Raio m�ximo para spawnar inimigos
    public float minDistance = 5f;    // Dist�ncia m�nima do jogador
    public float spawnInterval = 2f;  // Tempo entre cada spawn

    private float spawnTimer;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0f; // Reinicia o cron�metro
        }
    }

    void SpawnEnemy()
    {
        // Gera uma posi��o aleat�ria em um c�rculo
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        Vector2 spawnPosition = (Vector2)player.position + randomDirection * Random.Range(minDistance, spawnRadius);

        // Instancia o inimigo na posi��o calculada
        Instantiate(bombEnemyPrefab, spawnPosition, Quaternion.identity);
    }
}
