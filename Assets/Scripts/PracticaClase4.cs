using UnityEngine;

public class Ejercicio_Timer : MonoBehaviour
{
    // Variables que usan los timers.
    int segundos = 0;
    float tiempo = 0;
    int duracion = 10;
    bool terminado = false;

    // Variables que usa la cuenta regresiva.
    int segundosRestantes = 10;
    bool cuentaRegresivaMostrada = false;

    // Variables que usan los ejercicios de numeros pares.
    int[] segundosPares = new int[5];
    int posicionArray = 0;

    // IMPORTANTE:
    // Solo puede existir un metodo Update activo.
    // Para probar otro ejercicio, se comenta el Update activo y se
    // descomenta el Update del ejercicio que se quiere ejecutar.

    // ------------------------------------------------------------
    // EJERCICIO N1: Contador de segundos
    // ------------------------------------------------------------

    /*
    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 1)
        {
            segundos++;
            Debug.Log("Segundo: " + segundos);
            tiempo = 0;
        }
    }
    */

    // ------------------------------------------------------------
    // EJERCICIO N2: Timer con duracion
    // ------------------------------------------------------------

    /*
    void Update()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer terminado");
                }
            }
        }
    }
    */

    // ------------------------------------------------------------
    // EJERCICIOS N3 AL N8
    // ------------------------------------------------------------

    void Update()
    {
        // Dejar solamente una llamada sin comentar.

        // Ejercicio N3:
        // LogicaTimer();

        // Ejercicio N4:
        // LogicaCuentaRegresiva();

        // Ejercicio N5:
        // LogicaTimerPar();

        // Ejercicio N6:
        // LogicaGuardarPares();

        // Ejercicio N7:
        // LogicaGuardarParesConMetodo();

        // Ejercicio N8 (activo):
        LogicaBuscarParesMayoresA5();
    }

    // ------------------------------------------------------------
    // EJERCICIO N3: Pasar el timer a un metodo
    // ------------------------------------------------------------

    void LogicaTimer()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer terminado");
                }
            }
        }
    }

    // ------------------------------------------------------------
    // EJERCICIO N4: Cuenta regresiva
    // ------------------------------------------------------------

    void LogicaCuentaRegresiva()
    {
        if (!terminado)
        {
            // Se muestra el 10 antes de empezar a restar.
            if (!cuentaRegresivaMostrada)
            {
                Debug.Log("Tiempo restante: " + segundosRestantes);
                cuentaRegresivaMostrada = true;
            }

            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundosRestantes--;
                Debug.Log("Tiempo restante: " + segundosRestantes);
                tiempo = 0;

                if (segundosRestantes <= 0)
                {
                    terminado = true;
                    Debug.Log("Cuenta regresiva terminada");
                }
            }
        }
    }

    // ------------------------------------------------------------
    // EJERCICIO N5: Detectar segundos pares
    // ------------------------------------------------------------

    void LogicaTimerPar()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                // El resto de una division por 2 es 0 cuando el numero es par.
                if (segundos % 2 == 0)
                {
                    Debug.Log("El segundo " + segundos + " es par");
                }

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer terminado");
                }
            }
        }
    }

    // ------------------------------------------------------------
    // EJERCICIO N6: Guardar los segundos pares y mostrarlos al final
    // ------------------------------------------------------------

    void LogicaGuardarPares()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                if (segundos % 2 == 0)
                {
                    segundosPares[posicionArray] = segundos;
                    posicionArray++;
                }

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer terminado. Segundos pares guardados:");

                    for (int i = 0; i < segundosPares.Length; i++)
                    {
                        Debug.Log(segundosPares[i]);
                    }
                }
            }
        }
    }

    // ------------------------------------------------------------
    // EJERCICIO N7: Pasar el guardado de pares a un metodo
    // ------------------------------------------------------------

    void LogicaGuardarParesConMetodo()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                if (segundos % 2 == 0)
                {
                    GuardarNumeroPar();
                }

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer terminado. Segundos pares guardados:");
                    MostrarParesConFor();
                }
            }
        }
    }

    void GuardarNumeroPar()
    {
        segundosPares[posicionArray] = segundos;
        posicionArray++;
    }

    void MostrarParesConFor()
    {
        for (int i = 0; i < segundosPares.Length; i++)
        {
            Debug.Log(segundosPares[i]);
        }
    }

    // ------------------------------------------------------------
    // EJERCICIO N8: Buscar con while los pares mayores a 5
    // ------------------------------------------------------------

    void LogicaBuscarParesMayoresA5()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                if (segundos % 2 == 0)
                {
                    GuardarNumeroPar();
                }

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer terminado. Pares mayores a 5:");
                    MostrarParesMayoresA5ConWhile();
                }
            }
        }
    }

    void MostrarParesMayoresA5ConWhile()
    {
        int i = 0;

        while (i < segundosPares.Length)
        {
            if (segundosPares[i] > 5)
            {
                Debug.Log(segundosPares[i]);
            }

            i++;
        }
    }
}