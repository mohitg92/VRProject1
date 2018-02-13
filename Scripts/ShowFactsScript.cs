using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowFactsScript : MonoBehaviour {
	public float gazeTime = 2f;
	private float timer;
	private bool gazedAt;

	private int count = 0;

	// Use this for initialization
	void Start () {
		//		textMesh.text ="Remaining Items: 10";
	}

	// Update is called once per frame
	void Update () {

		if (gazedAt) {

			timer += Time.deltaTime;
			if (timer >= gazeTime) {

				var dt = new DialogueTrigger(); 
				dt.triggerDialogue ();
				timer = 0f;
			}
		}

	}




	public void PointerEnter(){
		gazedAt = true;
	}

	public void PointerExit(){
		gazedAt = false;
	}

	public void PointerClick(){		
	}


}
