using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

    float floorSpeed;

	void Start () 
    {
        floorSpeed = 0.1f;
	}

    void Movement()
    {
        transform.position -= new Vector3(floorSpeed,0,0);
        if(transform.position.x <= -15)
        {
            DestroyFloor();
        }
    }

    void DestroyFloor()
    {
        Destroy(gameObject);
    }
	
	void Update () 
    {
        Movement();
	}
}
