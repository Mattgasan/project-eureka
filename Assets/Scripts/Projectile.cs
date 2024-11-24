using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 25f;

    void Update()
    {
        transform.Translate(Time.deltaTime * speed * Vector3.up);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
