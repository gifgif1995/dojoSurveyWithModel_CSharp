using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace dojoSurveyWithModels.Models
{
    public class Survey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string FavStack { get; set; }
        public string Comment { get; set; }
    }
}