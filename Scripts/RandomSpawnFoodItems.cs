using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnFoodItems : MonoBehaviour {

	public Transform[] spawnLocations;
	public GameObject[] whatToSpawnPrefab;
	public GameObject[] whatToSpawnClone;
	public AudioSource audioSource;
	public AudioClip ac;

	void start(){
		spawnSomethingAwesomePlease ();
	}


	void spawnSomethingAwesomePlease(){
		whatToSpawnClone [0] = Instantiate (whatToSpawnPrefab [0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
		playSound ();
		whatToSpawnClone [1] = Instantiate (whatToSpawnPrefab [1], spawnLocations[1].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
		whatToSpawnClone [2] = Instantiate (whatToSpawnPrefab [2], spawnLocations[2].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
	}

	void playSound()
	{
		audioSource.clip = ac;
		Debug.Log ("playing");
		audioSource.Play ();
	}


//		[SerializeField]
//		float _timeBetweenSpawns = 5f;
//
//		[SerializeField]
//		public GameObject[] _prefabs;
//
//		BoxCollider collider;
//		Bounds _spawnBounds;
//		float currentTimer = 0f;
//		bool _ok;
//
//
//		// Use this for initialization
//		void Start ()
//		{
//			_ok = true;
//			collider = GetComponent<BoxCollider>();
//
//			if(collider == null)
//			{
//				Debug.LogError("No Box Collider attached to game object.");
//				_ok = false;
//			}
//			else
//			{
//				_spawnBounds = collider.bounds;
//			}
//
//			if(_prefabs == null || _prefabs.Length == 0)
//			{
//				Debug.LogError("No prefabs attached.");
//				_ok = false;
//			}
//		}
//
//		// Update is called once per frame
//		void Update ()
//		{
//			if (_ok)
//			{
//				currentTimer += Time.deltaTime;
//
//				if (currentTimer >= _timeBetweenSpawns)
//				{
//					currentTimer = 0;
//
//					float spawnX = Random.Range(-_spawnBounds.extents.x, _spawnBounds.extents.x);
//					float spawnY = transform.position.y;
//					float spawnZ = transform.position.z;
//
//					//SPAWN OBJECT
//					GameObject newItem = Object.Instantiate(GetPrefab()) as GameObject;
//					newItem.transform.position = new Vector3(spawnX, spawnY, spawnZ);
//				}
//			}
//		}
//
//		private GameObject GetPrefab()
//		{
//			int index = Random.Range(0, _prefabs.Length);
//
//			return _prefabs[index];
//		}

}
