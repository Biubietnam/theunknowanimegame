using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012C0 RID: 4800
	public static class TakeBpRewardScRspReflection
	{
		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0600D623 RID: 54819 RVA: 0x0023B494 File Offset: 0x00239694
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeBpRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x0400558A RID: 21898
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlQnBSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iPwoR" + "VGFrZUJwUmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgKIAEoDRIZCgZyZXdhcmQY" + "DiABKAsyCS5JdGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeBpRewardScRsp), TakeBpRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
