using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0f, _speed, 0f);
    }
}
