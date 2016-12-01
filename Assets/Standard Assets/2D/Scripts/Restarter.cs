using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
		public Transform SpawnPoint;
		public int scoreValue = 1;
		private Rigidbody2D m_Rigidbody2D;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
				
				other.transform.position = SpawnPoint.transform.position;
				bool IsUpsidedown = other.transform.localScale.y < 0;	
					if (IsUpsidedown){
					Vector3 theScale = other.transform.localScale;
					theScale.y *= -1;
					other.transform.localScale = theScale;
					}
				m_Rigidbody2D = other.GetComponent<Rigidbody2D>();
				m_Rigidbody2D.gravityScale = 3;
				ScoreManager.score += scoreValue;
			
            }
        }
    }
}

