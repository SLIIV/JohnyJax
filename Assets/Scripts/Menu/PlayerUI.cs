using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

    [SerializeField] private GameObject[] _healthObjects = new GameObject[CharacterStats.MAX_HEALTH];
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private Text _ammoCount;

    private void Start() 
    {
        EnemyAttack.OnHitted.AddListener(() => TakeHealth());
        GameState.OnPause.AddListener(() => OpenPause());
        CharacterStats.OnAmmoChanged.AddListener(() => UpdateAmmoUI());
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) // заменить на статическое поле из класса настроек
        {
            GameState.OnPause.Invoke();
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        GameSceneManager.LoadMainMenu();
    }

    public void Continue()
    {
        ClosePause();
    }

    private void OpenPause()
    {
        if(!GameState.IsPause)
        {
            _pauseMenu.SetActive(true);
            CameraStates.PauseCamera();
            GameState.IsPause = true;
        }
    }
    
    private void ClosePause()
    {

        _pauseMenu.SetActive(false);
        CameraStates.UnpauseCamera();
        GameState.IsPause = false;
    }

    private void TakeHealth()
    {
        _healthObjects[CharacterStats.CurrentHealth].SetActive(false);
    }

    private void UpdateAmmoUI()
    {
        _ammoCount.text = CharacterStats.CurrentAmmo.ToString();
    }

    private void OnDisable() 
    {
        EnemyAttack.OnHitted.RemoveListener(() => TakeHealth());
    }
    

}
