using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MoveCameraScript : MonoBehaviour {

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
		SceneManager.LoadScene("SecondScene", LoadSceneMode.Single);
	}
		
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (gazedAt) {
			timer += Time.deltaTime;

			if (timer >= gazeTime) {
				ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerClickHandler);
				timer = 0f;
			}
		}
	}
}
 