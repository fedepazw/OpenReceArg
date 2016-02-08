using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Logica
{
    public class XML_FECAESolicitar
    {
        public string Xml_StrFECAESolicitar_Peticion_Template = "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:ar=\"http://ar.gov.afip.dif.FEV1/\"><ar:FECAESolicitar><ar:Auth><ar:Token></ar:Token><ar:Sign></ar:Sign><ar:Cuit></ar:Cuit></ar:Auth></ar:FECAESolicitar></soapenv:Envelope>";

        /// <summary>
        /// Genera un XML con la información del comprobante/lote que desea autorizar
        /// </summary>
        /// <param name="pCertificado_Peticion">Certificado  del Ente Externo (EE)</param>
        /// <returns></returns>
        public XmlDocument Generar_XML_FECAE()
        {
            XmlDocument Xml_FECAESolicitar_Peticion = new XmlDocument();            

            //Atributos XML
            XmlNode xmlNodo_Token;
            XmlNode xmlNodo_Firma;
            XmlNode xmlNodo_Cuit;            

            try
            {
                Xml_FECAESolicitar_Peticion.LoadXml(Xml_StrFECAESolicitar_Peticion_Template);
                XmlNamespaceManager ns = new XmlNamespaceManager(Xml_FECAESolicitar_Peticion.NameTable);
                ns.AddNamespace("ar", "http://ar.gov.afip.dif.FEV1/");
                xmlNodo_Token = Xml_FECAESolicitar_Peticion.SelectSingleNode("//ar:Token",ns);
                xmlNodo_Firma = Xml_FECAESolicitar_Peticion.SelectSingleNode("//ar:Sign",ns);
                xmlNodo_Cuit = Xml_FECAESolicitar_Peticion.SelectSingleNode("//ar:Cuit",ns);

                xmlNodo_Token.InnerText = "TestToken";
                xmlNodo_Firma.InnerText = "TestFirma";
                xmlNodo_Cuit.InnerText = "2033554240";
                InvocarWS();
                
            }
            catch (Exception exGenerandoXMLFECAE)
            {
                throw new Exception("ERROR: Clase: Logica.XML_FECAESolicitar. Método: Generar_XML_FECAE. Descripcion:" + exGenerandoXMLFECAE.Message);
            }

            return Xml_FECAESolicitar_Peticion;
        }

        public void InvocarWS()
        {
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FECAESolicitar
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx
             */
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.FECAERequest CAERequest = new ar.gov.afip.wswhomo.FECAERequest();
            ar.gov.afip.wswhomo.FECAEResponse respuesta = new ar.gov.afip.wswhomo.FECAEResponse();

            ar.gov.afip.wswhomo.Service j = new ar.gov.afip.wswhomo.Service();
            respuesta = j.FECAESolicitar(autorizacion, CAERequest);

            int i=0;

            i++;
        }

            


    }
}
