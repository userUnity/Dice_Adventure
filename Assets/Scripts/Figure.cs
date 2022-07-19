using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForse;
    [SerializeField] private List<Cube> _cubes;

    private Transform _curentPoint;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _curentPoint = _cubes[0].transform;
    }

    private void Update()
    {
       
    }
}