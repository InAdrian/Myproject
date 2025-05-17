using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position + transform.forward, Quaternion.identity);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.linearVelocity = transform.forward * projectileSpeed;
        }
    }
}
