using TMPro;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public TextMeshProUGUI usernameText, passwordText;
    public TMP_InputField usernameIF, passwordIF;
    public GameObject loginGO, puzzlePageGO;


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
}
