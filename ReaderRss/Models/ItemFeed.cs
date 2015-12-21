using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReaderRss.Models
{
    public class ItemFeed
    {
        private string titulo;
        private string link;
        private string fechaPublicacion;
        private string descripcion;

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Link
        {
            get
            {
                return link;
            }

            set
            {
                link = value;
            }
        }

        public string FechaPublicacion
        {
            get
            {
                return fechaPublicacion;
            }

            set
            {
                fechaPublicacion = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
    }
}