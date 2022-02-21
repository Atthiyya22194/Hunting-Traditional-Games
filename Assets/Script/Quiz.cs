using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    [SerializeField] GameObject KuisBatu;
    [SerializeField] GameObject KuisKaret;
    [SerializeField] GameObject KuisKayu;
    [SerializeField] GameObject WinScreen;
    [SerializeField] GameObject PopUp;
    public GameObject itemButton1, itemButton2, itemButton3;
    public bool isClicked;
    public int items;

    void Start()
    {
        items = 0;
        WinScreen.gameObject.SetActive(false);
        PopUp.gameObject.SetActive(true);
    }


    void Update()
    {
        if (items >= 3)
        {
            FindObjectOfType<SFXmanager>().PlayWin();
            WinScreen.gameObject.SetActive(true);
            KuisBatu.SetActive(false);
            KuisKaret.SetActive(false);
            KuisKayu.SetActive(false);
        }
    }

    public void BatuKuis()
    {
        isClicked = true;
        KuisBatu.SetActive(true);
        Debug.Log("Please finish the quiz");
    }

    public void KaretKuis()
    {
        isClicked = true;
        KuisKaret.SetActive(true);
        Debug.Log("Please finish the quiz");
    }

    public void KayuKuis()
    {
        isClicked = true;
        KuisKayu.SetActive(true);
        Debug.Log("Please finish the quiz");
    }

    public void Close()
    {
        KuisBatu.SetActive(false);
        KuisKaret.SetActive(false);
        KuisKayu.SetActive(false);
        PopUp.SetActive(false);
        Time.timeScale = 1f; // 1 = aktif; 0 = paused;
    }

    public void Batu()
    {
        FindObjectOfType<SFXmanager>().PlayRight();
        itemButton1.SetActive(true);
        items += 1;
    }

    public void Karet()
    {
        FindObjectOfType<SFXmanager>().PlayRight();
        itemButton2.SetActive(true);
        items += 1;
    }

    public void Kayu()
    {
        FindObjectOfType<SFXmanager>().PlayRight();
        itemButton3.SetActive(true);
        items += 1;
    }

    public void WrongAnswer()
    {
        FindObjectOfType<SFXmanager>().PlayWrong();
    }
}
