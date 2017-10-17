﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
  public  class OutsourcingAD
    {
        SADDEXEntities context;

        public OutsourcingAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(OUTSOURCING_S obj)
        {
            this.context.OUTSOURCING_S.Add(obj);
        }

        public void EliminarAD(OUTSOURCING_S obj)
        {
            var outsourcing = context.OUTSOURCING_S.Where(com => com.ID_OUTSOURCING == obj.ID_OUTSOURCING).FirstOrDefault();
            if (outsourcing != null)
            {
                this.context.OUTSOURCING_S.Remove(outsourcing);
            }
        }

        public void ModificarAD(OUTSOURCING_S obj)
        {
            var outsourcing = context.OUTSOURCING_S.Where(com => com.ID_OUTSOURCING == obj.ID_OUTSOURCING).FirstOrDefault();
            if (outsourcing != null)
            {
                outsourcing.FK_USUARIO = obj.FK_USUARIO;
                outsourcing.FK_LISTA_OUTSOURCING = obj.FK_LISTA_OUTSOURCING;
                outsourcing.FK_OBRA = obj.FK_OBRA;
                outsourcing.FECHA_CONTRATACION = obj.FECHA_CONTRATACION;
            }
        }

        public IEnumerable<OUTSOURCING_S> obtenerListaAD()
        {
            return this.context.OUTSOURCING_S;
        }

        public OUTSOURCING_S obtenerPorID_AD(int id)
        {
            return this.context.OUTSOURCING_S.Where(com => com.ID_OUTSOURCING == id).FirstOrDefault();
        }
    }
}
