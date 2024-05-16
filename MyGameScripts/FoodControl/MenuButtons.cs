using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
    // With this OnMouseDown function we are basically giving life to the text mesh used for the menu tittles
        if(gameObject.name == "Reset")
        {
        FoodControl.EmptyPlateNow = 0;
        }

        if(gameObject.name == "Add to Menu")
        {
            FoodControl.FullMenu[0] = FoodControl.createdMenuItem;
            FoodControl.EmptyPlateNow = 0;
    
        }
    //Change of scene for when the menu items have been selected, the player will be transfered to the main counter
        
        if (gameObject.name == "Start Day")
        {
            SceneManager.LoadScene("Restaurant");
        }
    }
}
