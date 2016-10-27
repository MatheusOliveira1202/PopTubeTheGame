using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    GameObject Floor, FloorCreater, Character, Platform, PlatformCreator;
    private float timer, timeFloorCounter, timePlatformCounter;

	void Start () 
    {
        timeFloorCounter = 5/* * Time.deltaTime*/;
        timePlatformCounter = 10;
        Floor = Resources.Load("Floor") as GameObject;
        Platform = Resources.Load("Platform") as GameObject;
        Character = Resources.Load("Character") as GameObject;
        FloorCreater = GameObject.FindGameObjectWithTag("FloorCreater");
        PlatformCreator = GameObject.FindGameObjectWithTag("PlatformCreator");
        FloorInstantiater();
        Instantiate(Character, new Vector3(0, 200, 10), transform.rotation);
	}

    void FloorInstantiater()
    {
        Instantiate(Floor, new Vector3(FloorCreater.transform.position.x, FloorCreater.transform.position.y, 10), transform.rotation);
    }

    void PlatformInstantiater()
    {
        Instantiate(Platform, new Vector3(PlatformCreator.transform.position.x, PlatformCreator.transform.position.y, 10), transform.rotation);
    }

    void TimeControl()
    {
        if (Time.fixedTime - timer > timeFloorCounter)
        {
            timer = Time.fixedTime;
            FloorInstantiater();
            PlatformInstantiater();
        }
    }

	void Update () 
    {
        TimeControl();
	}
}
