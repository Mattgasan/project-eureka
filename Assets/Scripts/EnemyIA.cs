using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    public Transform player; 
    public float speed = 5f; 
    public float attackRange = 2f;
    public float attackCooldown = 1f; 

    private float lastAttackTime;

    void Update()
    {
        if (player == null) return;

        // Calcula a distância entre o inimigo e o jogador
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer > attackRange)
        {
            // Perseguir o jogador
            FollowPlayer();
        }
        else
        {
            // Atacar o jogador
            AttackPlayer();
        }
    }

    void FollowPlayer()
    {
        // Calcula a direção em direção ao jogador
        Vector3 direction = (player.position - transform.position).normalized;

        // Move o inimigo em direção ao jogador
        transform.position += direction * speed * Time.deltaTime;

        // Faz o inimigo olhar para o jogador
        transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
    }

    void AttackPlayer()
    {
        if (Time.time - lastAttackTime >= attackCooldown)
        {
            Debug.Log("Inimigo ataca!");
            lastAttackTime = Time.time;

            // Aqui você pode adicionar lógica para causar dano ao jogador
        }
    }
}

/* umas anotaçoes que podem ajudar depois, Crie um Objeto para o Inimigo:

Adicione um objeto 3D (por exemplo, um "Capsule") como inimigo.
Anexe o script EnemyAI.cs ao inimigo.
Defina o Jogador:

Arraste o objeto do jogador para o campo Player no script (no inspetor).
Ajuste os Parâmetros:

Configure a velocidade (speed), o alcance de ataque (attackRange) e o tempo de espera entre ataques (attackCooldown).
Adicione um Collider: 

Certifique-se de que o inimigo e o jogador tenham coliders e rigidbodies, caso queira usar física para movimentação ou colisão.*/