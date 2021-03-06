﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureJournal2_Titel.Models
{
    public class ScriptureJournal
    {
        public int ID { get; set; }

        public string Book { get; set; }

        public int Chapter { get; set; }

        public int Verse { get; set; }

        public string Notes { get; set; }


        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
     


    }

}
