//using UnityEngine;

//public class EnemyAI : MonoBehaviour
//{

//[SerializeField] private float speed = 1.5f;

//private GameObject player;
// Start is called once before the first execution of Update after the MonoBehaviour is created
//void Start()
//{
//    player = GameObject.FindGameObjectWithTag("Player");
//}

// Update is called once per frame
//void //Update()
//{
//    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
//}
//}

using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float chaseRange = 10f;
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] private Transform player; // Asignar en inspector preferible

    private Transform _transform;
    private Rigidbody _rigidbody;
    private Vector3 _desiredVelocity = Vector3.zero;

    private enum State { Idle, Chasing }
    private State _state = State.Idle;

    void Start()
    {
        _transform = transform;
        _rigidbody = GetComponent<Rigidbody>();

        if (player == null)
        {
            var found = GameObject.FindGameObjectWithTag("Player");
            if (found != null) player = found.transform;
            else Debug.LogWarning($"EnemyAI '{name}': no se encontró objeto con tag 'Player'. Asigna el Transform en el inspector.");
        }
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(_transform.position, player.position);
        _state = (distance <= chaseRange) ? State.Chasing : State.Idle;

        if (_state == State.Chasing)
        {
            Vector3 dir = player.position - _transform.position;
            dir.y = 0f;
            if (dir.sqrMagnitude > 0.001f)
            {
                // Rotación suave hacia el jugador
                Quaternion targetRot = Quaternion.LookRotation(dir);
                _transform.rotation = Quaternion.Slerp(_transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
                // Actualizo la velocidad deseada (se aplicará en FixedUpdate)
                _desiredVelocity = dir.normalized * speed;
            }
        }
        else
        {
            _desiredVelocity = Vector3.zero;
        }
    }

    void FixedUpdate()
    {
        // Aplico movimiento usando Rigidbody si existe, si no uso transform
        Vector3 delta = _desiredVelocity * Time.fixedDeltaTime;
        if (_rigidbody != null)
        {
            _rigidbody.MovePosition(_rigidbody.position + delta);
        }
        else
        {
            _transform.position += delta;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
