using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLevelRestart : MonoBehaviour
{
    public AudioClip deathSound;

    private AudioSource deathAudio;

    // Name Tag, check Inspector
    [SerializeField]
    string stringTag;

    void Start()
    {
        deathAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // level restart based on collision
        if (collision.collider.tag == stringTag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            deathAudio.PlayOneShot(deathSound, 1.0f);
        }
    }
}

