using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200106A RID: 4202
	public static class SceneEntityRefreshInfoReflection
	{
		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600BB2A RID: 47914 RVA: 0x001F771D File Offset: 0x001F591D
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEntityRefreshInfoReflection.descriptor;
			}
		}

		// Token: 0x04004BEC RID: 19436
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxTY2VuZUVudGl0eVJlZnJlc2hJbmZvLnByb3RvGhVTY2VuZUVudGl0eUlu",
			"Zm8ucHJvdG8iewoWU2NlbmVFbnRpdHlSZWZyZXNoSW5mbxImCgphZGRfZW50",
			"aXR5GAQgASgLMhAuU2NlbmVFbnRpdHlJbmZvSAASFQoLRklGTExPR1BOTUMY",
			"CiABKA1IABIXCg1kZWxldGVfZW50aXR5GAsgASgNSABCCQoHcmVmcmVzaEIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneEntityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityRefreshInfo), SceneEntityRefreshInfo.Parser, new string[]
			{
				"AddEntity",
				"FIFLLOGPNMC",
				"DeleteEntity"
			}, new string[]
			{
				"Refresh"
			}, null, null, null)
		}));
	}
}
