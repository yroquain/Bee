using UnityEngine;
using System.Collections;

public class BeeMove : MonoBehaviour {


    public Transform startMarker;
    public Transform endMarker1;
    public Transform endMarker2;
    public GameObject Ruche;
    public GameObject Tree;
    private bool IsGoing;
    public float speed;
    // Use this for initialization
    void Start () {
        IsGoing = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        float step = speed * Time.deltaTime;
        if (IsGoing)
        {
            transform.position = Vector3.MoveTowards(startMarker.position, endMarker1.position, step);
            if (transform.position.y - endMarker1.position.y > -1)
            {
                IsGoing = false;
                Tree.GetComponent<TreeController>().BeeComing();
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(startMarker.position, endMarker2.position, step);
            if (transform.position.y - endMarker2.position.y < 1)
            {
                IsGoing = true;
                Ruche.GetComponent<RucheController>().BeeComing();
            }
        }
	
	}
}
