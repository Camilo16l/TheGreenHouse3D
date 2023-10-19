using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class investigate : MonoBehaviour
{
    public string nombreDelVideo = "Investigate.mp4";
    private VideoPlayer videoPlayer;
    public Canvas hudCanvas;
    void Start()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();

        videoPlayer.playOnAwake = false;
        videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
        videoPlayer.targetCamera = Camera.main;
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = Resources.Load<VideoClip>("Videos/" + nombreDelVideo);
        videoPlayer.url = System.IO.Path.Combine("Assets/Resources/Videos", nombreDelVideo);        
        videoPlayer.prepareCompleted += VideoPreparado;
        videoPlayer.loopPointReached += VideoTerminado;

        videoPlayer.Prepare();
    }

        void VideoPreparado(VideoPlayer vp)
    {
        hudCanvas.enabled = false;
        videoPlayer.Play();
    }

    void VideoTerminado(VideoPlayer vp)
    {
        hudCanvas.enabled = true;
        gameObject.SetActive(false);
    }
}
