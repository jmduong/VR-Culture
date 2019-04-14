using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introductions : MonoBehaviour
{
    List<string> narrative = new List<string>();
    public GameObject instructions;
    public Text box;
    float timeStamp;
    int index = 0;
    //public TrackingMoney tracked;

    // Start is called before the first frame update
    void Start()
    {
        narrative.Add("Welcome to VR Culture, a realm that proves the world is truly a small world.");
        narrative.Add("We're here to share a special experience of traveling the world from the comforts of home.");
        narrative.Add("Come join us at the next annual pumpkin festival in Berlin, walk through the trails of the Niagara Falls, ");
        narrative.Add("or spend some time fervently discussing the next episode of Dr. Strange with other fans from around the world.");
        narrative.Add("Experience the greatest journey of your life, and enjoy the small things that make life truly wonderful with other cultures around the world.");
        box.text = narrative[0];
    }

    // Update is called once per frame
    void Update()
    {
        timeStamp += Time.deltaTime;

        if(timeStamp >= 5.0f)
        {
            index++;
            if(index >= 6)
            {
                instructions.SetActive(true);
                //tracked.introed = true;
                gameObject.SetActive(false);
            }
            box.text = narrative[index];
            timeStamp -= 5.0f;
        }
    }
}
