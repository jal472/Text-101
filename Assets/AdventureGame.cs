using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    string myState = "start";

	// Use this for initialization
	void Start () {
        textComponent.text = "Welcome to the Avengers VS. Thanos game! \n\nPress Return/Enter to begin playing...";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) {
            textComponent.text = "Thanos is trying to steal all of the infinity stones. It is up to you, The Avengers, to stop him and save the Universe." +
                " He has all but the final stone, the Mind Stone, held by Vision.\n\n" +
                "What should we do?\n" +
                "1 : Kill Vision, a fellow ally, and destroy the stone.\n" +
                "2: Fight Thanos and take him down risking that he may retrieve the stone from Vision.";
        }
		
	}
}
