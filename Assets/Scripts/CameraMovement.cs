using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Referencia al Transform del jugador (la esfera)
    public Transform playerTransform;

    // Distancia fija entre la cámara y el jugador
    public Vector3 offset = new Vector3(0, 10, -8);

    void LateUpdate()
    {
        // Estructura condicional para evitar errores si no se asigno el Player en el Inspector
        if (playerTransform != null)
        {
            // La posición de la cámara será la posición del jugador más la distancia (offset)
            transform.position = playerTransform.position + offset;
        }
    }
}
