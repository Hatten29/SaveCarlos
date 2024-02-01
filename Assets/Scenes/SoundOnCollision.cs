using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip collisionSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.clip = collisionSound;
            Debug.Log("Sound Playing");
        }
        else
        {
            Debug.LogError("Souund not playing");
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (audioSource != null && collisionSound != null)
        {
            audioSource.Play();
        }

    }
}
