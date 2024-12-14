using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F82 RID: 3970
	public static class RogueTournBattleFailSettleInfoScNotifyReflection
	{
		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600B0D1 RID: 45265 RVA: 0x001DAF6C File Offset: 0x001D916C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournBattleFailSettleInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040047F3 RID: 18419
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CixSb2d1ZVRvdXJuQmF0dGxlRmFpbFNldHRsZUluZm9TY05vdGlmeS5wcm90",
			"bxoaUm9ndWVUb3VybkZpbmlzaEluZm8ucHJvdG8aHFJvZ3VlVG91cm5DdXJT",
			"Y2VuZUluZm8ucHJvdG8ilwEKJlJvZ3VlVG91cm5CYXR0bGVGYWlsU2V0dGxl",
			"SW5mb1NjTm90aWZ5EjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9pbmZvGAYg",
			"ASgLMhcuUm9ndWVUb3VybkN1clNjZW5lSW5mbxIwChF0b3Vybl9maW5pc2hf",
			"aW5mbxgFIAEoCzIVLlJvZ3VlVG91cm5GaW5pc2hJbmZvQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueTournFinishInfoReflection.Descriptor,
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournBattleFailSettleInfoScNotify), RogueTournBattleFailSettleInfoScNotify.Parser, new string[]
			{
				"RogueTournCurSceneInfo",
				"TournFinishInfo"
			}, null, null, null, null)
		}));
	}
}
