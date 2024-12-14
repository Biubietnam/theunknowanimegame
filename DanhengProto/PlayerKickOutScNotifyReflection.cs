using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CC0 RID: 3264
	public static class PlayerKickOutScNotifyReflection
	{
		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x00180D4B File Offset: 0x0017EF4B
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerKickOutScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003801 RID: 14337
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtQbGF5ZXJLaWNrT3V0U2NOb3RpZnkucHJvdG8aDktpY2tUeXBlLnByb3Rv",
			"Gg9CbGFja0luZm8ucHJvdG8iVQoVUGxheWVyS2lja091dFNjTm90aWZ5Eh4K",
			"CmJsYWNrX2luZm8YDCABKAsyCi5CbGFja0luZm8SHAoJa2lja190eXBlGA4g",
			"ASgOMgkuS2lja1R5cGVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			KickTypeReflection.Descriptor,
			BlackInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerKickOutScNotify), PlayerKickOutScNotify.Parser, new string[]
			{
				"BlackInfo",
				"KickType"
			}, null, null, null, null)
		}));
	}
}
