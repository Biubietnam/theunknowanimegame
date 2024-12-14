using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FE6 RID: 4070
	public static class RogueTournLeaveRogueCocoonSceneScRspReflection
	{
		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600B52E RID: 46382 RVA: 0x001E648E File Offset: 0x001E468E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournLeaveRogueCocoonSceneScRspReflection.descriptor;
			}
		}

		// Token: 0x0400497B RID: 18811
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipSb2d1ZVRvdXJuTGVhdmVSb2d1ZUNvY29vblNjZW5lU2NSc3AucHJvdG8a",
			"HFJvZ3VlVG91cm5DdXJTY2VuZUluZm8ucHJvdG8idAokUm9ndWVUb3Vybkxl",
			"YXZlUm9ndWVDb2Nvb25TY2VuZVNjUnNwEg8KB3JldGNvZGUYAiABKA0SOwoa",
			"cm9ndWVfdG91cm5fY3VyX3NjZW5lX2luZm8YASABKAsyFy5Sb2d1ZVRvdXJu",
			"Q3VyU2NlbmVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLeaveRogueCocoonSceneScRsp), RogueTournLeaveRogueCocoonSceneScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
