using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PickUpFood : MonoBehaviour
{
    [SerializeField] int kgValue;
    [SerializeField] UnityEvent OnPickUpGood;
    [SerializeField] UnityEvent OnPickUpBad;

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.TryGetComponent<PlayerController>(out PlayerController player))
            {
                player.AddScore(kgValue);
                PlaySound();
            }
            Destroy(gameObject);
        }
    }

    void PlaySound()
    {
        if (kgValue > 0)
        {
            OnPickUpGood.Invoke();
        }
        else
        {
            OnPickUpBad.Invoke();
        }
    }
}
