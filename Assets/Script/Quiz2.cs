using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz2 : MonoBehaviour
{
    [SerializeField] GameObject KuisKertas;
    [SerializeField] GameObject KuisBenang;
    [SerializeField] GameObject KuisLem;
    [SerializeField] GameObject KuisBambu;
    [SerializeField] GameObject WinScreen;
    [SerializeField] GameObject PopUp;
    public GameObject itemButton1, itemButton2, itemButton3, itemButton4;
    public bool isClicked;
    public int items;

    void Start()
    {
        items = 0;
        KuisKertas.SetActive(false);
        KuisBenang.SetActive(false);
        KuisLem.SetActive(false);
        KuisBambu.SetActive(false);
        WinScreen.gameObject.SetActive(false);
        PopUp.gameObject.SetActive(true);
    }


    void Update()
    {
        if (items >= 4)
        {
            FindObjectOfType<SFXmanager>().PlayWin();
            WinScreen.gameObject.SetActive(true);
            KuisKertas.SetActive(false);
            KuisBenang.SetActive(false);
            KuisLem.SetActive(false);
            KuisBambu.SetActive(false);
        }
    }

    public void KertasKuis()
    {
        isClicked = true;
        KuisKertas.SetActive(true);
        Debug.Log("Please finish the quiz");
    }

    public void BenangKuis()
    {
        isClicked = true;
        KuisBenang.SetActive(true);
        Debug.Log("Please finish the quiz");
    }

    public void LemKuis()
    {
        isClicked = true;
        KuisLem.SetActive(true);
        Debug.Log("Please finish the quiz");
    }

    public void BambuKuis()
    {
        isClicked = true;
        KuisBambu.SetActive(true);
        Debug.Log("Please finish the quiz");
    }

    public void Close()
    {
        KuisKertas.SetActive(false);
        KuisBenang.SetActive(false);
        KuisLem.SetActive(false);
        KuisBambu.SetActive(false);
        PopUp.gameObject.SetActive(false);
        Time.timeScale = 1f; // 1 = aktif; 0 = paused;
    }

    public void Kertas()
    {
        FindObjectOfType<SFXmanager>().PlayRight();
        itemButton1.SetActive(true);
        items += 1;
    }

    public void Benang()
    {
        FindObjectOfType<SFXmanager>().PlayRight();
        itemButton2.SetActive(true);
        items += 1;
    }

    public void Lem()
    {
        FindObjectOfType<SFXmanager>().PlayRight();
        itemButton3.SetActive(true);
        items += 1;
    }

    public void Bambu()
    {
        FindObjectOfType<SFXmanager>().PlayRight();
        itemButton4.SetActive(true);
        items += 1;
    }

    public void WrongAnswer()
    {
        FindObjectOfType<SFXmanager>().PlayWrong();
    }
}
