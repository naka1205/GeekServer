//auto generated, do not modify it

using MessagePack;

namespace Geek.Server.Proto
{
	[MessagePackObject(true)]
	public class ReqLogin : Geek.Server.Message
	{
		[IgnoreMember]
		public const int Sid = 205475772;

		[IgnoreMember]
		public const int MsgID = Sid;
		[IgnoreMember]
		public override int MsgId => MsgID;

        public string UserName { get; set; }
        public string Platform { get; set; }
        public int SdkType { get; set; }
        public string SdkToken { get; set; }
        public string Device { get; set; }
	}
}
