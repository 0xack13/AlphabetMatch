using UnityEngine;
using System.Collections;

public class A : MonoBehaviour {

	private static GameManager gameManager;

	// Use this for initialization
	void Start () {
		if (gameManager == null) {
			gameManager = GameObject.FindObjectOfType<GameManager> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnAMouseClick(A a) {
		gameManager.OnAMouseClick (a);
	}
}
