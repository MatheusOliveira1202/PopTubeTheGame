using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    GameObject Floor;

	void Start () 
    {
        Floor = Resources.Load("Floor") as GameObject;
        FloorInstantiater();
	}

    void FloorInstantiater()
    {
        Instantiate(Floor, new Vector3(0,-5,10), transform.rotation);
    }

	void Update () 
    {
     
	}
}
