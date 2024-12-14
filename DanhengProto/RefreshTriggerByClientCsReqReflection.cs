using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D90 RID: 3472
	public static class RefreshTriggerByClientCsReqReflection
	{
		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x06009B0D RID: 39693 RVA: 0x0019C6CB File Offset: 0x0019A8CB
		public static FileDescriptor Descriptor
		{
			get
			{
				return RefreshTriggerByClientCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003C26 RID: 15398
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50Q3NSZXEucHJvdG8aEE1vdGlvbklu",
			"Zm8ucHJvdG8ikwEKG1JlZnJlc2hUcmlnZ2VyQnlDbGllbnRDc1JlcRIeChZ0",
			"cmlnZ2VyX3RhcmdldF9pZF9saXN0GAIgAygNEiMKDnRyaWdnZXJfbW90aW9u",
			"GAggASgLMgsuTW90aW9uSW5mbxIZChF0cmlnZ2VyX2VudGl0eV9pZBgKIAEo",
			"DRIUCgx0cmlnZ2VyX25hbWUYCSABKAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RefreshTriggerByClientCsReq), RefreshTriggerByClientCsReq.Parser, new string[]
			{
				"TriggerTargetIdList",
				"TriggerMotion",
				"TriggerEntityId",
				"TriggerName"
			}, null, null, null, null)
		}));
	}
}
