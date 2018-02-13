using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MoveCameraBackScript : MonoBehaviour {
	
		public float gazeTime = 2f;
		private float timer;
		private bool gazedAt;

		public void PointerEnter(){
			gazedAt = true;
		}

		public void PointerExit(){
			gazedAt = false;
		}

		public void PointerClick(){	
			
		}

		void Start () {

		}

		// Update is called once per frame
		void Update () {
			if (gazedAt) {
				timer += Time.deltaTime;
				
				if (timer >= gazeTime) {
					SceneManager.LoadScene("ProjectSceneRestaurant", LoadSceneMode.Single);
					timer = 0f;
				}
			}
		}
}


