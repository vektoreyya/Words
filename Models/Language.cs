﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words.Models
{
    internal class Language
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Word> Words { get; set; }
		public String Description { get; set; }
        public List<Group> Groups { get; set; }

        public Language(Guid id, string title, List<Word> words, string description, List<Group> groups)
        {
            Id = id;
            Title = title;
            Words = words;
			Description = description;
            Groups = groups;
        }

        public double getAverageLevel()
        {
            return Words.Sum(x => x.Level) / Words.Count;
        }

        public override string ToString()
        {
            return $"{Title} : {getAverageLevel()}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
