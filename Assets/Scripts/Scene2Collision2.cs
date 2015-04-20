using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Scene2Collision2 : MonoBehaviour {
	
	void Update () {
		transform.Translate (transform.right * 2 * Time.deltaTime);
	}
	
	void OnCollisionEnter2D(Collision2D ob)
	{
		
		
		if(ob.gameObject.name == "star4")
		{
			Destroy(ob.gameObject);
			
			if(Advertisement.isReady() == true) {
				Advertisement.Show(null, new ShowOptions {
					pause = true,
					resultCallback = result => {
						Debug.Log(result.ToString());
					}
				});
			} else Debug.Log("Advertisement.isReady returns false"); 
		}
	}
}