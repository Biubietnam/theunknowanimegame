using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200053A RID: 1338
	public static class FightKickOutScNotifyReflection
	{
		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x000A4210 File Offset: 0x000A2410
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightKickOutScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04001807 RID: 6151
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpGaWdodEtpY2tPdXRTY05vdGlmeS5wcm90bxoWRmlnaHRLaWNrb3V0VHlw" + "ZS5wcm90byI8ChRGaWdodEtpY2tPdXRTY05vdGlmeRIkCglraWNrX3R5cGUY" + "DCABKA4yES5GaWdodEtpY2tvdXRUeXBlQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			FightKickoutTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightKickOutScNotify), FightKickOutScNotify.Parser, new string[]
			{
				"KickType"
			}, null, null, null, null)
		}));
	}
}
