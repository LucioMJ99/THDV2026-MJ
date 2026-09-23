using UnityEngine;

public class EmptyScript : MonoBehaviour
{
    float Tiempo = 0;
    private int segundos = 0;
    private bool terminado = false;
    int duracion = 10;
    private int segundosRestantes = 10;

    void Update()
    {
        //MyMethod();
        CuentaRegresiva();
    }

    void MyMethod()
    {
        if (!terminado)
        {
            Tiempo += Time.deltaTime;

            if (Tiempo >= 1)
            {
                segundos++;
                Debug.Log("Segundo: " + segundos);
                Tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer Terminado");
                }
            }
        }
    }

    void CuentaRegresiva()
    {
        if (!terminado)
        {
            Tiempo += Time.deltaTime;
            if (Tiempo >= 1)
            {
                segundosRestantes--;
                Debug.Log("Tiempo Restante: " + segundosRestantes);
                Tiempo = 0;

                if (segundosRestantes <= segundos)
                {
                    terminado = true;
                    Debug.Log("Tiempo terminado");
                }
            }
        }
    }
}
