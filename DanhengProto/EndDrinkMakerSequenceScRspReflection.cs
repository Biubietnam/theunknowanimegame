using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200041C RID: 1052
	public static class EndDrinkMakerSequenceScRspReflection
	{
		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x00080F56 File Offset: 0x0007F156
		public static FileDescriptor Descriptor
		{
			get
			{
				return EndDrinkMakerSequenceScRspReflection.descriptor;
			}
		}

		// Token: 0x040012BA RID: 4794
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBFbmREcmlua01ha2VyU2VxdWVuY2VTY1JzcC5wcm90bxoVRHJpbmtNYWtl",
			"ckd1ZXN0LnByb3RvGg5JdGVtTGlzdC5wcm90bxoRQktGTExPSERMRU0ucHJv",
			"dG8izgEKGkVuZERyaW5rTWFrZXJTZXF1ZW5jZVNjUnNwEhkKBnJld2FyZBgM",
			"IAEoCzIJLkl0ZW1MaXN0EgwKBFRpcHMYCSABKA0SCwoDRXhwGAQgASgNEhYK",
			"Dk5leHRTZXF1ZW5jZUlkGAsgASgNEh8KBUd1ZXN0GAMgASgLMhAuRHJpbmtN",
			"YWtlckd1ZXN0Eg0KBWxldmVsGAogASgNEg8KB3JldGNvZGUYDyABKA0SIQoL",
			"UmVxdWVzdExpc3QYASADKAsyDC5CS0ZMTE9IRExFTUIeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			DrinkMakerGuestReflection.Descriptor,
			ItemListReflection.Descriptor,
			BKFLLOHDLEMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EndDrinkMakerSequenceScRsp), EndDrinkMakerSequenceScRsp.Parser, new string[]
			{
				"Reward",
				"Tips",
				"Exp",
				"NextSequenceId",
				"Guest",
				"Level",
				"Retcode",
				"RequestList"
			}, null, null, null, null)
		}));
	}
}
