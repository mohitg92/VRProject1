using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public TextMesh dialogueText = new TextMesh ();
//	public Text dialogueText; 
	private Queue<string> sentences;
	private float timer = 2f;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string> ();
	}

	public void StartDialogue (Dialogue dialogue){
		
		sentences.Clear ();

		foreach (string sentence in dialogue.sentences) {
			sentences.Enqueue (sentence);
		}

		DisplayNextSentence ();
	}

	public void DisplayNextSentence(){
		if (sentences.Count == 0) {
			EndDialogue ();
			return;
		}
		string sentence = sentences.Dequeue ();
		float timeStart = Time.time;
		dialogueText.text = sentence;
	}

	void EndDialogue(){
		Debug.Log ("Dialogue ended");
	}


}
