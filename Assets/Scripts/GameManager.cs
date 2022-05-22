using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int RestartDelay = 5;
    public GameObject startPanelGO, firstQuestionGO, secondQuestionGO, wrongAnswerGO, correctAnswerGO;

    public List<GameObject> firstQButs;


    public delegate IEnumerator RunAfterDelay(int delay);
    RunAfterDelay rundel;
    public static IEnumerator DelayCoroutine(int delay)
    {
        yield return new WaitForSeconds(delay);

    }



    public void StartGame()
    {
        StartCoroutine(StartingGame());
        startPanelGO.SetActive(false);
        firstQuestionGO.SetActive(true);
    }

    IEnumerator StartingGame()
    {
        yield return new WaitForSeconds(0.25f);
        foreach (var item in firstQButs)
        {
            item.SetActive(true);
            yield return new WaitForSeconds(0.09f);
        }
    }
    public void GoToSecondQuestion()
    {
        StartCoroutine(FirstCorrect());
    }
    IEnumerator FirstCorrect()
    {
        yield return new WaitForSeconds(2);
        firstQuestionGO.SetActive(false);
        secondQuestionGO.SetActive(true);

    }

    public void FirstWrong()
    {
        StartCoroutine(FirstWrongDelay());
    }

    IEnumerator FirstWrongDelay()
    {
        yield return new WaitForSeconds(2);
        firstQuestionGO.SetActive(false);
        wrongAnswerGO.SetActive(true);
        StartCoroutine(RestartGame());

    }

    public void SecondCorrect()
    {
        StartCoroutine(SecondCorrectDelay());
    }

    IEnumerator SecondCorrectDelay()
    {
        yield return new WaitForSeconds(2);
        secondQuestionGO.SetActive(false);
        correctAnswerGO.SetActive(true);
        StartCoroutine(RestartGame());
    }
    public void SecondWrong()
    {
        StartCoroutine(SecondWrongDelay());
    }

    IEnumerator SecondWrongDelay()
    {
        yield return new WaitForSeconds(2);
        secondQuestionGO.SetActive(false);
        wrongAnswerGO.SetActive(true);
        StartCoroutine(RestartGame());
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(RestartDelay);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }


}
