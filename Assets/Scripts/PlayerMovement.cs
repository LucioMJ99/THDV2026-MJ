using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Velocidad de movimiento
    public float speed = 5.0f;

    void Update()
    {
        // Obtengo los inputs de PC (Teclas WASD o Flechas)
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D o Flechas Izq/Der
        float verticalInput = Input.GetAxis("Vertical");     // W/S o Flechas Arriba/Abajo

        // Creo un vector de movimiento solo en X y Z (Y se mantiene en 0)
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Aplico el movimiento usando transform.Translate
        // Time.deltaTime me asegura que el movimiento sea suave independientemente de los FPS
        transform.Translate(movement * speed * Time.deltaTime);

        // Verifico si el jugador intenta moverse
        if (movement != Vector3.zero)
        {
            
        }
    }
}
