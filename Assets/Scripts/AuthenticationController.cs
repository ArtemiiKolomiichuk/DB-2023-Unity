using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AuthenticationController : MonoBehaviour
{
    [SerializeField] private TMP_InputField loginInput;
    [SerializeField] private TMP_InputField passwordInput;

    [SerializeField] private Button loginButton;

    private void Start()
    {
        loginButton.onClick.AddListener(() => Login());
    }

    private void Login()
    {
        //TODO: Add authentication logic
        //TODO: Screen size
        Screen.SetResolution(1366, 768, FullScreenMode.Windowed);
        //~ExceptionHandler.ShowMessage("No user", "Login is incorrect");
        AccessController.isManager = true;
        PersistentData.userId = 1;
        SceneManager.LoadScene("Menu-Manager");
    }
}
