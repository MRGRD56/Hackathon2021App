﻿namespace MLNetApp.Shared.Models
{
    public class Article
    {
        public string Text { get; set; }

        public Article()
        {
            
        }
        
        public Article(string text)
        {
            Text = text;
        }
    }
}