using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class createBall : MonoBehaviour {

    public GameObject ball;
    Vector3 mousePos;
    Vector3 objectPos;
    Vector3 lastPos;
    Vector3 currentPos;
    List <GameObject> balls;
    bool isMouseDown = false;
    public float BornRad = 0.1f;


	// Use this for initialization
	void Start () {
        balls = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            GameController.ballListCount = balls.Count;
            print(GameController.ballListCount);
            print(GameController.ballTriggerNum);

            if (GameController.ballListCount <= GameController.ballTriggerNum +3)
            {
                if (balls[0].transform.position.x >= -6 && balls[0].transform.position.x <= -4 && balls[balls.Count - 1].transform.position.x >= 4 && balls[balls.Count - 1].transform.position.x <= 6)
                {
                    print("yay");
                    GameController.instance.changePicture(GameController.TAG);
                }
            }
            int i= balls.Count -1;
            while (i>=0)
            {
                Destroy(balls[i]);
                balls.RemoveAt(i);
                i--;
           }
        }

         if(isMouseDown)
         {
             Camera camera = GetComponent<Camera>();
             mousePos = Input.mousePosition;
             currentPos = mousePos;
             currentPos = camera.ScreenToWorldPoint(currentPos);
             if ( Mathf.Abs(Mathf.Sqrt(Mathf.Pow((currentPos.x-lastPos.x),2) + Mathf.Pow((currentPos.y-lastPos.y),2))) >= BornRad)
             {
                 lastPos = currentPos;
                 GameObject _ball = Instantiate(ball, new Vector3(lastPos.x, lastPos.y,10), Quaternion.identity) as GameObject;
                 balls.Add(_ball);
             }         
         }


	if (Input.GetMouseButtonDown(0))
    {
        GameController.ballTriggerNum = 0;
        GameController.ballListCount = 0;
        Camera camera = GetComponent<Camera>();
        isMouseDown = true;
        lastPos = camera.ScreenToWorldPoint(Input.mousePosition);
        GameObject _ball = Instantiate(ball, new Vector3(lastPos.x, lastPos.y, 10), Quaternion.identity) as GameObject;
        balls.Add(_ball);
    }

  
	}
}
