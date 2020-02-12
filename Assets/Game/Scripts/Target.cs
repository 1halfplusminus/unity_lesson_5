using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    // Start is called before the first frame update
    public float minSpeed = 12f;
    public float maxSpeed = 16f;

    public float maxTorque = 10.0f;

    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    Vector3 RandomTorque()
    {
        return new Vector3(0, Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque));
    }
}
