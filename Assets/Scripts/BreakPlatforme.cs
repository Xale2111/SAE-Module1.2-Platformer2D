using System;
using UnityEngine;

public class BreakPlatforme : MonoBehaviour
{
    Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _animator.SetTrigger("Broke");
        }
    }
}
