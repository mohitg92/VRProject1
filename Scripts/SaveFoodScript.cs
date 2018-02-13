using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SaveFoodScript : MonoBehaviour {

	public float gazeTime = 2f;
	private float timer;
	private bool gazedAt;
	private int count;
	public TextMesh textMesh = new TextMesh ();
	public AudioSource audioSource;
	public AudioClip ac1;
	public AudioClip ac2;
	public Rigidbody rigidb;
	public GameObject obj;
	public Vector3 finalPos;

	// Use this for initialization
	void Start () {
//		rigidb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		if (gazedAt) {
			timer += Time.deltaTime;
			if (timer >= gazeTime) {
				saveItem ();
				var dt = new DialogueTrigger (); 
				dt.triggerDialogue ();
				timer = 0f;
			}
		} 
		else {
				
		}
	}

	void onCollisionEnter(Collision col){
		switch (col.gameObject.tag) {
		case "Truck":
			playTrashSound ();
			obj.SetActive (false);
			break;
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

	void saveItem(){
		//		
		Vector3 firstPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);


		if(transform.position.x != -45.13f) {
			transform.position = finalPos;
		}
		playSaveSound ();

	}

	void playSaveSound()
	{
		audioSource.clip = ac1;
		Debug.Log ("playing");
		audioSource.Play ();
	}

	void playTrashSound()
	{
		audioSource.clip = ac2;
		Debug.Log ("playing");
		audioSource.Play ();
	}
}
