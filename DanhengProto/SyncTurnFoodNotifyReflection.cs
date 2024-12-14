using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A8 RID: 4776
	public static class SyncTurnFoodNotifyReflection
	{
		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0600D514 RID: 54548 RVA: 0x00238BE9 File Offset: 0x00236DE9
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncTurnFoodNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005531 RID: 21809
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTeW5jVHVybkZvb2ROb3RpZnkucHJvdG8aFFR1cm5Gb29kU3dpdGNoLnBy" + "b3RvIk8KElN5bmNUdXJuRm9vZE5vdGlmeRIkCgtJQkxQSE9QT0VPSxgFIAMo" + "DjIPLlR1cm5Gb29kU3dpdGNoEhMKC0RIREpJSU9JUEtIGAogAygNQh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			TurnFoodSwitchReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncTurnFoodNotify), SyncTurnFoodNotify.Parser, new string[]
			{
				"IBLPHOPOEOK",
				"DHDJIIOIPKH"
			}, null, null, null, null)
		}));
	}
}
