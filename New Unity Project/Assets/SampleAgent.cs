using UnityEngine;
using System.Collections;

public class SampleAgent : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;
	
	void Start () {
        this.agent = this.gameObject.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        agent.SetDestination(target.position);
    }
}
