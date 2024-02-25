using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMainMenu : MonoBehaviour
{

    public void PlayButton()
    {
        Debug.Log("������");
        SceneManager.LoadScene("GameSelection");
    }
    public void SettingsButton()
    {
        SceneManager.LoadScene("SettingsMenu");
        Debug.Log("���������");
    }
    public void ExitButton()
    {
        Debug.Log("�����");
        Application.Quit();
    }
}
