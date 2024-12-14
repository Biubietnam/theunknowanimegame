using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000648 RID: 1608
	public static class GetChallengeScRspReflection
	{
		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x000C584A File Offset: 0x000C3A4A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChallengeScRspReflection.descriptor;
			}
		}

		// Token: 0x04001CDA RID: 7386
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdHZXRDaGFsbGVuZ2VTY1JzcC5wcm90bxoRT01QREpJSk5OQlAucHJvdG8a",
			"FENoYWxsZW5nZUdyb3VwLnByb3RvGg9DaGFsbGVuZ2UucHJvdG8irwEKEUdl",
			"dENoYWxsZW5nZVNjUnNwEhMKC0dHQkNQTkNETUZBGAwgASgNEg8KB3JldGNv",
			"ZGUYBSABKA0SIQoLR1BIQ1BMUEhOTk0YDSADKAsyDC5PTVBESklKTk5CUBIt",
			"ChRjaGFsbGVuZ2VfZ3JvdXBfbGlzdBgJIAMoCzIPLkNoYWxsZW5nZUdyb3Vw",
			"EiIKDmNoYWxsZW5nZV9saXN0GA8gAygLMgouQ2hhbGxlbmdlQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			OMPDJIJNNBPReflection.Descriptor,
			ChallengeGroupReflection.Descriptor,
			ChallengeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeScRsp), GetChallengeScRsp.Parser, new string[]
			{
				"GGBCPNCDMFA",
				"Retcode",
				"GPHCPLPHNNM",
				"ChallengeGroupList",
				"ChallengeList"
			}, null, null, null, null)
		}));
	}
}
