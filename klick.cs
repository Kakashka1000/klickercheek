
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
    private bool telefonys;

    public GameObject Faq;
    private bool rotik;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        rate = PlayerPrefs.GetInt("rate");

        rotik = true;
        if(PlayerPrefs.HasKey("telefonys") && PlayerPrefs.GetInt("telefonys") == 1)
        {
            telefonys = true;
        }
        else
        {
            if(PlayerPrefs.HasKey("telefonys") && PlayerPrefs.GetInt("telefonys") == 0)
            {
                telefonys = false;
            }
        }
        if (PlayerPrefs.HasKey("telefon") && PlayerPrefs.GetInt("telefon") == 0)
        {
            telefon.SetActive(false);
        }
        else
        {
            if (!PlayerPrefs.HasKey("telefon"))
            {
                telefon.SetActive(true);
                PlayerPrefs.SetInt("telefon", 1);
            }
        }
        if (PlayerPrefs.HasKey("mikro") && PlayerPrefs.GetInt("mikro") == 0)
        {
            mikroo.SetActive(false);
        }
        else
        {
            if (!PlayerPrefs.HasKey("mikro"))
            {
                mikroo.SetActive(true);
                PlayerPrefs.SetInt("mikro", 1);
            }
        }
        if (PlayerPrefs.HasKey("camera") && PlayerPrefs.GetInt("camera") == 0)
        {
            cameraa.SetActive(false);
        }
        else
        {
            if (!PlayerPrefs.HasKey("camera"))
            {
                cameraa.SetActive(true);
                PlayerPrefs.SetInt("camera", 1);
            }
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
        PlayerPrefs.SetInt("rate", rate);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("telefon", 1);
        PlayerPrefs.SetInt("camera", 1);
        PlayerPrefs.SetInt("mikro", 1);
        PlayerPrefs.SetInt("telefonys", 0);

    }
    public void mikro()
    {
        if (money >= 350 && telefonys == true)
        {
            
            money -= 350;
            PlayerPrefs.SetInt("money", money);
            mikroo.SetActive(false);
            PlayerPrefs.SetInt("mikro", 0);
            rate = 2;
            PlayerPrefs.SetInt("rate", rate);
            
        }
    }
    public void Panell()
    {
        isopened = !isopened;
        panel.SetActive(isopened);
    }
    public void camera1()
    {
        if (money >= 800 && telefonys == true){
            rate = 3;
            PlayerPrefs.SetInt("rate", rate);
            cameraa.SetActive(false);
            money -= 800;
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("camera", 0);
        }
    }
    public void telefon1()
    {
        if(money >= 50)
        {
            money -= 50;
            telefon.SetActive(false);
            PlayerPrefs.SetInt("telefon", 0);
            telefonys = true;
            PlayerPrefs.SetInt("telefonys", 1);
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
 