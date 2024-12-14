using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EE4 RID: 3812
	public static class RogueMagicGetTalentInfoScRspReflection
	{
		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x0600AA6F RID: 43631 RVA: 0x001CB26A File Offset: 0x001C946A
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicGetTalentInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04004591 RID: 17809
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSb2d1ZU1hZ2ljR2V0VGFsZW50SW5mb1NjUnNwLnByb3RvGhpSb2d1ZU1h",
			"Z2ljVGFsZW50SW5mby5wcm90byJnChxSb2d1ZU1hZ2ljR2V0VGFsZW50SW5m",
			"b1NjUnNwEjYKF3JvZ3VlX21hZ2ljX3RhbGVudF9pbmZvGAwgASgLMhUuUm9n",
			"dWVNYWdpY1RhbGVudEluZm8SDwoHcmV0Y29kZRgDIAEoDUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicTalentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGetTalentInfoScRsp), RogueMagicGetTalentInfoScRsp.Parser, new string[]
			{
				"RogueMagicTalentInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
