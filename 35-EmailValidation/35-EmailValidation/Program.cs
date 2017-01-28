using System;
using System.IO;

namespace _35_EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //open file
            using (StreamReader reader = new StreamReader(args[0]))
            {
                //for each line
                while (!reader.EndOfStream)
                {
                    //read it
                    string line = reader.ReadLine();
                    //if not empty
                    if (null == line) continue;
                    //control
                    line = ValidateEmailFormat(line).ToString().ToLower();
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
        //en.wikipedia.org/wiki/Email_address
        static bool ValidateEmailFormat(string email)
        {
            //ilk kontroller
            {
                if (email.Length > 320)
                    return false;
                //320 karakterden uzun olamaz
                if (email.IndexOf("..") > 0)
                    return false;
                //iki nokta asla yanyana olamaz
                if (email.IndexOf("@") == -1)
                    return false;
                //en az bir @ işareti olmalı
                if (email.Length != email.Trim().Length)
                    return false;
                //başta ve sonda boşluk olamaz
                if (email.Substring(0,1) == "." | email.Substring(email.Length-1) == ".")
                    return false;
                //başta ve sonda nokta olamaz
                //find position of @
                int qPos = 0;
                for (int i = 0; i <= email.Length - 1; i++)
                {
                    if (email.Substring(i, 1) == "@")
                        qPos = i;
                }
                //local and domain parts
                string localPart = email.Substring(0, qPos);
                string domainPart = email.Substring(qPos + 1);
                string forbidden = "%# (),:;<>@[\\]";
                string tmp = null;
                ///'''''''''''local part control
                if (localPart.Length > 64)
                    return false;
                //local part uzunluk kontrolü
                //eğer komple tırnak içindeyse
                if (localPart.Substring(0, 1) == "\"" & localPart.Substring(localPart.Length - 1) == "\"")
                {
                    //tırnak yoksa normal kurallar
                }
                else
                {
                    if (localPart.IndexOf("@") > 0)
                        return false;
                    //@ işareti olmamalı
                    if (localPart.IndexOf("\"") > 0)
                        return false;
                    //"" işareti olmamalı
                    if (localPart.Substring(localPart.Length - 1) == ".")
                        return false;
                    //sonda nokta olamaz
                    //yasak karakter kullanımı
                    tmp = localPart;
                    for (int i = 0; i <= forbidden.Length - 1; i++)
                    {
                        tmp = tmp.Replace(forbidden.Substring(i, 1), "");
                    }
                    if (tmp != localPart)
                        return false;
                }
                ///''''''''domain part control
                //uzunluk kontrol
                if (domainPart.Length < 3 | domainPart.Length > 64)
                    return false;
                if (domainPart.IndexOf("\"") > 0)
                    return false;
                //"" işareti olmamalı
                if (domainPart.IndexOf("*") > 0)
                    return false;
                //* işareti olmamalı
                if (domainPart.Substring(0,1) == ".")
                    return false;
                //başta nokta olamaz
                //yasak karakter kullanımı
                tmp = domainPart;
                for (int i = 0; i <= forbidden.Length - 1; i++)
                {
                    tmp = tmp.Replace(forbidden.Substring(i, 1), "");
                }
                if (tmp != domainPart)
                    return false;
            }
            //if passes every control then return true

            return true;
        }
    }
}
