using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011E4 RID: 4580
	public static class StopRogueAdventureRoomScRspReflection
	{
		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0600CCB1 RID: 52401 RVA: 0x00225547 File Offset: 0x00223747
		public static FileDescriptor Descriptor
		{
			get
			{
				return StopRogueAdventureRoomScRspReflection.descriptor;
			}
		}

		// Token: 0x0400528A RID: 21130
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFTdG9wUm9ndWVBZHZlbnR1cmVSb29tU2NSc3AucHJvdG8aF0FkdmVudHVy",
			"ZVJvb21JbmZvLnByb3RvIl8KG1N0b3BSb2d1ZUFkdmVudHVyZVJvb21TY1Jz",
			"cBIvChNhZHZlbnR1cmVfcm9vbV9pbmZvGAggASgLMhIuQWR2ZW50dXJlUm9v",
			"bUluZm8SDwoHcmV0Y29kZRgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AdventureRoomInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StopRogueAdventureRoomScRsp), StopRogueAdventureRoomScRsp.Parser, new string[]
			{
				"AdventureRoomInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
