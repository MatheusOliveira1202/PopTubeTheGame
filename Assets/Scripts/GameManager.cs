using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    GameObject Floor, FloorCreater;

	void Start () 
    {
        Floor = Resources.Load("Floor") as GameObject;
        FloorCreater = GameObject.FindGameObjectWithTag("FloorCreater");
        FloorInstantiater();
	}

    void FloorInstantiater()
    {
        Instantiate(Floor, new Vector3(FloorCreater.transform.position.x, FloorCreater.transform.position.y, 10), transform.rotation);
    }

	void Update () 
    {
     
	}
}
