using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001074 RID: 4212
	public static class SceneGroupStateReflection
	{
		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600BB8F RID: 48015 RVA: 0x001F8743 File Offset: 0x001F6943
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneGroupStateReflection.descriptor;
			}
		}

		// Token: 0x04004C0F RID: 19471
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVTY2VuZUdyb3VwU3RhdGUucHJvdG8iRgoPU2NlbmVHcm91cFN0YXRlEg0K" + "BXN0YXRlGAUgASgNEhAKCGdyb3VwX2lkGAcgASgNEhIKCmlzX2RlZmF1bHQY" + "BiABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneGroupState), SceneGroupState.Parser, new string[]
			{
				"State",
				"GroupId",
				"IsDefault"
			}, null, null, null, null)
		}));
	}
}
