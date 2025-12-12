using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public Button appleLoginButton;
    public TextMeshProUGUI errorText;

    public TMP_InputField emailInputPassword;

    //private string correctEmail = "test@apple.com";   
    private string correctPassword = "1234";         

    void Start()
    {
        errorText.gameObject.SetActive(false);
        appleLoginButton.onClick.AddListener(OnAppleLogin);

    }

    public void OnAppleLogin()
    {

        if (emailInputPassword.text == correctPassword)
        {
            SceneManager.LoadScene("CharacterScene");
        }
        else
        {
            errorText.text = "Invalid Login / Password is 1234";
            errorText.gameObject.SetActive(true);
        }
    }
}
