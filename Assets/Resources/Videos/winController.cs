using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class winController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button boton;
    void Start()
    {
        boton.interactable = false;
        videoPlayer.loopPointReached += OnVideoEnd;
    }


    void OnVideoEnd(VideoPlayer vp)
    {
        boton.interactable = true;
    }
}
