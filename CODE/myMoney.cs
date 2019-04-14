using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myMoney : MonoBehaviour
{
    public TrackingMoney manager;
    public Text me;

    // Start is called before the first frame update
    void Start()
    {
        me.text = manager.playerMoney[0].ToString() + "V";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
