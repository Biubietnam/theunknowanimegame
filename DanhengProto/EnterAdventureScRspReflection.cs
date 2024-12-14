using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000430 RID: 1072
	public static class EnterAdventureScRspReflection
	{
		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x000834DE File Offset: 0x000816DE
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterAdventureScRspReflection.descriptor;
			}
		}

		// Token: 0x0400130B RID: 4875
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFbnRlckFkdmVudHVyZVNjUnNwLnByb3RvGg9TY2VuZUluZm8ucHJvdG8i" + "QQoTRW50ZXJBZHZlbnR1cmVTY1JzcBIZCgVzY2VuZRgKIAEoCzIKLlNjZW5l" + "SW5mbxIPCgdyZXRjb2RlGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterAdventureScRsp), EnterAdventureScRsp.Parser, new string[]
			{
				"Scene",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
