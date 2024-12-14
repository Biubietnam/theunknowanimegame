using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D5E RID: 3422
	public static class RacingDataReflection
	{
		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x060098EE RID: 39150 RVA: 0x0019729C File Offset: 0x0019549C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RacingDataReflection.descriptor;
			}
		}

		// Token: 0x04003B64 RID: 15204
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChBSYWNpbmdEYXRhLnByb3RvGhVNb3ZpZVJhY2luZ1R5cGUucHJvdG8iZQoK",
			"UmFjaW5nRGF0YRIeCgR0eXBlGA4gASgOMhAuTW92aWVSYWNpbmdUeXBlEg0K",
			"BWxldmVsGAYgASgNEhMKC09LS1BJREhNQ0lQGAogASgNEhMKC0xGTkNQTU1I",
			"TENPGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			MovieRacingTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RacingData), RacingData.Parser, new string[]
			{
				"Type",
				"Level",
				"OKKPIDHMCIP",
				"LFNCPMMHLCO"
			}, null, null, null, null)
		}));
	}
}
