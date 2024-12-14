using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200131C RID: 4892
	public static class TakeRogueAeonLevelRewardCsReqReflection
	{
		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x0600DA4C RID: 55884 RVA: 0x002457CC File Offset: 0x002439CC
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeRogueAeonLevelRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x040056F1 RID: 22257
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNUYWtlUm9ndWVBZW9uTGV2ZWxSZXdhcmRDc1JlcS5wcm90byI/Ch1UYWtl" + "Um9ndWVBZW9uTGV2ZWxSZXdhcmRDc1JlcRINCgVsZXZlbBgIIAEoDRIPCgdh" + "ZW9uX2lkGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueAeonLevelRewardCsReq), TakeRogueAeonLevelRewardCsReq.Parser, new string[]
			{
				"Level",
				"AeonId"
			}, null, null, null, null)
		}));
	}
}
