using NamespaceAccessModifiers.Models;
using System;
using ClassLibrary1;

namespace NamespaceAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Namespace

            //Figure f1 = new Figure();
            //f1.Test = 10;

            ////Demo.Figure f2 = new Demo.Figure();
            //NamespaceAccessModifiers.Models.Figure f3 = new Models.Figure();
            //f3.Demo = 10;

            //Figure

            ////Models.Teacher t1 = new Models.Teacher();
            //Teacher t1 = new Teacher();

            //System.Text.StringBuilder s1 = new System.Text.StringBuilder();

            #endregion

            #region Internal access modifier

            //Helper h1 = new Helper();
            //h1.Demo = "";

            #endregion

            #region Protected internal
            //Chagiran layihe uchun protected-dir
            //Oz layihesi uchun internal-dir

            //Message m1 = new Message();

            #endregion

            #region Private protected
            //Chagiran layihe uchun private-dir
            //Oz layihesi uchun protected-dir

            //Message m1 = new Message();
            //m1.Test = "";

            #endregion

            //Default Access modifier of Class is Internal
            //Default access modifier of field is private

            #region Partial

            Student s1 = new Student();
            s1.Print();

            #endregion

            //Public - all members
            //Private - all members
            //Protected - all members without class
            //Internal - all members without constructor
            //Protected internal - property, field, method
            //Private protected - property, field, method
        }
    }
}

//namespace Demo
//{
//    class Figure
//    {

//    }
//}
