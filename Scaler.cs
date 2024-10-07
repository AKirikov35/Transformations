using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSize;
    [SerializeField] private float _scaleSpeed;

    private float _defaultScaleSize = 1;

    void Update()
    {
        Scaled();
    }

    private void Scaled()
    {
        float newScale = Mathf.Lerp(_defaultScaleSize, _scaleSize, Mathf.PingPong(Time.time * _scaleSpeed, 1));
        transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}