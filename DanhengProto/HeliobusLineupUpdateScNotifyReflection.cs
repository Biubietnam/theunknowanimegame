using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008C0 RID: 2240
	public static class HeliobusLineupUpdateScNotifyReflection
	{
		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x060063EA RID: 25578 RVA: 0x0010BB30 File Offset: 0x00109D30
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusLineupUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04002688 RID: 9864
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJIZWxpb2J1c0xpbmV1cFVwZGF0ZVNjTm90aWZ5LnByb3RvGh1IZWxpb2J1",
			"c0NoYWxsZW5nZUxpbmV1cC5wcm90byJIChxIZWxpb2J1c0xpbmV1cFVwZGF0",
			"ZVNjTm90aWZ5EigKBmxpbmV1cBgIIAEoCzIYLkhlbGlvYnVzQ2hhbGxlbmdl",
			"TGluZXVwQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			HeliobusChallengeLineupReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusLineupUpdateScNotify), HeliobusLineupUpdateScNotify.Parser, new string[]
			{
				"Lineup"
			}, null, null, null, null)
		}));
	}
}
