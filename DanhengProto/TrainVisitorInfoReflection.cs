using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001364 RID: 4964
	public static class TrainVisitorInfoReflection
	{
		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x0600DD84 RID: 56708 RVA: 0x0024D9EF File Offset: 0x0024BBEF
		public static FileDescriptor Descriptor
		{
			get
			{
				return TrainVisitorInfoReflection.descriptor;
			}
		}

		// Token: 0x04005817 RID: 22551
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZUcmFpblZpc2l0b3JJbmZvLnByb3RvGhhUcmFpblZpc2l0b3JTdGF0dXMu",
			"cHJvdG8iiwEKEFRyYWluVmlzaXRvckluZm8SEwoLREpMS0NIS01OTUkYBSAB",
			"KA0SEwoLTkdPTUFMR0NKTkYYDCABKAgSIwoGc3RhdHVzGAEgASgOMhMuVHJh",
			"aW5WaXNpdG9yU3RhdHVzEhMKC0VDRExGRUFOSk1BGAcgAygNEhMKC0FCUExO",
			"UE1OREFEGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			TrainVisitorStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TrainVisitorInfo), TrainVisitorInfo.Parser, new string[]
			{
				"DJLKCHKMNMI",
				"NGOMALGCJNF",
				"Status",
				"ECDLFEANJMA",
				"ABPLNPMNDAD"
			}, null, null, null, null)
		}));
	}
}
