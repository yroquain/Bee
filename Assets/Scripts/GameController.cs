using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


    private float Money;
    public float vitesse;
    public Text text;
	// Use this for initialization
	void Start ()
    {
        Money = 0;
        text.GetComponent<Text>().text = "Argent: " + (int)Money;

    }
	
	// Update is called once per frame
	void Update () {
    }

    public void AddMoney(float _money)
    {
        Money = Money + _money;
        text.GetComponent<Text>().text = "Argent: " + (int)Money;

    }
}
