using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(0f, 0f, _speed * Time.deltaTime);
    }
}
