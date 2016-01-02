﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nomnom.GameCode
{
    public class SpriteSheet
    {
        public int ID { get; set; }
        public string _contentName { get; set; }
        public int MaxCols { get { return cols; } }
        public int MaxRows { get { return rows; } }
        public int spriteWidth;
        public int spriteHeight;


        Texture2D _texture;
        Vector2 _position;
        int cols, rows, startX, startY;
        float scale;

        public SpriteSheet(string contentName)
        {
            _contentName = contentName;
            ID = new Random().Next(100000); // TODO: change this to something unique
        }

        public void LoadTexture(ContentManager content, int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;
            _texture = content.Load<Texture2D>(_contentName);
            spriteWidth = (int)_texture.Width / cols;
            spriteHeight = (int)_texture.Height / rows;
        }

        public void Draw(SpriteBatch app)
        {
            app.Draw(_texture, _position, new Rectangle(startX, startY, spriteWidth, spriteHeight), Color.White);
        }

        public void SetScale(float scale)
        {
            this.scale = scale;
            this.spriteWidth = (int)(this.spriteWidth * scale);
            this.spriteHeight = (int)(this.spriteHeight * scale);
        }

        public void SetCurrentSprite(int x, int y)
        {
            startX = x * spriteWidth;
            startY = y * spriteHeight;
        }

        public void SetPos(Vector2 v)
        {
            _position = v;
        }

        public float GetY()
        {
            return _position.Y;
        }

        public int GetWidth()
        {
            return spriteWidth > 0 ? spriteWidth : 1;
        }

        public int GetHeight()
        {
            return spriteHeight > 0 ? spriteHeight : 1;
        }
    }
}