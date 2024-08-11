
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using UnityEngine.U2D.Animation;
using System;
using UnityEditor;
using TMPro;

public class klick : MonoBehaviour
{
    private int rate = 1;
    public int money;
    public Text anime;
    public GameObject mikroo;
    public GameObject panel;
    bool isopened;
    bool isopened2;
    public GameObject cameraa;
    public GameObject telefon;
    public GameObject nenada;

    public GameObject Faq;
    private bool rotik;
    public GameObject panel2;

    public GameObject sveta;
    public GameObject noyt;
    public GameObject vetrozachita;

    private bool telefonys;
    private bool level1 = false;

    public GameObject pomidor;

    public GameObject kazikpanel;
    public Text kaziktext;
    private int kakashhhka;
    private int kakaint;
    bool magic;


    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        rate = PlayerPrefs.GetInt("rate");

        rotik = true;
        if (PlayerPrefs.HasKey("telefonys") && PlayerPrefs.GetInt("telefonys") == 1)
        {
            telefonys = true;
        }
        else
        {
            if (PlayerPrefs.HasKey("telefonys") && PlayerPrefs.GetInt("telefonys") == 0)
            {
                telefonys = false;
            }
        }
        if (PlayerPrefs.HasKey("level") && PlayerPrefs.GetInt("level") == 1)
        {
            level1 = true;
        }
        else
        {
            if (PlayerPrefs.HasKey("level") && PlayerPrefs.GetInt("level") == 0)
            {
                level1 = false;
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
        if (PlayerPrefs.HasKey("veter") && PlayerPrefs.GetInt("veter") == 0)
        {
            vetrozachita.SetActive(false);
        }
        else
        {
            if (!PlayerPrefs.HasKey("veter"))
            {
                vetrozachita.SetActive(true);
                PlayerPrefs.SetInt("veter", 1);
            }
        }


        if (PlayerPrefs.HasKey("noyt") && PlayerPrefs.GetInt("noyt") == 0)
        {
            noyt.SetActive(false);
        }
        else
        {
            if (!PlayerPrefs.HasKey("noyt"))
            {
                noyt.SetActive(true);
                PlayerPrefs.SetInt("noyt", 1);
            }
        }


        if (PlayerPrefs.HasKey("svet") && PlayerPrefs.GetInt("svet") == 0)
        {
            sveta.SetActive(false);
        }
        else
        {
            if (!PlayerPrefs.HasKey("svet"))
            {
                sveta.SetActive(true);
                PlayerPrefs.SetInt("svet", 1);
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
        if (PlayerPrefs.GetInt("camera") == 0 && PlayerPrefs.GetInt("mikro") == 0)
        {
            level1 = true;
            PlayerPrefs.SetInt("level", 1);
        }
    }
    public void aboba()
    {
        money = 0;
        rate = 1;
        cameraa.SetActive(true);
        mikroo.SetActive(true);
        telefon.SetActive(true);
        vetrozachita.SetActive(true);
        noyt.SetActive(true);
        sveta.SetActive(true);
        level1 = false;
        PlayerPrefs.SetInt("rate", rate);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("telefon", 1);
        PlayerPrefs.SetInt("camera", 1);
        PlayerPrefs.SetInt("mikro", 1);
        PlayerPrefs.SetInt("telefonys", 0);
        PlayerPrefs.SetInt("veter", 1);
        PlayerPrefs.SetInt("level", 0);
        PlayerPrefs.SetInt("noyt", 1);
        PlayerPrefs.SetInt("svet", 1);

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
        nenada.SetActive(true);
    }
    public void camera1()
    {
        if (money >= 800 && telefonys == true)
        {
            rate = 3;
            PlayerPrefs.SetInt("rate", rate);
            cameraa.SetActive(false);
            money -= 800;
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("camera", 0);
            PlayerPrefs.SetInt("money", money);
        }
    }
    public void telefon1()
    {
        if (money >= 50)
        {
            money -= 50;
            telefon.SetActive(false);
            PlayerPrefs.SetInt("telefon", 0);
            telefonys = true;
            PlayerPrefs.SetInt("telefonys", 1);
            PlayerPrefs.SetInt("money", money);
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
        }
        else if (rotik)
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
    public void next()
    {
        isopened = !isopened;
        isopened2 = !isopened2;
        panel.SetActive(isopened);
        panel2.SetActive(isopened2);
    }
    public void veter()
    {
        if (money >= 900 && telefonys == true && level1 == true)
        {
            rate = 4;
            PlayerPrefs.SetInt("rate", rate);
            vetrozachita.SetActive(false);
            money -= 900;
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("veter", 0);
            PlayerPrefs.SetInt("money", money);

        }
    }
    public void komp()
    {
        if (money >= 3000 && telefonys == true && level1 == true)
        {
            rate = 6;
            PlayerPrefs.SetInt("rate", rate);
            noyt.SetActive(false);
            money -= 3000;
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("noyt", 0);
            PlayerPrefs.SetInt("money", money);

        }
        if (level1 == false && money >= 3000)
        {

            pomidor.SetActive(true);
        }

    }
    public void svet()
    {
        if (money >= 1500 && telefonys == true && level1 == true)
        {
            rate = 5;
            PlayerPrefs.SetInt("rate", rate);
            sveta.SetActive(false);
            money -= 1500;
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("svet", 0);
            PlayerPrefs.SetInt("money", money);

        }
    }
    public void krestik2()
    {
        pomidor.SetActive(false);
        kazikpanel.SetActive(false);
    }
    public void kazik()
    {
        kazikpanel.SetActive(true);
    }
    public void kazikrandom()
    {
        magic = (UnityEngine.Random.Range(0, 2) == 0);
        kaziktext.text = magic.ToString();
    }
    
   
    
    
}