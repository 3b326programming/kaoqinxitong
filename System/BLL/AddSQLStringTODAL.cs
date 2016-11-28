using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Data;
using DBA;

namespace BLL
{
   public class AddSQLStringTODAL
    {
       public static DataTable GetDatatableBySQL(string TabTeacher) {
           string SQL = "select UserPWD from " + TabTeacher + "";
            DataTable dt=DBHelper.GetDT(SQL);
           return dt;
       }
       public static void UpdateTabTeacher(string TabTeacher,string UserPWD,string UserID) {
           string SQL = "update " + TabTeacher + " set UserPWD='" + UserPWD + "' where UserID='" + UserID + "'";
           DBHelper.GETDTA(SQL);
       }
   }
       public class PWDProcess
       {
        public static string MD5Encrypt(string pToEncrypt, string Key)
       {
           DESCryptoServiceProvider des = new DESCryptoServiceProvider();
           byte[] inputByteArray = Encoding.ASCII.GetBytes(pToEncrypt);
           des.Key = ASCIIEncoding.ASCII.GetBytes(Key);
           des.IV = ASCIIEncoding.ASCII.GetBytes(Key);
           MemoryStream ms = new MemoryStream();
           CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
           cs.Write(inputByteArray, 0, inputByteArray.Length);
           cs.FlushFinalBlock();
           StringBuilder ret = new StringBuilder();
           foreach (byte b in ms.ToArray())
           {
               ret.AppendFormat("{0:X2}", b);
           }
           ret.ToString();
           return ret.ToString();



       }
       public static string CreateKey(string inputStr)
       {
           StringBuilder sb = new StringBuilder();
         
           string str = "zhixuxinZx";
           if (CheckStringIsNumString(inputStr) && inputStr.Length >= 9)
           {
               for (int i = 1; i <= 8; i++)
               {
                   sb.Append(str[Convert.ToInt32(inputStr[i].ToString())]);
                   
               }
               return sb.ToString();
           }
           else
           {
              
               return "3b326...";
           }
           
       }
       public static bool CheckStringIsNumString(string str)
       {
           for (int i = 0; i < str.Length; i++)
           {
               if (str[i] < '0' || str[i] > '9')
                   return false;
           }
           return true;
       }
   }
    }


