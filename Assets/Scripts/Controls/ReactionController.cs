using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReactionController : MonoBehaviour
{
    public static ReactionController ins;

    public Animator animator;
    public Button playButton;
    public AudioSource dialogueAudio;

    private bool isPlaying = false;

    void Start()
    {
        playButton.onClick.AddListener(OnPlayPressed);
    }

    void OnPlayPressed()
    {
        if (!isPlaying)
            StartCoroutine(PlayReactionSequence());
    }

    IEnumerator PlayReactionSequence()
    {
        isPlaying = true;

        dialogueAudio.Play();
        animator.SetBool("Talking", true);

       /* yield return PlayStep("Smile", 1.75f);
        yield return PlayStep("Sad", 1.75f);
        yield return PlayStep("Smile", 1.75f);
        yield return PlayStep("Sad", 1.75f);*/

        // Wait until audio completely ends
        while (dialogueAudio.isPlaying)
            yield return null;

        animator.SetBool("Talking", false);
        isPlaying = false;
    }

   /* IEnumerator PlayStep(string triggerName, float duration)
    {
        animator.SetTrigger(triggerName);
        yield return new WaitForSeconds(duration);
    }*/
}
