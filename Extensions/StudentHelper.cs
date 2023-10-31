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
            int alphaCnt =0, numCnt = 0;

            if (groupNo.Length > Student.UpperAlphaCount+ Student.NumCount) return false;
            
            for (int i = 0;i<groupNo.Length; i++)
            {
                if (Char.IsLetter(groupNo[i]) && Char.IsUpper(groupNo[i]))
                    alphaCnt++;
                if (Char.IsDigit(groupNo[i]))
                    numCnt++;
            }
            return alphaCnt == Student.UpperAlphaCount && numCnt == Student.NumCount;
        }

        public static bool CheckFullname(string fullName)
        {
            var nameAndSurname = fullName.Split();

            if(nameAndSurname.Length != 2) return false;

            return Char.IsUpper(nameAndSurname[0][0]) && Char.IsUpper(nameAndSurname[1][0]);
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
