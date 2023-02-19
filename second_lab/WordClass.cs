using System;

namespace second_lab
{
    public class Word : Document
    {
        string DefaultFont = "Undefined";
        string SpecialWordProperty = "Undefined";
        override public void InfoOut()
        {
            Console.WriteLine($"Name: {Name}, Author: {Author}, Key words: {KeyWords}, " +
                $"Theme: {Theme}, Path to the file: {PathToFile}, File extension: {FileExtension}, " +
                $"Default font: {DefaultFont}, Special .word property: {SpecialWordProperty}");
        }
        public Word(string Name, string Author, string KeyWords, string Theme, string PathToFile, string FileExtension,
            string DefaultFont,string SpecialWordProperty)
        {
            this.Name = Name;
            this.Author = Author;
            this.KeyWords = KeyWords;
            this.Theme = Theme;
            this.PathToFile = PathToFile;
            this.FileExtension = FileExtension;
            this.DefaultFont = DefaultFont;
            this.SpecialWordProperty = SpecialWordProperty;
        }
    }
}