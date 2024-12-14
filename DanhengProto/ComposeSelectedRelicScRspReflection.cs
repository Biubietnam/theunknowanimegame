using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000322 RID: 802
	public static class ComposeSelectedRelicScRspReflection
	{
		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x000662D2 File Offset: 0x000644D2
		public static FileDescriptor Descriptor
		{
			get
			{
				return ComposeSelectedRelicScRspReflection.descriptor;
			}
		}

		// Token: 0x04000EC2 RID: 3778
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Db21wb3NlU2VsZWN0ZWRSZWxpY1NjUnNwLnByb3RvGg5JdGVtTGlzdC5w",
			"cm90byJlChlDb21wb3NlU2VsZWN0ZWRSZWxpY1NjUnNwEiMKEHJldHVybl9p",
			"dGVtX2xpc3QYCSABKAsyCS5JdGVtTGlzdBIPCgdyZXRjb2RlGAYgASgNEhIK",
			"CmNvbXBvc2VfaWQYDSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ComposeSelectedRelicScRsp), ComposeSelectedRelicScRsp.Parser, new string[]
			{
				"ReturnItemList",
				"Retcode",
				"ComposeId"
			}, null, null, null, null)
		}));
	}
}
