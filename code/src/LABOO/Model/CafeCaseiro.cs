﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LABOO.Model
{
    public class CafeCaseiro : Cafe
    {
        public override string ModoDeServir()
        {
            return "Na xicara";
        }

        public sealed override void Formula()
        {
            string formula = "";
        }
    }
}
