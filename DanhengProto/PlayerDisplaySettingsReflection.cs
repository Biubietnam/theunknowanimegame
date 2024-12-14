using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB6 RID: 3254
	public static class PlayerDisplaySettingsReflection
	{
		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x060090D6 RID: 37078 RVA: 0x0017F248 File Offset: 0x0017D448
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerDisplaySettingsReflection.descriptor;
			}
		}

		// Token: 0x040037C5 RID: 14277
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtQbGF5ZXJEaXNwbGF5U2V0dGluZ3MucHJvdG8aEUdISE5PTk5LQ0tKLnBy",
			"b3RvGhFCRkFNR01LQ1BMTi5wcm90byJgChVQbGF5ZXJEaXNwbGF5U2V0dGlu",
			"Z3MSIQoLQURBUEtQSktPSk0YCyABKAsyDC5CRkFNR01LQ1BMThIkCg5jaGFs",
			"bGVuZ2VfbGlzdBgNIAMoCzIMLkdISE5PTk5LQ0tKQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			GHHNONNKCKJReflection.Descriptor,
			BFAMGMKCPLNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerDisplaySettings), PlayerDisplaySettings.Parser, new string[]
			{
				"ADAPKPJKOJM",
				"ChallengeList"
			}, null, null, null, null)
		}));
	}
}
