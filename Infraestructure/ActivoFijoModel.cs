using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class ActivoFijoModel
    {
        private ActivoFijo[] ActivosFijos;
        public ActivoFijo GetActivoFijo(int i)
        {
            return ActivosFijos[i];
        }
        public void Add(ActivoFijo af)
        {
            if (ActivosFijos == null)
            {
                ActivosFijos = new ActivoFijo[1];
                ActivosFijos[0] = af;
                return;
            }
            ActivoFijo[] tmp = new ActivoFijo[ActivosFijos.Length + 1];
            Array.Copy(ActivosFijos, tmp, ActivosFijos.Length);
            tmp[tmp.Length - 1] = af;
            ActivosFijos = tmp;
        }
        public int GetLastId()
        {
            try
            {
                return (ActivosFijos == null) ? 0 : ActivosFijos.Length-1;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
    }
}
