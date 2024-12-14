using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D20 RID: 3360
	public static class PunkLordBattleReplayReflection
	{
		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x06009618 RID: 38424 RVA: 0x0018F2C8 File Offset: 0x0018D4C8
		public static FileDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleReplayReflection.descriptor;
			}
		}

		// Token: 0x04003A36 RID: 14902
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQdW5rTG9yZEJhdHRsZVJlcGxheS5wcm90bxoQUmVwbGF5SW5mby5wcm90" + "byJSChRQdW5rTG9yZEJhdHRsZVJlcGxheRIZChFiYXR0bGVfcmVwbGF5X2tl" + "eRgBIAEoCRIfCgpSZXBsYXlJbmZvGAIgASgLMgsuUmVwbGF5SW5mb0IeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ReplayInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordBattleReplay), PunkLordBattleReplay.Parser, new string[]
			{
				"BattleReplayKey",
				"ReplayInfo"
			}, null, null, null, null)
		}));
	}
}
