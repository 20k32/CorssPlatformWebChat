using System.Text;

namespace Models
{
    public class Message
    {
        public string Header { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;

        // for de/sericalization purpose only
        public Message()
        { }

        public Message(string MessageHeader, string MessageBody)
        {
            Header = MessageHeader;
            Body = MessageBody;
        }

        public Message(string MessageBody) : this("Plain text message", MessageBody)
        { }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder(Header.Length + Body.Length);

            stringBuilder.Append(Header);
            stringBuilder.Append(Body);

            return stringBuilder.ToString();
        }
    }
}