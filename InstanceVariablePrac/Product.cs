﻿namespace InstanceVariablePrac
{
    class Product
    {
        public static string origin = "한국";
        public string name = "default";
        public int price = 0;

        public override string ToString()
        {
            return "이름 : " + this.name + " / 가격 : " + this.price;
        }
    }
}