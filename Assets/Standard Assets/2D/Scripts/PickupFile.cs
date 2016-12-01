using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D{
public class PickupFile : MonoBehaviour {
	public GameOverManager sn;
	Animator anim;
	private void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.tag == "Pick Up")
		{
			other.gameObject.SetActive (false);
			
		}
	}
	}
}