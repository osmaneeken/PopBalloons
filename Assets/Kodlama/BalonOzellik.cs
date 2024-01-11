using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalonOzellik : MonoBehaviour
{
    public GameObject sbalon;
    OyunKontrol oyunKontrolScript;
    void Start()
    {
        oyunKontrolScript = GameObject.Find("_script").GetComponent<OyunKontrol>();
    }

    public void OnMouseDown()
    {
        GameObject go = Instantiate(sbalon, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.217f);
        oyunKontrolScript.gameover();
        SceneManager.LoadScene("bitir");

    }


}
