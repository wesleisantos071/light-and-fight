using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationController : MonoBehaviour {
    public static NavigationController instance;
    public int sceneIndexLogin = 0;
    public int sceneIndexMainMenu = 1;
    public int sceneIndexGame = 2;

    private void Awake() {
        DontDestroyOnLoad(gameObject);
        if (instance == null) {
            instance = this;
        }
    }

    public void GoToLogin() {
        SceneManager.LoadSceneAsync(sceneIndexLogin);
    }

    public void GoToMainMenu() {
        SceneManager.LoadSceneAsync(sceneIndexMainMenu);
        //if (PhotonNetwork.InRoom) {
        //    PhotonNetwork.LeaveRoom();
        //}
        //PhotonNetwork.LoadLevel("MainMenu");
    }

    public void ScheduleGoToMainMenu(int delayTime) {
        StartCoroutine(DelayedGoToMainMenuCorroutine(delayTime)); 
    }

    IEnumerator DelayedGoToMainMenuCorroutine(int delayTime) {
        yield return new WaitForSeconds(delayTime);
        GoToMainMenu();
    }

    public void GoToGame() {
        SceneManager.LoadSceneAsync(sceneIndexGame);
        //PhotonNetwork.LoadLevel("Game");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
