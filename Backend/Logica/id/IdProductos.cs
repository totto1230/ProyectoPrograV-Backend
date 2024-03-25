using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForoULAtina
{
    public class IdProductos
    {
        int[] idFrontendA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int[] idBackendA = { 25000, 25125, 25250, 25375, 25500, 25625, 25750, 25875, 26000, 26125, 26250, 26375, 26500, 26625, 26750 };


        public int matchIDs(int idFrontend)
        {
            int idBackend = 0, i = 0, position = 0;

            while (idBackendA.Length > i)
            {
                if (idFrontendA[i] == idFrontend)
                {
                    position = i;
                    break;
                }
                i++;
            }
            idBackend = idBackendA[position];

            return idBackend;
        }

    }

}
