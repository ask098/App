using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;
using Wayuu.Services;
using System.Linq;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Wayuu.DAL
{
    public class WayuuRepository : WayuuRepositoryGeneric, IWayuuRepository
    {
        public WayuuRepository(bool isUnitOfWork = false) : base(new WayuuContext(), isUnitOfWork)
        {
        }

        public override void HandleException(Exception e)
        {
            //Logica para la captura de Errores
        }
    }
}
