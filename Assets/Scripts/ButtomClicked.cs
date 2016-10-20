using UnityEngine;
using System.Collections;

public class ButtomClicked : MonoBehaviour {


    public void Buttomclicked(string ButtomAction)
    {
        if (ButtomAction == "Play")
        {
            Application.LoadLevel("Game");
        }
    }

	void Update () {
	
	}
}
