using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oculusInput : MonoBehaviour
{
    [SerializeField]
    // public GameObject yearBox;

    public GameObject map, parent, startBox;
    public GameObject contact;
    public Transform child = null;
    public bool touching;
    float rotationSpeed;
    int grade; // Switch between changing modes, years, or

    // Start is called before the first frame update
    void Start()
    {
        startBox.SetActive(true);
        rotationSpeed = 1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.DpadUp))
        {

        }
        else if (OVRInput.GetDown(OVRInput.Button.DpadDown))
        {

        }
        else if (OVRInput.GetDown(OVRInput.Button.DpadLeft))
        {

        }
        else if (OVRInput.GetDown(OVRInput.Button.DpadRight))
        {

        }
        else if (OVRInput.GetDown(OVRInput.Button.One))
        {

        }
        else if (OVRInput.GetDown(OVRInput.Button.Two))
        {

        }
        else
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.name;
        switch (name)
        {
            case "Theatre":
                SceneManager.LoadScene(1);
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        touching = false;
        contact = null;
    }
}