using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PuzzleManager : MonoBehaviour
{
    public TextMeshProUGUI usernameText, passwordText;
    public TMP_InputField usernameIF, passwordIF;
    public GameObject loginGO, puzzlePageGO, thankYouScreen;
    public int thankyouscreendelay = 10;
    public List<piecesScript> pieces;
    public GameObject puzzle;

    // Start is called before the first frame update
    void Start()
    {
        loginGO.SetActive(true);
        puzzlePageGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Submit()
    {
        if (usernameIF.text == "CASE_1977_MYSTERY |" && passwordIF.text == "917906")
        {
            Debug.Log("Login Successful");
            loginGO.SetActive(false);
            puzzlePageGO.SetActive(true);
            puzzle.SetActive(true);
        }
        else
        {
            loginGO.SetActive(false);
            loginGO.SetActive(true);
            if (usernameIF.text == "CASE_1977_MYSTERY |")
            {
                Debug.Log("Incorrect Password");
                passwordText.color = Color.red;
            }
            else
            {
                Debug.Log("Incorrect Username");
                usernameText.color = Color.red;
            }
            Debug.Log("Login Failed");
        }
    }

    public void CheckAllPieces()
    {
        Debug.Log("Checking");
        if (pieces.All(w => w.InRightPosition))
        {
            thankYouScreen.SetActive(true);
            StartCoroutine(RestartScene());
        }
    }

    IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(thankyouscreendelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
