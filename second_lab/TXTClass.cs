using System;
namespace second_lab
{
    public class TXT : Document
    {
        string OSThatCanOpenTXT = "Undefined";
        override public void InfoOut()
        {
            Console.WriteLine($"Name: {Name}, Author: {Author}, Key words: {KeyWords}, " +
                $"Theme: {Theme}, Path to the file: {PathToFile}, File extension: {FileExtension}, " +
                $"Operating systems that can open .txt: {OSThatCanOpenTXT}");
            Console.ReadKey();
        }
        public TXT(string Name, string Author, string KeyWords, string Theme, string PathToFile, string FileExtension,
            string OSThatCanOpenTXT)
        {
            this.Name = Name;
            this.Author = Author;
            this.KeyWords = KeyWords;
            this.Theme = Theme;
            this.PathToFile = PathToFile;
            this.FileExtension = FileExtension;
            this.OSThatCanOpenTXT = OSThatCanOpenTXT;
        }
    }
}