using System;
using UnityEngine;
using UnityEngine.Events;

public class DiceCheckZone : MonoBehaviour
{
    public event UnityAction<int> CheckedDice;
    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out Side sideNumber))
        {
            CheckedDice?.Invoke(sideNumber.Number);
        }
    }
}