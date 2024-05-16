using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodControl : MonoBehaviour
{
  //Arrays made for orders and their value which will be compared to the plate value to make sure the order is correctly taken and a timer for the time the order must be served in.
    public static int []orderValue= {150, 500, 700};
    public static int[] plateValue= {0,0,0};
    
    public static float [] OrderTimer= {5f,6f,4f};

    public static int plateNum =0;
    public static float plateXpos = 0;
    
    public Transform plateSelector;
///Arrays made for posting the others visually for the player to see
    public MeshRenderer [] CurrentPic;

    public Texture [] orderPic;
    
// Float for managing plates after food is served, when its time to empty the plate and which one
    public static float EmptyPlateNow = -1;

    public static float TotalCash = 0;

    //Array For the menu items 
    public static int [] FullMenu = {0,0,0,0,};
    public static int createdMenuItem;
    
    // Start is called before the first frame update
    void Start()
    {
      //All menu values remain on 0 because randonmization factor will be added, so the player can have a less predictable experience
        orderValue [0] = FullMenu[0];
        orderValue [1] = FullMenu[0];
        orderValue [2] = FullMenu[0];

      //for loop that adds images to  planes in the game scene for the player to visually see the order
        for (int rep = 0; rep < 3; rep++)
        {
          if (orderValue[rep] == 150)
          CurrentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPic[0];
          if (orderValue[rep] == 500)
          CurrentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPic[1];
          if (orderValue[rep] == 700)
          CurrentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPic[2];
        }
    }

    // Update is called once per frame
    void Update()
    {
 //assigning the tab key Having to have the plate selector move from plate to plate by adding 4 on the X axis

        if(Input.GetKeyDown("tab"))
        {
          plateNum += 1;
          plateXpos += 4;

          if (plateNum >2)
          {
            plateNum = 0;
            plateXpos = 0;
          }
        } 
//set of timers using delta the change of a variable, in this case a variable measuring time which will be based on the individual responsiveness of each players cpu.
       OrderTimer[0] -= Time.deltaTime;
       OrderTimer[1] -= Time.deltaTime;
       OrderTimer[2] -= Time.deltaTime;
       

 //plate selectors initial postion
       plateSelector.transform.position = new Vector3 (plateXpos,3.1f,0.91f);
    }
    
}
