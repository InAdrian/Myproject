// Script llamado ZonaMuerte.cs
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Aseg�rate que la bola tenga la tag "Player"
        {
            other.transform.position = new Vector3(-4, 1, 0); // Posici�n de reinicio
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}
