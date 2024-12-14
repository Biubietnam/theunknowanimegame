using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FA8 RID: 4008
	public static class RogueTournEnterRogueCocoonSceneScRspReflection
	{
		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x001DFEF2 File Offset: 0x001DE0F2
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterRogueCocoonSceneScRspReflection.descriptor;
			}
		}

		// Token: 0x04004896 RID: 18582
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipSb2d1ZVRvdXJuRW50ZXJSb2d1ZUNvY29vblNjZW5lU2NSc3AucHJvdG8a",
			"HFJvZ3VlVG91cm5DdXJTY2VuZUluZm8ucHJvdG8idAokUm9ndWVUb3VybkVu",
			"dGVyUm9ndWVDb2Nvb25TY2VuZVNjUnNwEg8KB3JldGNvZGUYCSABKA0SOwoa",
			"cm9ndWVfdG91cm5fY3VyX3NjZW5lX2luZm8YDyABKAsyFy5Sb2d1ZVRvdXJu",
			"Q3VyU2NlbmVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterRogueCocoonSceneScRsp), RogueTournEnterRogueCocoonSceneScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
