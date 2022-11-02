    using System;
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Linq;
    using laba_4;
    using Laba13;

    namespace laba_13
    {
        class Program
        {
            static void Main(string[] args)
            {
                FirstTask();

            }

            public static void FirstTask()
            {
                var ball = new Ball("Fedya");
            
                //Binary
                Ball containerForBinary = new Ball();
                Serializer.SerializeToBinary(ball);
                Serializer.DeserializeFromBinary(ref containerForBinary);
                Console.WriteLine($"(from .bin) {containerForBinary.ToString()} {containerForBinary.FieldToBeNotSeriazable}" );
            
                //SOAP
                Ball containerForSOAP = new Ball();
                Serializer.SerializeToSoap(ball);
                Serializer.DeserializeFromSoap(ref containerForSOAP);
                Console.WriteLine($"(from .soap) {containerForSOAP.ToString()} {containerForSOAP.FieldToBeNotSeriazable}");
            
                //XML
                Ball containerForXML = new Ball();
                Serializer.SerializeToXml(ball);
                Serializer.DeserializefromXml(ref containerForXML);
                Console.WriteLine($"(from .xml) {containerForXML.ToString()} {containerForBinary.FieldToBeNotSeriazable}");
            
                //JSON
                Ball containerForJSON = new Ball();
                Serializer.SerializeToJson(ball);
                Serializer.DeserializeFromJson(ref containerForJSON);
                Console.WriteLine($"(from .json) {containerForJSON.ToString()} {containerForJSON.FieldToBeNotSeriazable}");
                
            }
        }
    }
