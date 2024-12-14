using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A12 RID: 2578
	public static class LineupInfoReflection
	{
		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x00130A04 File Offset: 0x0012EC04
		public static FileDescriptor Descriptor
		{
			get
			{
				return LineupInfoReflection.descriptor;
			}
		}

		// Token: 0x04002C01 RID: 11265
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChBMaW5ldXBJbmZvLnByb3RvGhVFeHRyYUxpbmV1cFR5cGUucHJvdG8aEkxp",
			"bmV1cEF2YXRhci5wcm90byLPAgoKTGluZXVwSW5mbxISCgppc192aXJ0dWFs",
			"GA0gASgIEhMKC0dBTkxOREJOSExEGAIgASgIEiEKGXN0b3J5X2xpbmVfYXZh",
			"dGFyX2lkX2xpc3QYDiADKA0SCgoCbXAYDyABKA0SIgoLYXZhdGFyX2xpc3QY",
			"BCADKAsyDS5MaW5ldXBBdmF0YXISGgoSZ2FtZV9zdG9yeV9saW5lX2lkGAYg",
			"ASgNEg0KBWluZGV4GAogASgNEisKEWV4dHJhX2xpbmV1cF90eXBlGAMgASgO",
			"MhAuRXh0cmFMaW5ldXBUeXBlEhMKC2xlYWRlcl9zbG90GAwgASgNEhMKC0dH",
			"SENCUEJFRkZKGAggAygNEgwKBG5hbWUYByABKAkSEwoLS0JFT0tFRE5FTkUY",
			"ASADKA0SEAoIcGxhbmVfaWQYCSABKA0SDgoGbWF4X21wGAUgASgNQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ExtraLineupTypeReflection.Descriptor,
			LineupAvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LineupInfo), LineupInfo.Parser, new string[]
			{
				"IsVirtual",
				"GANLNDBNHLD",
				"StoryLineAvatarIdList",
				"Mp",
				"AvatarList",
				"GameStoryLineId",
				"Index",
				"ExtraLineupType",
				"LeaderSlot",
				"GGHCBPBEFFJ",
				"Name",
				"KBEOKEDNENE",
				"PlaneId",
				"MaxMp"
			}, null, null, null, null)
		}));
	}
}
