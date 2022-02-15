﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class Golosinas : Almacen
    {
        private List<Producto> _Golosinas;

        public Golosinas()
        {
            _Golosinas = new List<Producto>();
        }

        public override void addProducto(Producto producto)
        {
            _Golosinas.Add(producto);
        }

        public override List<Producto> getProductos()
        {
            return _Golosinas;
        }
    }
}
