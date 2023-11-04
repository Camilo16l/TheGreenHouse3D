using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class transition : MonoBehaviour
{
    public Image transitionImage;
    public float transitionDuration = 1.0f;
    private CanvasGroup canvasGroup;
    private bool isTransitioning = false;
    void Start()
    {
        canvasGroup = transitionImage.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
    }

        public void StartTransition()
    {
        if (!isTransitioning)
        {
            isTransitioning = true;
            StartCoroutine(TransitionCoroutine());
        }
    }
        private IEnumerator TransitionCoroutine()
    {
        float timer = 0f;

        while (timer < transitionDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, timer / transitionDuration);
            canvasGroup.alpha = alpha;
            timer += Time.deltaTime;
            yield return null;
        }

        canvasGroup.alpha = 1f; // Asegúrate de que la imagen sea completamente opaca al final de la transición
        isTransitioning = false;
    }
        public void EndTransition()
    {
        if (!isTransitioning)
        {
            isTransitioning = true;
            StartCoroutine(ReverseTransitionCoroutine());
        }
    }
        private IEnumerator ReverseTransitionCoroutine()
    {
        float timer = 0f;

        while (timer < transitionDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, timer / transitionDuration);
            canvasGroup.alpha = alpha;
            timer += Time.deltaTime;
            yield return null;
        }

        canvasGroup.alpha = 0f; // Asegúrate de que la imagen sea completamente transparente al final de la transición
        isTransitioning = false;
    }
}
