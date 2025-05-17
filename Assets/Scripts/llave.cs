using UnityEngine;

public class RecogerLlaveYDesbloquear : MonoBehaviour
{
    public GameObject llave;     // Arrastra la llave aquí desde la escena
    public GameObject pared;     // Arrastra la pared que debe desaparecer

    private bool llaveRecogida = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == llave && !llaveRecogida)
        {
            llaveRecogida = true;

            // Destruir la llave
            Destroy(llave);

            // Desactivar la pared
            if (pared != null)
            {
                pared.SetActive(false);
            }

            Debug.Log("¡Llave recogida y pared desbloqueada!");
        }
    }
}
