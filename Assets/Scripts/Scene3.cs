using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Scene3 : MonoBehaviour {

	void OnGUI() {

		if(GUI.Button(new Rect(10, 10, 150, 50), "Back"))
		{
			Application.LoadLevel("Scene1");
		}
	}
}
