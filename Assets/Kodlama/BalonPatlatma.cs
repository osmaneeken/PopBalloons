using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonPatlatma : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrol oyunKontrolScript;
    private void Start()
    {
        oyunKontrolScript=GameObject.Find("_script").GetComponent<OyunKontrol>();
    }
    public void OnMouseDown()
    {
        GameObject go =Instantiate(patlama,transform.position,transform.rotation)as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0.217f);
        oyunKontrolScript.BalonEkle();
    }

}
