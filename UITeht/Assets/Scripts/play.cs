using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {

	// Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayButton()
    {
        Application.LoadLevel("Level01");

    }

    public void Credits()
    {
        Application.LoadLevel("credits");
    }

    public void ExitGame()
    {
        Debug.Log("Lopetit juuri pelin");
    }
}

