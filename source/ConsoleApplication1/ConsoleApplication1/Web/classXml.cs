using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1.Web
{
    class classXml
    {
        public void main()
        {
            
        }

        
        public void test1()
        {
            string xmlstring = "";
            XmlWriter writer = new XmlTextWriter(Console.Out);
            writer.WriteStartElement("x", "root", "123");
            writer.WriteStartElement("item");
            writer.WriteEndElement();
            writer.WriteEndElement();

            Console.WriteLine(xmlstring);
        }

        
        
        public void test2()
        {
            StringBuilder output = new StringBuilder();
            string xmlstring = @"<?xml version='1.0'?>
                        <!-- This is a sample XML document -->
                        <Items>
                            <Item>test with a child element <more/> stuff</Item>
                        </Items>";

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlstring)))
            {
                XmlWriterSettings ws = new XmlWriterSettings();
                ws.Indent = true;

                using (XmlWriter writer = XmlWriter.Create(output, ws))
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                writer.WriteStartElement(reader.Name);
                                break;

                            case XmlNodeType.Text:
                                writer.WriteString(reader.Value);
                                break;

                            case XmlNodeType.XmlDeclaration:
                            case XmlNodeType.ProcessingInstruction:
                                writer.WriteProcessingInstruction(reader.Name, reader.Value);
                                break;

                            case XmlNodeType.Comment:
                                writer.WriteComment(reader.Value);
                                break;

                            case XmlNodeType.EndElement:
                                writer.WriteFullEndElement();
                                break;
                        }
                    }
                }
            }

            Console.WriteLine(output.ToString());
            
        }

        public void test3()
        {
            StringBuilder output = new StringBuilder();

            string xmlstring =
                @"<bookstore>
                    <book genre='autobiography' publicationdate='1981-03-22' ISBN='1-861003-11-0'>
                        <title>The Autobiography of Benjamin Franklin</title>
                        <author>
                            <first-name>Benjamin</first-name>
                            <last-name>Franklin</last-name>
                        </author>
                        <price>8.99</price>
                    </book>
                </bookstore>";

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlstring)))
            {
                reader.ReadToFollowing("book");
                reader.MoveToFirstAttribute();
                string genre = reader.Value;
                output.AppendLine("the genre value: " + genre);

                reader.ReadToFollowing("title");
                output.AppendLine("Content of the title element: " + reader.ReadElementContentAsString());
            }

            Console.WriteLine(output.ToString());
        }
    }
}
