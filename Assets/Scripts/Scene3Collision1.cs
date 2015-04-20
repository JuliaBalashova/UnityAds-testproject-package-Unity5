using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Scene3Collision1 : MonoBehaviour {
	public int nom = 0;


	void Update () {
				transform.Translate (transform.right * 1 * Time.deltaTime);	
	}

	void OnCollisionEnter2D(Collision2D ob)
	{
		if(ob.gameObject.name == "star2")
		{
			Destroy(ob.gameObject);

			if(Advertisement.isReady() == true) {
				Advertisement.Show(null, new ShowOptions {
					pause = false});// FALSE
			} else Debug.Log("Advertisement.isReady returns false"); 
		}
	}
}
