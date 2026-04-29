using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameOverState : GameState
    {
        public GameState mainMenuState;
        public LevelController1 levelController1;

        public void Restart()
        {
            levelController1.ClearStone();

            Exit();
            mainMenuState.Enter();
        }
    }
}
