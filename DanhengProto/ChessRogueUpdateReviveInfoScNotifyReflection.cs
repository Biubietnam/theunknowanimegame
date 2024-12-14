using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002B8 RID: 696
	public static class ChessRogueUpdateReviveInfoScNotifyReflection
	{
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x00058A3D File Offset: 0x00056C3D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateReviveInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000CE3 RID: 3299
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CihDaGVzc1JvZ3VlVXBkYXRlUmV2aXZlSW5mb1NjTm90aWZ5LnByb3RvGhtS",
			"b2d1ZUF2YXRhclJldml2ZUNvc3QucHJvdG8iUQoiQ2hlc3NSb2d1ZVVwZGF0",
			"ZVJldml2ZUluZm9TY05vdGlmeRIrCgtyZXZpdmVfaW5mbxgFIAEoCzIWLlJv",
			"Z3VlQXZhdGFyUmV2aXZlQ29zdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueAvatarReviveCostReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueUpdateReviveInfoScNotify), ChessRogueUpdateReviveInfoScNotify.Parser, new string[]
			{
				"ReviveInfo"
			}, null, null, null, null)
		}));
	}
}
