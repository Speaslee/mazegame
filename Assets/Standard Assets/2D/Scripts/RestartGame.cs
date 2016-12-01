using UnityEngine;
using UnityEngine.UI;
using System.Collections;

	public class RestartGame
	{
		public void Reload ()
		{
		Application.LoadLevel(Application.loadedLevel);
		}
	}


