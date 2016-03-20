using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public List<GameObject> gzebi;

    public GameObject ufero;
    public GameObject feradi;
    public GameObject button;
   

	void Start () {
       
	}
	
	
	void Update () {
	
	}



    public void onRoadMouseDown()
    {
        for (int i = 0; i < gzebi.Count; i++)
        {
            //var GameObjectPosition = gzebi[i].transform.position;
            gzebi[i].GetComponent<SpriteRenderer>().sortingLayerName = "Default";
       
            //gzebi[i].transform.position = new Vector3(GameObjectPosition.x, GameObjectPosition.y, 0);
        }      
    }



    public void changePicture()
    {
        Instantiate(feradi, ufero.transform.position, ufero.transform.rotation);
        button.GetComponent<Button>().interactable = false;
    }
  
}
