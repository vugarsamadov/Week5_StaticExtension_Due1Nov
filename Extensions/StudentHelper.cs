using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_StaticExtension_Due1Nov.Models;

namespace Week5_StaticExtension_Due1Nov.Extensions
{
    internal static class StudentHelper
    {

        public static bool CheckGroupNo(string groupNo)
        {
            int numCnt = 0;
            bool alphaCheck = Char.IsLetter(groupNo[0]) && Char.IsUpper(groupNo[0]);

            if (groupNo.Length > Student.UpperAlphaCount+ Student.NumCount) return false;
            
            for (int i = 0;i<groupNo.Length; i++)
            {
                if (Char.IsDigit(groupNo[i]))
                    numCnt++;
            }
            
            return  alphaCheck && numCnt == Student.NumCount;
        }

        public static bool CheckFullname(string fullName)
        {
            var nameAndSurname = fullName.Split();

            if(nameAndSurname.Length != 2) return false;
            
            return !nameAndSurname[0].ContainsDigit() && !nameAndSurname[1].ContainsDigit();
        }

        public static string FormatFullName(string fullName)
        {
            var fullnameParts = fullName.Split();
            fullnameParts[0] = fullnameParts[0].CapitaliseString();
            fullnameParts[1] = fullnameParts[1].CapitaliseString();

            return String.Join(' ', fullnameParts);
        }

        public static string GetFullNameFromUser()
        {
            string Name;
            do
            {
                Name = Helper.PromptAndGetNonEmptyString("Enter full name: ");
                if (!StudentHelper.CheckFullname(Name))
                    Console.WriteLine("Full name invalid!");
            } while (!StudentHelper.CheckFullname(Name));

            return Name;
        }

        internal static string GetGroupNoFromUser()
        {
            string GroupNo;

            do
            {
                GroupNo = Helper.PromptAndGetNonEmptyString("Enter GroupNo: ");
                if (!StudentHelper.CheckGroupNo(GroupNo))
                    Console.WriteLine("Group No invalid!");

            } while (!StudentHelper.CheckGroupNo(GroupNo));

            return GroupNo;
        }
    }
}
