using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemy : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float explodeDistance = 1.5f; // Dist�ncia m�nima para o inimigo explodir
    public GameObject explosionEffect;  // Prefab de efeito de explos�o (opcional)

    private float distance;

    void Update()
    {
        // Calcula a dist�ncia at� o jogador
        distance = Vector2.Distance(transform.position, player.transform.position);

        // Se estiver dentro da dist�ncia de explos�o, explodir
        if (distance <= explodeDistance)
        {
            Explode();
            return;
        }

        // Movimento em dire��o ao jogador
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }

    void Explode()
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(explosionEffect, 1f);
        }

        // Causa dano ao jogador
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(20); // Substitua 20 pelo valor de dano que deseja
        }

        Destroy(gameObject);
    }


}
