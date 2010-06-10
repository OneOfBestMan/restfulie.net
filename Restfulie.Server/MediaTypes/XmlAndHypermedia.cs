﻿using Restfulie.Server.Marshalling;
using Restfulie.Server.Marshalling.Serializers;
using Restfulie.Server.Marshalling.Serializers.XmlAndHypermedia;
using Restfulie.Server.Marshalling.UrlGenerators;
using Restfulie.Server.Unmarshalling;
using Restfulie.Server.Unmarshalling.Deserializers;
using Restfulie.Server.Unmarshalling.Deserializers.Xml;

namespace Restfulie.Server.MediaTypes
{
    public class XmlAndHypermedia : IMediaType
    {
        public IResourceSerializer Serializer { get; set; }
        public IHypermediaInserter Hypermedia { get; set; }
        public IResourceDeserializer Deserializer { get; set; }

        public XmlAndHypermedia()
        {
            Serializer = new XmlSerializer();
            Hypermedia = new XmlHypermediaInserter();
            Deserializer = new XmlDeserializer();
        }

        public string[] Synonyms
        {
            get { return new[] {"application/xml", "text/xml" }; }
        }

        public IResourceMarshaller Marshaller
        {
            get
            {
                return
                    new RestfulieMarshaller(new Relations(new AspNetMvcUrlGenerator()),
                                            Serializer,
                                            Hypermedia);
            }
        }

        public IResourceUnmarshaller Unmarshaller
        {
            get { return new RestfulieUnmarshaller(Deserializer); }
        }
    }
}
