using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingMoney : MonoBehaviour
{
    public List<int> playerMoney = new List<int>();
    public bool introed = false;
    public GameObject narrativeIntro;
    [SerializeField]
    bool moneyBeenPassed = false;

    // Start is called before the first frame update
    void Start()
    {
        if(introed)
        {
            narrativeIntro.SetActive(false);
        }
        if(!moneyBeenPassed)
        {
            for (int i = 0; i < 8; i++)
            {
                playerMoney.Add(100);   // Each person starts with 100 V-Coins.
            }
            moneyBeenPassed = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
