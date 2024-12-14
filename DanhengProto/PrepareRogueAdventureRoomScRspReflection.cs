using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CFA RID: 3322
	public static class PrepareRogueAdventureRoomScRspReflection
	{
		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x0600946F RID: 37999 RVA: 0x0018AB16 File Offset: 0x00188D16
		public static FileDescriptor Descriptor
		{
			get
			{
				return PrepareRogueAdventureRoomScRspReflection.descriptor;
			}
		}

		// Token: 0x04003983 RID: 14723
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRQcmVwYXJlUm9ndWVBZHZlbnR1cmVSb29tU2NSc3AucHJvdG8aF0FkdmVu",
			"dHVyZVJvb21JbmZvLnByb3RvImIKHlByZXBhcmVSb2d1ZUFkdmVudHVyZVJv",
			"b21TY1JzcBIvChNhZHZlbnR1cmVfcm9vbV9pbmZvGA4gASgLMhIuQWR2ZW50",
			"dXJlUm9vbUluZm8SDwoHcmV0Y29kZRgJIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AdventureRoomInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PrepareRogueAdventureRoomScRsp), PrepareRogueAdventureRoomScRsp.Parser, new string[]
			{
				"AdventureRoomInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
