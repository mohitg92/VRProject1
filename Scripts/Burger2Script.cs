using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Burger2Script : MonoBehaviour {

	public float gazeTime = 2f;
	private float timer;
	private bool gazedAt;

	private int count;
	//public Camera mainCamera;
	public TextMesh textMesh = new TextMesh ();
	public AudioSource audioSource;
	public GameObject obj;
	public AudioClip ac;

	
	// Use this for initialization
	void Start () {
//		textMesh.text ="Remaining Items: 10";
	}
	
	// Update is called once per frame
	void Update () {
		
		if (gazedAt) {
			

			timer += Time.deltaTime;
			Transform child = transform.GetChild(0);

			if (timer >= gazeTime) {
				ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerClickHandler);
				Vector3 newScale = new Vector3 (timer-timer , child.localScale.y, child.localScale.z);
				child.localScale = newScale;
				trashItem ();
				var dt = new DialogueTrigger(); 
				dt.triggerDialogue ();
				timer = 0f;
			}
		}
			
	}

	void onCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "MovementObject") {
			Debug.Log ("Clicked on movement object");
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
//		string temp = "Remaining Items:"+ count.ToString();
//		textMesh.text = temp;
	}

	void trashItem(){
//		
		Vector3 firstPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		Vector3 secondPosition = new Vector3 (-6.325f, 0.25f, -3.3739f);


		while (transform.position.x < -6.325f) {
			transform.position = secondPosition;
		}
		playTrashSound ();

	}

	void playTrashSound()
	{
		audioSource.clip = ac;
		Debug.Log ("playing");
		audioSource.Play ();
		obj.SetActive (false);

	}
}