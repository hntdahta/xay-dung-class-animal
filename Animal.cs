﻿using System;
using System.Collections.Generic;
using System.Text;

namespace xay_dung_class_animal
{
    public abstract class Animal
    {
        protected string Weight { get; set; }
    protected string Height { get; set; }

    public Animal(string weight, string height)
    {
        this.Weight = weight;
        this.Height = height;
    }
    public abstract void PrintInfo();
}
}
