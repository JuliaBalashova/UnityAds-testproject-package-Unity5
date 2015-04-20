using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Scene2 : MonoBehaviour {

	void OnGUI() {

		if(GUI.Button(new Rect(10, 10, 150, 50), "Back"))
		{
			Application.LoadLevel("Scene1");
		}
	}
}
