using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public List<GameObject> gzebi;



    public GameObject button;

    public List<Button> bluePathButtons;
    public GameObject levelIsOver1;
    public GameObject levelIsOver2;

    public static bool levelOver = false;


    // პირველი ტურის ობიექტები


    public GameObject whiteZeppelin;
    public Sprite blueZeppelin;

    public GameObject whiteTelephone;
    public Sprite greenTelephone;

    public GameObject whitePiano;
    public Sprite redPiano;



    // მეორე ტურის ობიექტები


    public GameObject whiteAirplane;
    public Sprite orangeAirplane;

    public GameObject whiteBinoculars;
    public Sprite lightBlueBinoculars;

    public GameObject whiteFan;
    public Sprite darkGreenFan;


    public GameObject whiteHeart;
    public Sprite purpleHeart;




    // მესამე ტურის ობიექტები


    public GameObject whiteBook;
    public Sprite yellowBook;

    public GameObject whiteGlasses;
    public Sprite pinkGlasses;

    public GameObject whiteLamp;
    public Sprite greenLamp;


    public GameObject whiteGloves;
    public Sprite darkRedGloves;

    
    public GameObject whiteJewelcase;
    public Sprite cyanishJewelcase;


	void Start () {
       
	}
	
	
	void Update () {
	
	}



    public void onRoadMouseDown()
    {


        if (levelOver == false)
        {
            for (int i = 0; i < gzebi.Count; i++)
            {

                gzebi[i].GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                //var GameObjectPosition = gzebi[i].transform.position;
                //gzebi[i].transform.position = new Vector3(GameObjectPosition.x, GameObjectPosition.y, 0);

            }    
        }

     
    }



    public void changePicture()
    {

        //Instantiate(feradi, ufero.transform.position, ufero.transform.rotation);
        whiteZeppelin.GetComponent<SpriteRenderer>().sprite = blueZeppelin;
        button.GetComponent<Button>().interactable = false;
        gzebi[0].GetComponent<SpriteRenderer>().color = new Color32(0, 113, 188, 255); ;
        //#0071BCFF;
      
       
    }

    public void yay()
    {
        button.GetComponent<AudioSource>().Play();
    }


    // ტურს რომ გაივლის, ამოვიდეს შეტყობინება, რომ შეუძლია, შემდეგ ლეველზე გადავიდეს.
    //ერთი ღილაკით შეუძლია, ისევ ეს ტური გაიაროს, მეორეთი - გადავიდეს შემდეგ ტურზე.
    // თან, გზები უბრუნდება საწყის, დეფაულტ პოზიციას (რომ ამ შეტყობინებაზე მაღლა არ იდგეს არცერთი გზა)

    public void LevelFinished() {
        for (int i = 0; i < gzebi.Count; i++)
        {

            gzebi[i].GetComponent<SpriteRenderer>().sortingLayerName = "Default";

            //var GameObjectPosition = gzebi[i].transform.position;
            //gzebi[i].transform.position = new Vector3(GameObjectPosition.x, GameObjectPosition.y, 0);


        }

        levelIsOver1.SetActive(true);
        levelIsOver2.SetActive(true);

        levelOver = true;

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



    //პირველი ლეველის ჩართვა

    public void StartFirstLevel()
    {
        //Application.LoadLevel(2);

        SceneManager.LoadScene(1);
    }



    // მეორე ლეველზე ჩართვა

    public void StartSecondLevel()
    {
        //Application.LoadLevel(2);

        SceneManager.LoadScene(2);
    }


    //მესამე ლეველის ჩართვა

    public void StartThirdLevel()
    {
        //Application.LoadLevel(2);

        SceneManager.LoadScene(3);
    }


    public void exitInterLevelText() {
        levelOver = false;
    }



}
