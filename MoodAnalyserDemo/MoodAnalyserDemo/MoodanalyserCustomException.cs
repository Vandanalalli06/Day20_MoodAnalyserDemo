using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType//enum=which is used to map between 
        {
            NULL_MESSAGE,//Null=0
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)//base is keyword which points out to Parent class 
        {
            this.type = Type;
        }
    }
}
    

