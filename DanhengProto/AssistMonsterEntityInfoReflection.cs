using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000B4 RID: 180
	public static class AssistMonsterEntityInfoReflection
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00015E61 File Offset: 0x00014061
		public static FileDescriptor Descriptor
		{
			get
			{
				return AssistMonsterEntityInfoReflection.descriptor;
			}
		}

		// Token: 0x040002E9 RID: 745
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Bc3Npc3RNb25zdGVyRW50aXR5SW5mby5wcm90byIxChdBc3Npc3RNb25z" + "dGVyRW50aXR5SW5mbxIWCg5lbnRpdHlfaWRfbGlzdBgMIAMoDUIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AssistMonsterEntityInfo), AssistMonsterEntityInfo.Parser, new string[]
			{
				"EntityIdList"
			}, null, null, null, null)
		}));
	}
}
