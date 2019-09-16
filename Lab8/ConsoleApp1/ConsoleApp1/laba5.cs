﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Developer//разработчик
    {
        public Developer(string namedev)
        {
            this.Namedev = namedev;
        }
        private string namedev;
        public string Namedev
        {
            get
            {
                return namedev;
            }
            set
            {
                namedev = value;
            }
        }
        public virtual void infodev()
        {
            Console.WriteLine("Ваш покорный слуга" + namedev);
        }
        public override string ToString()
        {
            return base.ToString() + " Имя автора " + namedev;
        }

    }
    class PO : Developer
    {
        private string name;
        public PO(string name, string namedev) : base(namedev)
        {
            this.Name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Вы ввели пустое значение");
                }
                else
                {
                    name = value;
                }
            }
        }
   
    }
}
