using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Helicopter : MonoBehaviour {


    public GameObject target;

    private bool called = false;
    private Rigidbody rigidbody;

    Player playerPosition;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");
	}

    private void Update()
    {
        if (called == true)
        {
            if (target.transform.position != transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 50f * Time.deltaTime);
            }
            else
            {
                return;
            }
        }
    }

    void OnDispatchHelicopter()
    {
        Debug.Log("Helicopter called");
        called = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
