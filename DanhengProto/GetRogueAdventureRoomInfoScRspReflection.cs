using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007A2 RID: 1954
	public static class GetRogueAdventureRoomInfoScRspReflection
	{
		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x0600574C RID: 22348 RVA: 0x000E9E76 File Offset: 0x000E8076
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueAdventureRoomInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04002221 RID: 8737
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRHZXRSb2d1ZUFkdmVudHVyZVJvb21JbmZvU2NSc3AucHJvdG8aF0FkdmVu",
			"dHVyZVJvb21JbmZvLnByb3RvImIKHkdldFJvZ3VlQWR2ZW50dXJlUm9vbUlu",
			"Zm9TY1JzcBIPCgdyZXRjb2RlGAcgASgNEi8KE2FkdmVudHVyZV9yb29tX2lu",
			"Zm8YDSABKAsyEi5BZHZlbnR1cmVSb29tSW5mb0IeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AdventureRoomInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueAdventureRoomInfoScRsp), GetRogueAdventureRoomInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"AdventureRoomInfo"
			}, null, null, null, null)
		}));
	}
}
