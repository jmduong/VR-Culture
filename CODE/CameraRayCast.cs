using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class CameraRayCast : MonoBehaviour
{
    GameObject[] obstacle;
    //public TrackingMoney money;
    public XboxController controller;
    public GameObject yesOrNo, coin;
    [SerializeField]
    bool b1, b2, b3, b4, b5, b6, on;
    /*
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        //gameObject.transform.position = new Vector3(PlayerPrefs.GetInt("x"), PlayerPrefs.GetInt("y"), PlayerPrefs.GetInt("z"));

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }*/

    void Start()
    {/*
        print("START");
        GameObject[] bench = GameObject.FindGameObjectsWithTag("Spot");
        if(bench[0] != null)
        {
            gameObject.transform.position = bench[0].transform.position;
        }
        else
        {
            gameObject.transform.position = new Vector3(0, 0, 0); ;
        }*/
        obstacle = GameObject.FindGameObjectsWithTag("Switch");
        on = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (!b1 && !b2 && !b3 && !b4 && !b5 && !b6 && gameObject.CompareTag("Player"))
        {
            if (XCI.GetButton(XboxButton.B, controller))
            {
                int y = SceneManager.GetActiveScene().buildIndex;
                if (y == 0)
                {
                    if (!coin.activeSelf)
                    {
                        coin.SetActive(true);
                    }
                    else
                    {
                        coin.SetActive(false);
                    }
                }
                else if(obstacle != null)
                {
                    if(on)
                    {
                        for (int i = 0; i < obstacle.Length; i++)
                        {
                            obstacle[i].SetActive(false);
                            on = false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < obstacle.Length; i++)
                        {
                            obstacle[i].SetActive(true);
                            on = true;
                        }
                    }
                }
            }
        }

        if (XCI.GetButton(XboxButton.Y, controller))
        {
            SceneManager.LoadScene(0);
        }

        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            if (XCI.GetButton(XboxButton.A, controller))
            {
                string name = hit.collider.gameObject.name;
                switch (name)
                {
                    case "Theatre":
                        b1 = true;
                        yesOrNo.SetActive(true);
                        break;
                    case "Football":
                        b2 = true;
                        yesOrNo.SetActive(true);
                        break;
                    case "Oasis":
                        b3 = true;
                        yesOrNo.SetActive(true);
                        break;
                    case "Snowy":
                        b4 = true;
                        yesOrNo.SetActive(true);
                        break;
                    case "AdTown":
                        b5 = true;
                        yesOrNo.SetActive(true);
                        break;
                    case "Picnic":
                        b6 = true;
                        yesOrNo.SetActive(true);
                        break;
                }
            }
        }

        if (b1 && yesOrNo.activeSelf)
        {
            if (XCI.GetButton(XboxButton.A, controller))
            {
            //    money.playerMoney[0] -= 5;
                SceneManager.LoadScene(1);
            }
            else if (XCI.GetButton(XboxButton.B, controller))
            {
                b1 = false;
                yesOrNo.SetActive(false);
            }
        }
        else if (b2 && yesOrNo.activeSelf)
        {
            if (XCI.GetButton(XboxButton.A, controller))
            {
           //     money.playerMoney[0] -= 5;
                SceneManager.LoadScene(2);
            }
            else if (XCI.GetButton(XboxButton.B, controller))
            {
                b2 = false;
                yesOrNo.SetActive(false);
            }
        }
        else if (b3 && yesOrNo.activeSelf)
        {
            if (XCI.GetButton(XboxButton.A, controller))
            {
             //   money.playerMoney[0] -= 5;
                SceneManager.LoadScene(3);
            }
            else if (XCI.GetButton(XboxButton.B, controller))
            {
                b3 = false;
                yesOrNo.SetActive(false);
            }
        }
        else if (b4 && yesOrNo.activeSelf)
        {
            if (XCI.GetButton(XboxButton.A, controller))
            {
    //            money.playerMoney[0] -= 5;
                SceneManager.LoadScene(4);
            }
            else if (XCI.GetButton(XboxButton.B, controller))
            {
                b4 = false;
                yesOrNo.SetActive(false);
            }
        }
        else if (b5 && yesOrNo.activeSelf)
        {
            if (XCI.GetButton(XboxButton.A, controller))
            {
                //          money.playerMoney[0] -= 5;
                SceneManager.LoadScene(5);
            }
            else if (XCI.GetButton(XboxButton.B, controller))
            {
                b5 = false;
                yesOrNo.SetActive(false);
            }
        }
        else if (b6 && yesOrNo.activeSelf)
        {
            if (XCI.GetButton(XboxButton.A, controller))
            {
                //          money.playerMoney[0] -= 5;
                SceneManager.LoadScene(6);
            }
            else if (XCI.GetButton(XboxButton.B, controller))
            {
                b6 = false;
                yesOrNo.SetActive(false);
            }
        }
    }
}
