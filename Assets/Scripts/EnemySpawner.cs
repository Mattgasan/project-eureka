using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject bombEnemyPrefab; // O prefab do inimigo
    public Transform player;          // Referência ao jogador
    public float spawnRadius = 10f;   // Raio máximo para spawnar inimigos
    public float minDistance = 5f;    // Distância mínima do jogador
    public float spawnInterval = 2f;  // Tempo entre cada spawn

    private float spawnTimer;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0f; // Reinicia o cronômetro
        }
    }

    void SpawnEnemy()
    {
        // Gera uma posição aleatória em um círculo
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        Vector2 spawnPosition = (Vector2)player.position + randomDirection * Random.Range(minDistance, spawnRadius);

        // Instancia o inimigo na posição calculada
        Instantiate(bombEnemyPrefab, spawnPosition, Quaternion.identity);
    }
}
