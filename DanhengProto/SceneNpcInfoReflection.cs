using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001080 RID: 4224
	public static class SceneNpcInfoReflection
	{
		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x001FB7E1 File Offset: 0x001F99E1
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneNpcInfoReflection.descriptor;
			}
		}

		// Token: 0x04004C96 RID: 19606
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJTY2VuZU5wY0luZm8ucHJvdG8aEk5wY0V4dHJhSW5mby5wcm90byJBCgxT" + "Y2VuZU5wY0luZm8SIQoKZXh0cmFfaW5mbxgEIAEoCzINLk5wY0V4dHJhSW5m" + "bxIOCgZucGNfaWQYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			NpcExtraInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneNpcInfo), SceneNpcInfo.Parser, new string[]
			{
				"ExtraInfo",
				"NpcId"
			}, null, null, null, null)
		}));
	}
}
