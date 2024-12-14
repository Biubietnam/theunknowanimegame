using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FF2 RID: 4082
	public static class RogueTournLineupInfoReflection
	{
		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600B5AE RID: 46510 RVA: 0x001E7C13 File Offset: 0x001E5E13
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournLineupInfoReflection.descriptor;
			}
		}

		// Token: 0x040049B5 RID: 18869
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZVRvdXJuTGluZXVwSW5mby5wcm90bxoSSXRlbUNvc3REYXRhLnBy" + "b3RvIlgKFFJvZ3VlVG91cm5MaW5ldXBJbmZvEigKEXJvZ3VlX3Jldml2ZV9j" + "b3N0GAsgASgLMg0uSXRlbUNvc3REYXRhEhYKDmF2YXRhcl9pZF9saXN0GAQg" + "AygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLineupInfo), RogueTournLineupInfo.Parser, new string[]
			{
				"RogueReviveCost",
				"AvatarIdList"
			}, null, null, null, null)
		}));
	}
}
