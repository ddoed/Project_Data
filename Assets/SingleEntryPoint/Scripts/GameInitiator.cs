using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;

public class GameInitiator : MonoBehaviour
{
    [SerializeField] private Light _mainLight;
    [SerializeField] private T_EnemySpawner _EnemySpawner;
    [SerializeField] private EventSystem _EventSystem;
    [SerializeField] private T_LevelManager _LevelManager;
    [SerializeField] private T_LevelUI _LevelUI;
    [SerializeField] private T_Loading _Loading;
    [SerializeField] private T_Player _Player;
    [SerializeField] private Camera _Camera;



    private async void Start()
    {
        BindObjects();

        using (var loadingScreenDispoable = new ShowLoadingScreenDisposable(_Loading))
        {
            loadingScreenDispoable.SetLoadingPercent(0);
            await InitializeObjects();
            loadingScreenDispoable.SetLoadingPercent(0.33f);
            await CreateObjects();
            loadingScreenDispoable.SetLoadingPercent(0.66f);
            await PrepareGame();
            loadingScreenDispoable.SetLoadingPercent(1f);
        }

        BeginGame();
    }

    private void BeginGame()
    {
        
    }

    private async UniTask InitializeObjects()
    {
        // Initialize, Enable

        await WaitForSecondsAsync(2);
    }

    private async UniTask CreateObjects()
    {
        _Player = Instantiate(_Player);
        _LevelUI = Instantiate(_LevelUI);
        // enemySpawner
        await WaitForSecondsAsync(2);
    }

    private async UniTask PrepareGame()
    {
        // 플레이어 시작위치 세팅, 무기 세팅 ... Set
        // enemy -> player 주변으로 이동

        await WaitForSecondsAsync(2);
    }

    private void BindObjects()
    {
        _mainLight = Instantiate(_mainLight);
        _EnemySpawner = Instantiate(_EnemySpawner);
        _EventSystem = Instantiate(_EventSystem);
        _LevelManager = Instantiate(_LevelManager);
        
        _Loading = Instantiate(_Loading);
        
        _Camera = Instantiate(_Camera);
    }

    private async UniTask WaitForSecondsAsync(float seconds)
    {
        await UniTask.Delay((int)(seconds*1000));
    }
}
