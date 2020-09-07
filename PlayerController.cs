using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject focalPoint;
    public AudioClip hitSound;

    private AudioSource playerAudio;
    private float speed = 15.0f;
	private Rigidbody playerRb;
 //  private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
      //focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    // Player Control
    void FixedUpdate()
    {
        float sideInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
        playerRb.AddForce(focalPoint.transform.right * sideInput * speed);
    }


    // SFX Implementation
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            playerAudio.PlayOneShot(hitSound, 1.0f);
        }
         
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerAudio.PlayOneShot(hitSound, 1.0f);
        }
    }
}
