using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

    float floorSpeed;

	void Start () 
    {
        floorSpeed = 2 * Time.deltaTime;
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
