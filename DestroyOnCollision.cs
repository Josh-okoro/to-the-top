using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    // Name Tag, check Inspector
    [SerializeField]
    string stringTag;

    // Boolean, check Inspector
    [SerializeField]
    bool detroySelf = false;

    [SerializeField]
    bool destroyOther = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == stringTag)
        {
            if(detroySelf)
            {
                Destroy(this.gameObject);
            }

            if (destroyOther)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
