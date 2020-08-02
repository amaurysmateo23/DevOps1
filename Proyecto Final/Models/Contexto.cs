using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proyecto_Final.Models
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("Conexion")
        {
        }

        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Nominas> Nominas { get; set; }
    }
}

//    <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
//<div class="jumbotron">
//    <h1>ASP.NET</h1>
  //  <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    //<p><a href = "https://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
//</div>