using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string ClassName, string costructorName)
        {
            string pattern = @"." + costructorName + "$";
            Match result = Regex.Match(ClassName, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Construtor is not Found");

            }
        }
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string ClassName, string costructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(costructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Construtor is not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }
    }
}
