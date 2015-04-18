﻿using System;

namespace CardGames
{
    [Serializable]
    public class Card : ClassExtension
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsPublished { get; private set; }

        public Card(string name, string description)
        {
            Name = name;
            Description = description;
            IsPublished = null;
        }

        public void Publish()
        {
            IsPublished = true;
        }

        public void Hide()
        {
            IsPublished = false;
        }

        public override string ToString()
        {
            return String.Format("{0}\nDescription:\n{1}\nPublish State: {2}", Name, Description, IsPublished ?? (object) "not set");
        }
    }
}
