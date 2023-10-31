using Week5_StaticExtension_Due1Nov.Extensions;
using Week5_StaticExtension_Due1Nov.Models;

string FullName = StudentHelper.GetFullNameFromUser();

int Age = Helper.PromptAndGetPositiveInt("Enter Age: ");

string GroupNo = StudentHelper.GetGroupNoFromUser();

Student student = new(FullName,GroupNo,Age);

