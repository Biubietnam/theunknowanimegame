using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012BE RID: 4798
	public static class TakeBpRewardCsReqReflection
	{
		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0600D60A RID: 54794 RVA: 0x0023B099 File Offset: 0x00239299
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeBpRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005581 RID: 21889
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlQnBSZXdhcmRDc1JlcS5wcm90bxoSQnBSZXdhcmRUeXBlLnByb3Rv" + "IlsKEVRha2VCcFJld2FyZENzUmVxEhsKBHR5cGUYCiABKA4yDS5CcFJld2Fy" + "ZFR5cGUSGgoSb3B0aW9uYWxfcmV3YXJkX2lkGAwgASgNEg0KBWxldmVsGAYg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			BpRewardTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeBpRewardCsReq), TakeBpRewardCsReq.Parser, new string[]
			{
				"Type",
				"OptionalRewardId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
