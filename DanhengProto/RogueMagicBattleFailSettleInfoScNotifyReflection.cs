using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EB4 RID: 3764
	public static class RogueMagicBattleFailSettleInfoScNotifyReflection
	{
		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x0600A832 RID: 43058 RVA: 0x001C4E96 File Offset: 0x001C3096
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicBattleFailSettleInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040044BE RID: 17598
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CixSb2d1ZU1hZ2ljQmF0dGxlRmFpbFNldHRsZUluZm9TY05vdGlmeS5wcm90",
			"bxoaUm9ndWVNYWdpY0ZpbmlzaEluZm8ucHJvdG8aHFJvZ3VlTWFnaWNDdXJT",
			"Y2VuZUluZm8ucHJvdG8ilwEKJlJvZ3VlTWFnaWNCYXR0bGVGYWlsU2V0dGxl",
			"SW5mb1NjTm90aWZ5EjAKEXRvdXJuX2ZpbmlzaF9pbmZvGAwgASgLMhUuUm9n",
			"dWVNYWdpY0ZpbmlzaEluZm8SOwoacm9ndWVfdG91cm5fY3VyX3NjZW5lX2lu",
			"Zm8YCSABKAsyFy5Sb2d1ZU1hZ2ljQ3VyU2NlbmVJbmZvQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicFinishInfoReflection.Descriptor,
			RogueMagicCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicBattleFailSettleInfoScNotify), RogueMagicBattleFailSettleInfoScNotify.Parser, new string[]
			{
				"TournFinishInfo",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
