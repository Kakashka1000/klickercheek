
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using UnityEngine.U2D.Animation;

public class klick : MonoBehaviour
{
    private int rate = 1;
    public int money;
    public Text anime;
    public GameObject mikroo;
    public GameObject panel;
    bool isopened;
    public GameObject cameraa;
    public GameObject telefon;
    bool telefonest = false;
    public GameObject Faq;
    private bool rotik;

    int telefonint;
    int telefo = 0;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        rate = PlayerPrefs.GetInt("rate");
        PlayerPrefs.GetInt("telefo");
        telefonint = PlayerPrefs.GetInt("telefon1");
        

        rotik = true;

        if (PlayerPrefs.HasKey("telefon"))
        {
            telefon.SetActive(false);
        }
        if(telefo == 1 && PlayerPrefs.HasKey("telefon1"))
        {
            telefon.SetActive(true);
            telefo = 0;
            PlayerPrefs.SetInt("telefo", telefo);
        }
        
    }
    private void Awake()
    {
    }
    public void Button()
    {
        money += rate;
        PlayerPrefs.SetInt("money", money);
    }
    void Update()
    {
        anime.text = money.ToString();
    }
    public void aboba()
    {
        money = 0;
        rate = 1;
        cameraa.SetActive(true);
        mikroo.SetActive(true);
        telefon.SetActive(true);
        PlayerPrefs.SetInt("telefon1", 1);
        telefo = 0;
        PlayerPrefs.SetInt("telefo", telefo);
     
    }
    public void mikro()
    {
        if (money >= 350 && telefonest == true)
        {
            rate = 2;
            money -= 350;
            PlayerPrefs.SetInt("rate", rate);
            PlayerPrefs.SetInt("money", money);
            mikroo.SetActive(false);
        }
    }
    public void Panell()
    {
        isopened = !isopened;
        panel.SetActive(isopened);
    }
    public void camera1()
    {
        if (money >= 800 && telefonest == true){
            rate = 3;
            PlayerPrefs.SetInt("rate", rate);
            cameraa.SetActive(false);
            money -= 800;
            PlayerPrefs.Save();
        }
    }
    public void telefon1()
    {
        if(money >= 50)
        {
            money -= 50;
            telefon.SetActive(false);
            telefonest = true;
            PlayerPrefs.SetInt("telefon", 0);
            telefo = 0;
        }
    }
    public void krestik()
    {
        panel.SetActive(false);
        Faq.SetActive(false);
    }
    public void fuckyou()
    {
        Faq.SetActive(true);
    }
    public void zvyk()
    {
        if (!rotik)
        {
            AudioListener.volume = 1f;
            rotik = true;
        } else if (rotik)
        {
            AudioListener.volume = 0f;
            rotik = false;
        }
    }
    public void exit()
    {
        {
            Application.Quit();
        }
    }
}
 