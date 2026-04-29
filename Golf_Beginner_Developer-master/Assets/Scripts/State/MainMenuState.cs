using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Golf
{
    public class MainMenuState : GameState
    {
        public GameState gamePlayState;
        public TMP_Text scoreText;
        public LevelController1 LevelController1;

        public void PlayGame()
        {
            Exit();
            gamePlayState.Enter();
        }
        protected override void OnEnable()
        {
            base.OnEnable();

            scoreText.text = $" HScore : {LevelController1.hightScore}";
        }
    }
}
