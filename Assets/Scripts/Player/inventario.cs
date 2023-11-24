using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class inventario : MonoBehaviour
{
    [Header("Items")]
    public bool mapa;
    public bool pastel;
    public bool botiquin;
    public bool cuchillo;
    public bool espada;
    public bool pistola;
    public bool llaveAzul;
    public bool llaveVerde;
    public bool llaveFinal;
    [Header("Items Icons")]
    public Image mapaIcon;
    public Image pastelIcon;
    public Image botiquinIcon;
    public Image cuchilloIcon;
    public Image espadaIcon;
    public Image pistolaIcon;
    public Image llaveAzulIcon;
    public Image llaveVerdeIcon;
    public Image llaveFinalIcon;
    [Header("Audio")]
    private AudioSource audioSource;
    private bool soundPlayed = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SetItemIconAlpha(mapaIcon, mapa ? 1f : 0f);
        SetItemIconAlpha(pastelIcon, pastel ? 1f : 0f);
        SetItemIconAlpha(botiquinIcon, botiquin ? 1f : 0f);
        SetItemIconAlpha(cuchilloIcon, cuchillo ? 1f : 0f);
        SetItemIconAlpha(espadaIcon, espada ? 1f : 0f);
        SetItemIconAlpha(pistolaIcon, pistola ? 1f : 0f);
        SetItemIconAlpha(llaveAzulIcon, llaveAzul ? 1f : 0f);
        SetItemIconAlpha(llaveVerdeIcon, llaveVerde ? 1f : 0f);
        SetItemIconAlpha(llaveFinalIcon, llaveFinal ? 1f : 0f);
    }

    void Update()
    {
        SetItemIconAlpha(mapaIcon, mapa ? 1f : 0f);
        SetItemIconAlpha(pastelIcon, pastel ? 1f : 0f);
        SetItemIconAlpha(botiquinIcon, botiquin ? 1f : 0f);
        SetItemIconAlpha(cuchilloIcon, cuchillo ? 1f : 0f);
        SetItemIconAlpha(espadaIcon, espada ? 1f : 0f);
        SetItemIconAlpha(pistolaIcon, pistola ? 1f : 0f);
        SetItemIconAlpha(llaveAzulIcon, llaveAzul ? 1f : 0f);
        SetItemIconAlpha(llaveVerdeIcon, llaveVerde ? 1f : 0f);
        SetItemIconAlpha(llaveFinalIcon, llaveFinal ? 1f : 0f);
    }
    void SetItemIconAlpha(Image icon, float alpha)
    {
        Color iconColor = icon.color;
        
        if (iconColor.a != alpha && alpha == 1f)
        {
            PlaySound();
        }
        iconColor.a = alpha;
        icon.color = iconColor;
    }
    void PlaySound()
    {
        audioSource.Play();
        // soundPlayed = true;
    }
}
