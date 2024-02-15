﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
   public class PhotoFilters
    {
        public void ApplyBrightnees(Photo photo)
        {
            Console.WriteLine("Apply Brightness.");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast.");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Apply Resize.");
        }
    }
}
