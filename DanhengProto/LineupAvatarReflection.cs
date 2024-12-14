using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A0E RID: 2574
	public static class LineupAvatarReflection
	{
		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06007249 RID: 29257 RVA: 0x0012FF95 File Offset: 0x0012E195
		public static FileDescriptor Descriptor
		{
			get
			{
				return LineupAvatarReflection.descriptor;
			}
		}

		// Token: 0x04002BE9 RID: 11241
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJMaW5ldXBBdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aD1NwQmFy",
			"SW5mby5wcm90byKDAQoMTGluZXVwQXZhdGFyEgwKBHNsb3QYDiABKA0SDwoH",
			"c2F0aWV0eRgCIAEoDRIaCgZzcF9iYXIYDSABKAsyCi5TcEJhckluZm8SCgoC",
			"aWQYDyABKA0SCgoCaHAYBiABKA0SIAoLYXZhdGFyX3R5cGUYCSABKA4yCy5B",
			"dmF0YXJUeXBlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LineupAvatar), LineupAvatar.Parser, new string[]
			{
				"Slot",
				"Satiety",
				"SpBar",
				"Id",
				"Hp",
				"AvatarType"
			}, null, null, null, null)
		}));
	}
}
