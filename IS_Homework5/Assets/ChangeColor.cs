using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //reference objects in order to change the color (the hands)
    public GameObject rHand;
    public GameObject lHand;
    Renderer r; //renderer used to change the color
    float threshold;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>(); //getting the render of the current object
        threshold = 1.5f; //init the threshold
    }

    void change_color(Color c) { //given a certain color change the color of the material of the object
        r.material.SetColor("_Color",c);
    }

    // Update is called once per frame
    void Update()
    {
        //getting the height of both hands
        float y_r = rHand.transform.position.y;
        float y_l = lHand.transform.position.y;

        //depending of which hand is beyond the threshold, change to an specific color
        if( y_l > threshold){
            change_color(Color.red);
        }else if(y_r > threshold){
            change_color(Color.green);
        }else{ //if both hands are down, the color is white
            change_color(Color.white);
        }
        
    }
}
