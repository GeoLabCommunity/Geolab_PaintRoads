using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public List<GameObject> gzebi;

    public GameObject ufero;
    public GameObject feradi;
    public GameObject button;

    public List<Button> bluePathButtons;
   

	void Start () {
       
	}
	
	
	void Update () {
	
	}



    public void onRoadMouseDown()
    {
        for (int i = 0; i < gzebi.Count; i++)
        {

            gzebi[i].GetComponent<SpriteRenderer>().sortingLayerName = "Default";

            //var GameObjectPosition = gzebi[i].transform.position;
            //gzebi[i].transform.position = new Vector3(GameObjectPosition.x, GameObjectPosition.y, 0);


        }      
    }



    public void changePicture()
    {
       
        Instantiate(feradi, ufero.transform.position, ufero.transform.rotation);
        button.GetComponent<Button>().interactable = false;
        gzebi[0].GetComponent<SpriteRenderer>().color = new Color32(0, 113, 188, 255); ;
        //#0071BCFF;
       
    }

    public void yay()
    {
        button.GetComponent<AudioSource>().Play();
    }


    public void moveToFront(Button button)
    {
 

        //print(button.GetComponent<RectTransform>().localPosition);
        

        button.GetComponent<SpriteRenderer>().enabled = true;
        button.GetComponent<SpriteRenderer>().sortingLayerName = "yvelazeCin";

        bluePathButtons[1].GetComponent<Button>().interactable = true;
        //var buttonPosition = button.GetComponent<RectTransform>().localPosition;
        //button.GetComponent<RectTransform>().localPosition = new Vector3(buttonPosition.x, buttonPosition.y, -5);
        //print(button.GetComponent<RectTransform>().localPosition);
    }


}
