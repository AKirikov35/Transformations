using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    void Update()
    {
        transform.Rotate(0f, _rotationSpeed, 0f);
    }
}