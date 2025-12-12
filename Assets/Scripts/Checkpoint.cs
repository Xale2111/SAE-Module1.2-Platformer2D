using System;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    BoxCollider2D collider;
    GameObject spawnPoint;

    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        spawnPoint = GameObject.FindGameObjectWithTag("Respawn");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Checkpoint reached!");
            spawnPoint.transform.position = transform.position;
            Destroy(gameObject);
        }
    }
}
