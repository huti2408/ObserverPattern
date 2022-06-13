// See https://aka.ms/new-console-template for more information
using ObserverPattern;

var HUFLIT = new School();
Student DuyAnh = new Student("Duy Anh");
Student HuuTin = new Student("Huu Tin");
HUFLIT.AddStudent(HuuTin);
HUFLIT.AddStudent(DuyAnh);
HUFLIT.ReleaseDayOff();
HUFLIT.ReleaseExam();
Console.ReadKey();