using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

    public GameObject ToDestroy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public  void OnDestroyClick()
    {
        Destroy(ToDestroy);
    }

    public void OnClickCollect(GameObject Coin)
    {
        this.gameObject.GetComponent<GameController>().AddMoney(Coin.GetComponent<CoinController>().value);
        Coin.SetActive(false);
    }
}
