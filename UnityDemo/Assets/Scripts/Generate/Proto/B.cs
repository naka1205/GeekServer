//auto generated, do not modify it

using MessagePack;

namespace Geek.Server.Proto
{
	[MessagePackObject]
	public class B : Geek.Server.Proto.A
	{
		[IgnoreMember]
		public new const int Sid = 111112;

        [Key(1)]
        public string Name { get; set; }
        [IgnoreMember]
        public string Test { get; set; }
	}
}