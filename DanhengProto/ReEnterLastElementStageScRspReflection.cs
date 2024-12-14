using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D8E RID: 3470
	public static class ReEnterLastElementStageScRspReflection
	{
		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x06009AF4 RID: 39668 RVA: 0x0019C26E File Offset: 0x0019A46E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReEnterLastElementStageScRspReflection.descriptor;
			}
		}

		// Token: 0x04003C1D RID: 15389
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSZUVudGVyTGFzdEVsZW1lbnRTdGFnZVNjUnNwLnByb3RvGhVTY2VuZUJh",
			"dHRsZUluZm8ucHJvdG8iaAocUmVFbnRlckxhc3RFbGVtZW50U3RhZ2VTY1Jz",
			"cBIlCgtiYXR0bGVfaW5mbxgJIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIPCgdy",
			"ZXRjb2RlGA4gASgNEhAKCHN0YWdlX2lkGAogASgNQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ReEnterLastElementStageScRsp), ReEnterLastElementStageScRsp.Parser, new string[]
			{
				"BattleInfo",
				"Retcode",
				"StageId"
			}, null, null, null, null)
		}));
	}
}
