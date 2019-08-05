﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BonusLab_16
{
    class Car
    {
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
        }

        private string make;
        public string Make
        {
            get
            {
                return make;
            }
        }


        private string model;
        public string Model
        {
            get
            {
                return model;
            }
        }

        //private double price; 
        //public double Price{get{return price;}}

        public double Price { get; set; }

        public Car()
        {
            this.year = 2007;
            this.make = "Chrysler";
            this.model = "Pacifica";
            this.Price = 3500;
        }

        public Car(int year, string make, string model, double price)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{this.Make}\t{this.Model}\t{this.Year}\t{this.Price}";
        }

    }
}