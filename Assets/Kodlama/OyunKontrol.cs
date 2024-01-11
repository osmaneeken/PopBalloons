using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText, balonText;
    public GameObject patlama;
    public GameObject sbalon;
    public GameObject ybalon1;
    public float gameTime=60f;
    int balonSayaci;
    
    void Start()
    {
        balonText.text = "Balon: " + balonSayaci;
    }

    
    void Update()
    {
        if(gameTime > 0)
        {
            gameTime -= Time.deltaTime;
            zamanText.text = "Zaman: " + (int)gameTime;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i=0; i<go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position,go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
        
    }

    public void BalonEkle ()
    {
        balonSayaci += 1;
        balonText.text = "Balon: " + balonSayaci;
    }

    public void gameover() 
    {
        gameTime = 0;

    }

    public void BonusBalon()
    {
        balonSayaci += 5;
        balonText.text = "Balon: " + balonSayaci;
    }

}
