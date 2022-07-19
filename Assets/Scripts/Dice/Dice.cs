using System;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;


[RequireComponent(typeof(Rigidbody))]
public class Dice : MonoBehaviour
{
    [SerializeField] private float _powerThrow = 500;

    private Rigidbody _rigidbody;
    private Vector3 _startPoint;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _startPoint = transform.position;
    }
    
    public void CalculateRoll()
    {
        transform.position = _startPoint;
        transform.rotation = Quaternion.identity;

        _rigidbody.AddForce(Vector3.up * _powerThrow);
        _rigidbody.AddTorque(CreateRandomDirection());
    }

    private Vector3 CreateRandomDirection()
    {
        float maxValue = 1000;

        float directionX = Random.Range(0, maxValue);
        float directionY = Random.Range(0, maxValue);
        float directionZ = Random.Range(0, maxValue);

        return new Vector3(directionX, directionY, directionZ);
    }
}