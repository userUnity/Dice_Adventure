using System;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private int _turns;
    [SerializeField] private int _money;
    [SerializeField] private List<Dice> _dices;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (var dice in _dices)
            {
                dice.CalculateRoll();
                _turns--;
            }
        }
    }
}