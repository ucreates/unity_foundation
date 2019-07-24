//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Core.Scene {
public sealed class Director {
    private static Director instance {
        get;
        set;
    }
    public string previousSceneName {
        get;
        set;
    }
    private Director() {
        this.previousSceneName = string.Empty;
    }
    public static Director GetInstance() {
        if (null == Director.instance) {
            Director.instance = new Director();
        }
        return Director.instance;
    }
    public void Translate(int level) {
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        this.previousSceneName = scene.name;
        SceneManager.LoadScene(level);
        return;
    }
    public void Translate(string sceneName) {
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        this.previousSceneName = scene.name;
        SceneManager.LoadScene(sceneName);
        return;
    }
    public IEnumerator Translate(int level, float waitForSeconds) {
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        this.previousSceneName = scene.name;
        yield return new WaitForSeconds(waitForSeconds);
        SceneManager.LoadScene(level);
        yield return null;
    }
    public IEnumerator Translate(string sceneName, float waitForSeconds) {
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        this.previousSceneName = scene.name;
        yield return new WaitForSeconds(waitForSeconds);
        SceneManager.LoadScene(sceneName);
        yield return null;
    }
    public bool HasPreviewScene() {
        return (false == string.IsNullOrEmpty(this.previousSceneName));
    }
}
}
