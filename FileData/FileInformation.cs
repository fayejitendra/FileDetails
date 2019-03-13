using System;
using System.Configuration;
using ThirdPartyTools;

namespace FileData
{
    public static class FileInformation
    {
        public static string GetFileDetails(string strFunctionality, string strFilename)
        {
            try
            {
                //Getting Version and Size 
                string[] arrVersion = Convert.ToString(ConfigurationManager.AppSettings["version"]).Split(',');
                string[] arrSize = Convert.ToString(ConfigurationManager.AppSettings["size"]).Split(',');

                string strFileDetails = string.Empty;
                FileDetails fileDetails = new FileDetails();

                //Getting file version 
                if (!string.IsNullOrEmpty(Array.Find(arrVersion, s => s.Equals(strFunctionality))))
                {
                    strFileDetails = "File Version: " + fileDetails.Version(strFilename);
                }
                //Getting file size
                else if (!string.IsNullOrEmpty(Array.Find(arrSize, s => s.Equals(strFunctionality))))
                {
                    strFileDetails = "File Size: " + fileDetails.Size(strFilename).ToString();
                }
                else
                {
                    throw new Exception("Invalid Functionality.");
                }
                return strFileDetails;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
