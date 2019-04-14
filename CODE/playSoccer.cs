using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoccer : MonoBehaviour
{
    public GameObject football, netGoal, otherGoal;
    public Rigidbody ballRb;

    float scaleValue;
    [SerializeField]
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scaleValue += 0.0001f;
        if(ballRb.velocity.magnitude < 0.01)
        {
            ballRb.velocity = new Vector3(0, 0, 0);
        }
        else if(ballRb.velocity.magnitude > 0)
        {
            ballRb.velocity *= 0.999f;
        }
        transform.LookAt(football.transform);
        rb.MovePosition(transform.position + transform.forward * Time.deltaTime * Random.Range(20.0f, 30.0f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Foot Ball")
        {
            other.transform.LookAt(netGoal.transform);

            // Calculate Angle Between the collision point and the player
            Vector3 dir = other.transform.position - netGoal.transform.position;
            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            other.gameObject.GetComponent<Rigidbody>().AddForce((netGoal.transform.position - other.transform.position) * (1 + scaleValue) * Random.Range(6.0f, 12.0f));

            if (other.gameObject.tag.Contains("Team"))
            {
                // Calculate Angle Between the collision point and the player
                Vector3 dire = other.transform.position- transform.position;
                dire = -dire.normalized;
                // This will push back the player
                GetComponent<Rigidbody>().AddForce(dire * Random.Range(1.0f, 3.0f));
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Foot Ball")
        {
            col.transform.LookAt(netGoal.transform);

            // Calculate Angle Between the collision point and the player
            Vector3 dir = col.transform.position - netGoal.transform.position;
            col.gameObject.GetComponent<Rigidbody>().AddForce((netGoal.transform.position - col.transform.position) * Random.Range(4.0f, 8.0f));
        }

        if(col.gameObject.tag.Contains("Team"))
        {
            // Calculate Angle Between the collision point and the player
            Vector3 dir = col.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * Random.Range(1.0f, 3.0f));
        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Foot Ball")
        {
            other.transform.LookAt(netGoal.transform);
            // Calculate Angle Between the collision point and the player
            //Vector3 dir = other.transform.position - netGoal.transform.position;
            //other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * Random.Range(4.0f, 8.0f));
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * Random.Range(4.0f, 8.0f), ForceMode.Acceleration);

        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Foot Ball")
        {
            col.transform.LookAt(netGoal.transform);
            // Calculate Angle Between the collision point and the player
            //Vector3 dir = other.transform.position - netGoal.transform.position;
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * Random.Range(4.0f, 8.0f), ForceMode.Acceleration);
        }
    }*/
}
