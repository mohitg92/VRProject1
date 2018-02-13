using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextDisappearScript : MonoBehaviour {

	public float gazeTime = 2f;
	private float timer;
	private bool gazedAt;

	private int count;

	public GameObject obj;

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (gazedAt) {
			timer += Time.deltaTime;
			if (timer >= gazeTime) {
				trashItem ();
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
		count = count + 1;
	}

	void trashItem(){
		obj.SetActive (false);
	}		
}
