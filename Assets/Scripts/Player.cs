using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	
	void Start () {
	
	}

    /*void OnMouseDrag()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 70);
    }*/

    void Movimentation()
    {
        if(Input.GetKey("space"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 70);
        }
    }

	void Update () 
    {
        Movimentation();
	}
}
