using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011B8 RID: 4536
	public static class StartPartialChallengeCsReqReflection
	{
		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x0600CA9D RID: 51869 RVA: 0x0021F83C File Offset: 0x0021DA3C
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartPartialChallengeCsReqReflection.descriptor;
			}
		}

		// Token: 0x040051B4 RID: 20916
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTdGFydFBhcnRpYWxDaGFsbGVuZ2VDc1JlcS5wcm90byJaChpTdGFydFBh" + "cnRpYWxDaGFsbGVuZ2VDc1JlcRIUCgxjaGFsbGVuZ2VfaWQYCSABKA0SFQoN" + "aXNfZmlyc3RfaGFsZhgHIAEoCBIPCgdidWZmX2lkGAsgASgNQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartPartialChallengeCsReq), StartPartialChallengeCsReq.Parser, new string[]
			{
				"ChallengeId",
				"IsFirstHalf",
				"BuffId"
			}, null, null, null, null)
		}));
	}
}
