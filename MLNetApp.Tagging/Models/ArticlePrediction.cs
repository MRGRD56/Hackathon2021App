﻿using Microsoft.ML.Data;

namespace MLNetApp.Tagging.Models
{
    public class ArticlePrediction
    {
        // [ColumnName("PredictedLabel")]
        public string[] Tokens { get; set; }
    }
}