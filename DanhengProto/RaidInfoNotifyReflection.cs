using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D6C RID: 3436
	public static class RaidInfoNotifyReflection
	{
		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x06009990 RID: 39312 RVA: 0x00198BBE File Offset: 0x00196DBE
		public static FileDescriptor Descriptor
		{
			get
			{
				return RaidInfoNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003B9C RID: 15260
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRSYWlkSW5mb05vdGlmeS5wcm90bxoQUmFpZFN0YXR1cy5wcm90bxoOSXRl",
			"bUxpc3QucHJvdG8aFFJhaWRUYXJnZXRJbmZvLnByb3RvIrYBCg5SYWlkSW5m",
			"b05vdGlmeRIYChByYWlkX2ZpbmlzaF90aW1lGA8gASgEEg8KB3JhaWRfaWQY",
			"ByABKA0SGwoGc3RhdHVzGAMgASgOMgsuUmFpZFN0YXR1cxITCgt3b3JsZF9s",
			"ZXZlbBgKIAEoDRIcCglpdGVtX2xpc3QYDiABKAsyCS5JdGVtTGlzdBIpChBy",
			"YWlkX3RhcmdldF9pbmZvGAIgAygLMg8uUmFpZFRhcmdldEluZm9CHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RaidStatusReflection.Descriptor,
			ItemListReflection.Descriptor,
			RaidTargetInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RaidInfoNotify), RaidInfoNotify.Parser, new string[]
			{
				"RaidFinishTime",
				"RaidId",
				"Status",
				"WorldLevel",
				"ItemList",
				"RaidTargetInfo"
			}, null, null, null, null)
		}));
	}
}
