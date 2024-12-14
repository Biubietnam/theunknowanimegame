using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000440 RID: 1088
	public static class EnteredSceneInfoReflection
	{
		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x00084B4C File Offset: 0x00082D4C
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnteredSceneInfoReflection.descriptor;
			}
		}

		// Token: 0x04001338 RID: 4920
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZFbnRlcmVkU2NlbmVJbmZvLnByb3RvIjYKEEVudGVyZWRTY2VuZUluZm8S" + "EAoIZmxvb3JfaWQYDCABKA0SEAoIcGxhbmVfaWQYDSABKA1CHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnteredSceneInfo), EnteredSceneInfo.Parser, new string[]
			{
				"FloorId",
				"PlaneId"
			}, null, null, null, null)
		}));
	}
}
