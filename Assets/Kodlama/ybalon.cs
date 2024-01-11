using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ybalon : MonoBehaviour
{
    public GameObject ybalon1;
    OyunKontrol oyunKontrolScript;
    void Start()
    {
        oyunKontrolScript = GameObject.Find("_script").GetComponent<OyunKontrol>();
    }

    public void OnMouseDown()
    {
        GameObject go = Instantiate(ybalon1, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.217f);
        oyunKontrolScript.BonusBalon();

    }
}