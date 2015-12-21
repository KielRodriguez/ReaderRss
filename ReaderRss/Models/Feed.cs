using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReaderRss.Models
{
    public class Feed
    {
        private string titulo;
        private string descripcion;
        private string link;
        private string lenguaje;
        private string fechaCreacion;
        private List<ItemFeed> items;

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

        public string Lenguaje
        {
            get
            {
                return lenguaje;
            }

            set
            {
                lenguaje = value;
            }
        }

        public string FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }

        public List<ItemFeed> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public Feed()
        {
            this.Items = new List<ItemFeed>();
        }
    }
}