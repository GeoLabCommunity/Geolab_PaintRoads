using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public List<GameObject> gzebi;
    public int countPaintedPaths = 0;

    public static string TAG = "";
    public static int ballTriggerNum = 0;
    public static int ballListCount = 0;
<<<<<<< HEAD
=======


>>>>>>> origin/master

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
    public static GameController instance = null;

	void Start () {
        instance = this;
	}
	
	
	void Update () {
	
	}



    public  void onRoadMouseDown()
    {


        if (levelOver == false)
        {
            for (int i = 0; i < gzebi.Count; i++)
            {

                gzebi[i].GetComponent<SpriteRenderer>().sortingLayerName = "Default";


            }    
        }

     
    }



    public  void changePicture(string tag)
    {
        Sprite _changeSprite;
        GameObject _changeObject;
        Color _roadColor;
        print(tag);
        switch(tag)
        {
<<<<<<< HEAD
            case "red":
                _changeObject = whitePiano;
                _changeSprite = redPiano;
                _roadColor = new Color32(255, 0, 0, 255);
                break;
            case "green":
                _changeObject = whiteTelephone;
                _changeSprite = greenTelephone;
                _roadColor = new Color32(66, 174, 81, 255);
                break;
            case "blue":
                _changeObject = whiteZeppelin;
                _changeSprite = blueZeppelin;
                _roadColor = new Color32(0, 113, 188, 255);
                break;

			//2lvl
		case "Orange":
			_changeObject = whiteAirplane;
			_changeSprite = orangeAirplane;
			_roadColor = new Color32(251, 176, 59, 255);
			break;
		case "darkGreen":
			_changeObject = whiteFan;
			_changeSprite = darkGreenFan;
			_roadColor = new Color32(0, 146, 69, 255);
			break;
		case "purple":
			_changeObject = whiteHeart;
			_changeSprite = purpleHeart;
            _roadColor = new Color32(153, 111, 221, 255);
			
			break;
		case "lightBlue":
			_changeObject = whiteBinoculars;
			_changeSprite = lightBlueBinoculars;
            _roadColor = new Color32(63, 169, 245, 255);
			break;



			//3lvl
		case "cyanish":
			_changeObject = whiteJewelcase;
			_changeSprite = cyanishJewelcase;
			_roadColor = new Color32(118, 160, 184, 255);
			break;

		case "darkred":
			_changeObject = whiteGloves;
			_changeSprite = darkRedGloves;
			_roadColor = new Color32(145, 44, 63, 255);
			break;

		case "3green":
			_changeObject = whiteLamp;
			_changeSprite = greenLamp;
			_roadColor = new Color32(39, 145, 63, 255);
			break;

		case "3orange":
			_changeObject = whiteBook;
			_changeSprite = yellowBook;
			_roadColor = new Color32(253, 206, 0, 255);
			break;

		case "pink":
			_changeObject = whiteGlasses;
			_changeSprite = pinkGlasses;
			_roadColor = new Color32(246, 205, 218, 255);
			break;
			//
=======
            case "r":
                _changeObject = whitePiano;
                _changeSprite = redPiano;
                _roadColor = new Color(255, 0, 0, 255);
                break;
            case "g":
                _changeObject = whiteTelephone;
                _changeSprite = greenTelephone;
                _roadColor = new Color(66, 174, 81, 255);
                break;
            case "b":
                _changeObject = whiteZeppelin;
                _changeSprite = blueZeppelin;
                _roadColor = new Color(0, 113, 188, 255);
                break;
>>>>>>> origin/master
            default:
                _changeSprite = new Sprite(); 
               _changeObject = new GameObject();
               _roadColor = new Color(0, 0, 0, 0);
              break;
<<<<<<< HEAD



        }

        _changeObject.GetComponent<SpriteRenderer>().sprite = _changeSprite as Sprite;
        GameObject.FindGameObjectWithTag(tag).GetComponent<SpriteRenderer>().color = _roadColor;
		gameObject.GetComponent<AudioSource>().Play();



        countPaintedPaths++;

        if (countPaintedPaths == gzebi.Count)
        {
            LevelFinished();
        }
       
    }

=======
        }

        _changeObject.GetComponent<SpriteRenderer>().sprite = _changeSprite as Sprite;
        GameObject.FindGameObjectWithTag(tag).GetComponent<SpriteRenderer>().color = _roadColor;
        button.GetComponent<AudioSource>().Play();
      
       
    }

>>>>>>> origin/master
    // ტურს რომ გაივლის, ამოვიდეს შეტყობინება, რომ შეუძლია, შემდეგ ლეველზე გადავიდეს.
    //ერთი ღილაკით შეუძლია, ისევ ეს ტური გაიაროს, მეორეთი - გადავიდეს შემდეგ ტურზე.
    // თან, გზები უბრუნდება საწყის, დეფაულტ პოზიციას (რომ ამ შეტყობინებაზე მაღლა არ იდგეს არცერთი გზა)

    public void LevelFinished() {

        countPaintedPaths = 0;


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
