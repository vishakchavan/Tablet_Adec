using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class KillerAnimator : MonoBehaviour
{
    public Image card, tick;
    public Color pink, blue;
    public GameManager gameManager;

    public void Correct(bool only)
    {
        card.DOColor(blue, 0.5f);
        tick.transform.DOScale(1, 1f).SetEase(Ease.OutBounce);
        if (only)
            gameManager.GoToSecondQuestion();
    }

    public void CorrectTwo(bool only)
    {
        card.DOColor(blue, 0.5f);
        tick.transform.DOScale(1, 1f).SetEase(Ease.OutBounce);
        if (only)
            gameManager.SecondCorrect();
    }

    public void Wrong()
    {
        card.DOColor(pink, 0.5f);
        tick.transform.DOScale(1, 1f).SetEase(Ease.OutBounce);
        gameManager.FirstWrong();
    }

}
