using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	

    void OnTriggerEnter2D(Collider2D _item )
    {
        GameController.TAG = _item.tag;
        GameController.ballTriggerNum++;
    }

	// Update is called once per frame
	void Update () {
	
	}
}
