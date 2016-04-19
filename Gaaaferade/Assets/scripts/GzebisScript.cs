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
            gameObject.GetComponent<GameController>().onRoadMouseDown();

            gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "yvelazeCin";

            //var GameObjectPosition = gameObject.transform.position;
            //gameObject.transform.position = new Vector3(GameObjectPosition.x, GameObjectPosition.y, -1);
        }
      

        

    }



}
