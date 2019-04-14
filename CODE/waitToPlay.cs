using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waitToPlay : MonoBehaviour
{
    public GameObject textbox;
    public Text timer;
    public float time = 60f; //30 seconds for you

    public void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            timer.text = Mathf.Round(time).ToString();
        }
        else
        {
            if(textbox.activeSelf)
            {
                textbox.SetActive(false);
            }
            Debug.Log("Play Audio Here -- Timer Over!!");
            GetComponent<AudioSource>().Play();
        }
    }
}
