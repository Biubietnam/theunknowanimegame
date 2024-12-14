using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C2C RID: 3116
	public static class NpcDialogueEventParamReflection
	{
		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x06008A1B RID: 35355 RVA: 0x0016CAED File Offset: 0x0016ACED
		public static FileDescriptor Descriptor
		{
			get
			{
				return NpcDialogueEventParamReflection.descriptor;
			}
		}

		// Token: 0x040034F8 RID: 13560
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtOcGNEaWFsb2d1ZUV2ZW50UGFyYW0ucHJvdG8iSAoVTnBjRGlhbG9ndWVF" + "dmVudFBhcmFtEh8KF3JvZ3VlX2RpYWxvZ3VlX2V2ZW50X2lkGAkgASgNEg4K" + "BmFyZ19pZBgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NpcDialogueEventParam), NpcDialogueEventParam.Parser, new string[]
			{
				"RogueDialogueEventId",
				"ArgId"
			}, null, null, null, null)
		}));
	}
}
