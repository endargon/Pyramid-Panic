﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class LevelNextLevel : ILevel
    {
        private Level level;
        private Image overlay;
        private int pauseTime = 1;
        private float timer = 0;
        private int index = -1;
        private string removeType;

        public string RemoveType
        {
            get { return this.removeType; }
            set { this.removeType = value; }
        }

        public int Index
        {
            set { this.index = value; }
        }

        public LevelNextLevel(Level level)
        {
            this.level = level;
            this.overlay = new Image(this.level.Game, new Vector2(0,0), @"PlaySceneAssets/overlay/overlay");
        }
        public void Update(GameTime gameTime)
        {
            this.timer += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (timer > pauseTime)
            {
                if (PlayScene.LevelNumber == 10)
                {
                }
                else
                {

                    PlayScene.LevelNumber += 1;
                    Score.MaxPointDoors = 0;
                    this.level.Game.GameState = new PlayScene(this.level.Game);
                }
                


            }
        }

        public void Draw(GameTime gameTime)
        {
            this.overlay.Draw(gameTime);
        }
    }
}
