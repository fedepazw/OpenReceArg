using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace Logica
{
    public class CertificadosX509
    {

        /// <summary> 
        /// Lee el Certificado desde el archivo abriendolo con la password
        /// </summary> 
        /// <returns>Un objeto certificado X509</returns> 
        /// <remarks></remarks> 
        public X509Certificate2 ObtenerCertificadoDesdeArchivo()
        {
            Entidades.Configuracion_Certificado objEntidadesConf_Certificado = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Certificado = new Logica.Configuracion_Certificado();
            SecureString passwordCertificadoPFX;

            objEntidadesConf_Certificado = objLogicaConf_Certificado.TraerConfiguracion();
            passwordCertificadoPFX = ConvertirPasswordSecureString(objEntidadesConf_Certificado.PasswordPFX);

            //Se instancia un objeto Certificado
            X509Certificate2 objCertificado = new X509Certificate2();
            
            try
            {
                //Se importa al objeto certificado el archivo leido abriendolo con la password
                objCertificado.Import(Microsoft.VisualBasic.FileIO.FileSystem.ReadAllBytes(objEntidadesConf_Certificado.ArchivoCertificadoPFX), passwordCertificadoPFX, X509KeyStorageFlags.PersistKeySet);
                //Retorno certificado
                return objCertificado;
            }
            catch (Exception excepcionAlImportarCertificado)
            {
                throw new Exception("ERROR: Procedimiento: ObtenerCertificadoDesdeArchivo.  Ruta del archivo=" + objEntidadesConf_Certificado.ArchivoCertificadoPFX + ". Excepcion=" + excepcionAlImportarCertificado.Message + " " + excepcionAlImportarCertificado.StackTrace);
            }
        }

        /// <summary> 
        /// Firma el mensaje PKCS #7 con el certificado del firmante
        /// </summary> 
        /// <param name="pMensaje">Mensaje (como cadena de bytes)</param> 
        /// <param name="pCertificadoFirmante">Certificado usado para firmar</param> 
        /// <returns>Mensaje Firmado (como cadena de bytes)</returns> 
        /// <remarks></remarks> 
        public static byte[] FirmarMensaje(byte[] pMensaje, X509Certificate2 pCertificadoFirmante)
        {
            byte[] msjFirmado;

            try
            {
                // Se pone el Mensaje recibido en un objeto ContentInfo                 
                ContentInfo infoContenidoMsj    = new ContentInfo(pMensaje);
                // Se instancia el CMS Firmado con el ContentInfo
                SignedCms cmsFirmado            = new SignedCms(infoContenidoMsj);
                // Se instancia el objeto CmsSigner con las caracteristicas del firmante 
                CmsSigner cmsFirmante = new CmsSigner(pCertificadoFirmante);

                cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly;

                // Se firma el mensaje PKCS #7 con el certificado
                cmsFirmado.ComputeSignature(cmsFirmante);

                msjFirmado = cmsFirmado.Encode();

                // Retorno el mensaje PKCS #7 firmado . 
                return msjFirmado;
            }
            catch (Exception excepcionAlFirmar)
            {
                throw new Exception("ERROR: Procedimiento: FirmarMensaje. Al intentar firmar el mensaje con el certificado del firmante: " + excepcionAlFirmar.Message);
            }
        }

        /// <summary>
        /// Convierte un String en un SecureString
        /// </summary>
        /// <param name="pPassword">Password del Archivo PFX como String</param>
        /// <returns></returns>
        public SecureString ConvertirPasswordSecureString(string pPassword)
        {
            SecureString passConvertida = new SecureString();

            foreach (char c in pPassword)
            {
                passConvertida.AppendChar(c);
            }

            passConvertida.MakeReadOnly();  

            return passConvertida;

        }
    }
}
