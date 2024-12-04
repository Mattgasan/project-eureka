using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // Velocidade da bala

    private void Start()
    {
        Destroy(gameObject, 5f); // Destr�i a bala depois de 5 segundos
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); // Move a bala para cima
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject); // Destr�i o inimigo "bomb" ao colidir
            Destroy(gameObject); // Destr�i a bala ap�s o impacto
        }
    }
}

