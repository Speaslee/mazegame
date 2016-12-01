using UnityEngine;
using UnityEngine.UI;
using System.Collections;
	
	public class GameOverManager: MonoBehaviour
	{

		Animator anim;
	public static bool score;
	GameObject taxfile;
	float restartTimer; 
	public float restartDelay = 5f;  
		
	void Awake(){
		anim = GetComponent <Animator> ();
		score = false;
		taxfile = GameObject.FindGameObjectWithTag ("Pick Up");
	}
		
	void Update(){
		if (taxfile.active) { 
						
			anim.SetBool ("Win", false);

		} else {
			anim.SetBool ("Win", true);
			// .. increment a timer to count up to restarting.
			restartTimer += Time.deltaTime;

			// .. if it reaches the restart delay...
			if(restartTimer >= restartDelay)
			{
				// .. then reload the currently loaded level.
				Application.LoadLevel(Application.loadedLevel);
			}
		
		}
	}
}

