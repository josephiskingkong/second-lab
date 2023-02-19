using System;

namespace second_lab
{
    public class Document
    {
        public string Name = "Undefined";
        public string Author = "Undefined";
        public string KeyWords = "Undefined";
        public string Theme = "Undefined";
        public string PathToFile = "Undefined";
        public string FileExtension = "Undefined";
        public virtual void InfoOut()
        {
            Console.WriteLine($"Name: {Name}, Author: {Author}, Key words: {KeyWords}" +
                $"Theme: {Theme}, Path to the file: {PathToFile}, File extension: {FileExtension}");
        }
    }
}