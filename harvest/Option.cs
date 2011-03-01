using System;

namespace harvest
{
    public class Option
    {
        private OptionValue type;

        public Option(string prototype, string description, Action<string> action)
        {
            Prototype = prototype;
            Prototypes = prototype.Split('|');
            Description = description;
            Action = action;
            type = GetOptionValue();
        }

        public string Prototype { get; private set; }

        public string Description { get; private set; }

        public Action<string> Action { get; private set; }

        internal string[] Prototypes { get; private set; }

        internal OptionValue OptionValue
        {
            get { return type; }
        }

        private OptionValue GetOptionValue()
        {
            foreach (string n in Prototypes)
            {
                if (n.IndexOf('=') >= 0)
                    return OptionValue.Required;
                if (n.IndexOf(':') >= 0)
                    return OptionValue.Optional;
            }
            return OptionValue.None;
        }

        public override string ToString()
        {
            return Prototype;
        }
    }
}