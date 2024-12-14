using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200016C RID: 364
	public static class CBDOEBJHECHReflection
	{
		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0002F052 File Offset: 0x0002D252
		public static FileDescriptor Descriptor
		{
			get
			{
				return CBDOEBJHECHReflection.descriptor;
			}
		}

		// Token: 0x040006D5 RID: 1749
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFDQkRPRUJKSEVDSC5wcm90bxocUm9ndWVNYWdpY0dhbWVVbml0SW5mby5w",
			"cm90byJaCgtDQkRPRUJKSEVDSBIWCg5zZWxlY3RfaGludF9pZBgKIAEoDRIz",
			"ChJzZWxlY3RfbWFnaWNfdW5pdHMYCyADKAsyFy5Sb2d1ZU1hZ2ljR2FtZVVu",
			"aXRJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			RogueMagicGameUnitInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CBDOEBJHECH), CBDOEBJHECH.Parser, new string[]
			{
				"SelectHintId",
				"SelectMagicUnits"
			}, null, null, null, null)
		}));
	}
}
