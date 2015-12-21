using ReaderRss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace ReaderRss.Services
{
    public class ReadFeedService
    {
        private XmlTextReader rssReader;
        private XmlDocument rssDoc;
        private XmlNode nodeRss;
        private XmlNode nodeChannel;
        private XmlNode nodeItem;

        public void consultaFeedRss(Feed model)
        {
            ItemFeed itemFeed;

            rssReader = new XmlTextReader(model.Link);
            rssDoc = new XmlDocument();
            rssDoc.Load(rssReader);


            foreach(XmlNode rss in rssDoc.ChildNodes)
                if (rss.Name == "rss")
                    this.nodeRss = rss;

            if (this.nodeRss == null)
                throw new InvalidOperationException("No fue posible consultar nodo raiz");

            foreach (XmlNode channel in nodeRss.ChildNodes)
                if (channel.Name == "channel")
                    this.nodeChannel = channel;

            if (this.nodeChannel == null)
                throw new InvalidOperationException("No fue posible consultar el canal");

            foreach (XmlNode item in this.nodeChannel.ChildNodes)
                if(item.Name == "item")
                {
                    this.nodeItem = item;

                    if (this.nodeItem != null)
                    {
                        itemFeed = new ItemFeed();
                        itemFeed.Titulo = this.nodeItem["title"].InnerText;
                        itemFeed.Link = this.nodeItem["link"].InnerText;
                        itemFeed.FechaPublicacion = this.nodeItem["pubDate"].InnerText;
                        itemFeed.FechaPublicacion = this.nodeItem["description"].InnerText;
                        model.Items.Add(itemFeed);

                    }

                }
        }
    }
}