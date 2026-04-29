using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Golf
{
    public class GamePlayState : GameState
    {
        public LevelController1 levelController1;
        public PlayerContr playerContr;
        public GameState gameOverState;
        public TMP_Text scoreText;


        protected override void OnEnable()
        {
            base.OnEnable();

            levelController1.enabled = true;
            playerContr.enabled = true;

            GameEvents.onCollisionStones += OnGameOver;
            GameEvents.onStickHit += OnStickHit;
            OnStickHit();
        }

        private void OnStickHit()
        {
            scoreText.text = $" Score: {levelController1.score}";
        }

        private void OnGameOver()
        {
            Exit();
            gameOverState.Enter();
        }
        protected override void OnDisable()
        {
            base.OnDisable();

            GameEvents.onCollisionStones -= OnGameOver;

            levelController1.enabled = false;
            playerContr.enabled = false;
        }
    }
}
