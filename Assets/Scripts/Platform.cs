using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

    float platformSpeed;

    void Start()
    {
        platformSpeed = 2 * Time.deltaTime;
    }

    void Movement()
    {
        transform.position -= new Vector3(platformSpeed, 0, 0);
        if (transform.position.x <= -15)
        {
            DestroyFloor();
        }
    }

    void DestroyFloor()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        Movement();
    }
}
    