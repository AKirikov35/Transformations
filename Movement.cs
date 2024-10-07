using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(0f, 0f, _movementSpeed * Time.deltaTime);
    }
}