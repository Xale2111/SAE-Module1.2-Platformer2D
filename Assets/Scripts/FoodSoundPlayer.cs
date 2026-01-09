using System.Collections;
using UnityEngine;

public class FoodSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip crunchSound;
    [SerializeField] private AudioClip burpSound;
    [SerializeField] private AudioClip vomitSound;
    
    
    public void PlaySoundEatingSoundGood()
    {
        audioSource.PlayOneShot(crunchSound);
        StartCoroutine(PlayBurpSound());
    }

    public void PlaySoundEatingSoundBad()
    {
        audioSource.PlayOneShot(vomitSound);
    }

    private IEnumerator PlayBurpSound()
    {
        yield return new WaitForSeconds(0.2f);
        audioSource.PlayOneShot(burpSound);
    }
}

