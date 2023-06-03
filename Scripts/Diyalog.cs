using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Diyalog : MonoBehaviour
{
    [SerializeField] private TMP_Text DiyalogText;
    [SerializeField] private string[] cumleler;
    [SerializeField] private float yazmaHizi;
    [SerializeField] private GameObject devambutonu;
    [SerializeField] private GameObject Ba�lat;

    private int index;

    private void Start()
    {
        StartCoroutine(yaz());
    }

    private void Update()
    {
        if(DiyalogText.text == cumleler[index])
        {
            devambutonu.SetActive(true);
        }
    }
    IEnumerator yaz()
    {
        foreach(char harf in cumleler[index].ToCharArray())
        {
            DiyalogText.text += harf;
            yield return new WaitForSeconds(yazmaHizi);
        }
    }

    public void sonrakiC�mle()
    {
        devambutonu.SetActive(false);

        if(index < cumleler.Length -1)
        {
            index++;
            DiyalogText.text = "";
            StartCoroutine(yaz());
        }

        else
        {
            DiyalogText.text = "";
            devambutonu.SetActive(false) ;
            Ba�lat.SetActive(true);
        }
    }

    public void OyunuBaslat()
    {
        SceneManager.LoadScene("sahne");
    }
}
