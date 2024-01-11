using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKodlama : MonoBehaviour
{
    public GameObject balon;
    public GameObject sbalon;
    public GameObject ybalon;
    public GameObject tbalon;
    float balonOlusturmaSure = 1f;
    float sbalonOlusturmaSure = 25f;
    float ybalonOlusturmaSure = 7f;
    float zamanSayaci = 0f;
    float zamanSayaci2 = 15f;
    float zamanSayaci3 = 7f;
    OyunKontrol okScripti;
    void Start()
    {
        okScripti = this.gameObject.GetComponent<OyunKontrol>();
    }


    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        zamanSayaci2 -= Time.deltaTime;
        zamanSayaci3 -= Time.deltaTime;
        int katsayi = (int)(okScripti.gameTime / 10) - 6;
        katsayi *= -1;
        if (zamanSayaci < 0 && okScripti.gameTime > 0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.30f, 2.30f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f * katsayi, 180f * katsayi), 0));
            zamanSayaci = balonOlusturmaSure;

        }
        if (zamanSayaci2 < 0)
        {
            GameObject go1 = Instantiate(sbalon, new Vector3(Random.Range(-2.30f, 2.30f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go1.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(300f, 400f), 0));
            zamanSayaci2 = sbalonOlusturmaSure;
        }

        if (zamanSayaci3 < 0)
        {
            GameObject go2 = Instantiate(ybalon, new Vector3(Random.Range(-2.30f, 2.30f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go2.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(00f, 300f), 0));
            zamanSayaci3 = ybalonOlusturmaSure;
        }

    }
}

