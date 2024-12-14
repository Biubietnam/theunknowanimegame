using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F7A RID: 3962
	public static class RogueTalentInfoListReflection
	{
		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600B08B RID: 45195 RVA: 0x001DA4A9 File Offset: 0x001D86A9
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTalentInfoListReflection.descriptor;
			}
		}

		// Token: 0x040047D4 RID: 18388
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlSb2d1ZVRhbGVudEluZm9MaXN0LnByb3RvGhVSb2d1ZVRhbGVudEluZm8u" + "cHJvdG8iPAoTUm9ndWVUYWxlbnRJbmZvTGlzdBIlCgt0YWxlbnRfaW5mbxgI" + "IAMoCzIQLlJvZ3VlVGFsZW50SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RogueTalentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTalentInfoList), RogueTalentInfoList.Parser, new string[]
			{
				"TalentInfo"
			}, null, null, null, null)
		}));
	}
}
