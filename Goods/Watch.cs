﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    sealed partial class Watch : Goods
    {
        public Watch(string arg_name, int arg_amount, int arg_price, string arg_brand, int arg_type, int arg_mass) => (name, amount, price, brand, type, mass) = (arg_name, arg_amount, arg_price, arg_brand, (Type)arg_type, arg_mass);

        public override string ToString()
        {
            return $"{amount} of {type} {brand} {name}, {price}$ each.";
        }
    }
}
