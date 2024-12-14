using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F8A RID: 3978
	public static class RogueTournCurAreaInfoReflection
	{
		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600B133 RID: 45363 RVA: 0x001DC09B File Offset: 0x001DA29B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournCurAreaInfoReflection.descriptor;
			}
		}

		// Token: 0x04004815 RID: 18453
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtSb2d1ZVRvdXJuQ3VyQXJlYUluZm8ucHJvdG8aHlJvZ3VlQ29tbW9uUGVu",
			"ZGluZ0FjdGlvbi5wcm90byKuAQoVUm9ndWVUb3VybkN1ckFyZWFJbmZvEiAK",
			"GHJvZ3VlX21hZ2ljX2JhdHRsZV9jb25zdBgBIAEoDRITCgtzdWJfYXJlYV9p",
			"ZBgMIAEoDRITCgtJSEtITkVHQkVMRRgFIAEoDRIWCg5yb2d1ZV9zdWJfbW9k",
			"ZRgIIAEoDRIxCg5wZW5kaW5nX2FjdGlvbhgEIAEoCzIZLlJvZ3VlQ29tbW9u",
			"UGVuZGluZ0FjdGlvbkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueCommonPendingActionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournCurAreaInfo), RogueTournCurAreaInfo.Parser, new string[]
			{
				"RogueMagicBattleConst",
				"SubAreaId",
				"IHKHNEGBELE",
				"RogueSubMode",
				"PendingAction"
			}, null, null, null, null)
		}));
	}
}
