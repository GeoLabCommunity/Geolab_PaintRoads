using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GzebisScript : MonoBehaviour {

 

	void Start () {
	
	}
	

	void Update () {
	
	}





    void OnMouseDown()
    {

        if (!GameController.levelOver)
        {
            GameController.instance.onRoadMouseDown();
            gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "yvelazeCin";

        }
      

        

    }



}
