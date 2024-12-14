using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013A0 RID: 5024
	public static class TrialActivityDataChangeScNotifyReflection
	{
		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x0600E04B RID: 57419 RVA: 0x002556B5 File Offset: 0x002538B5
		public static FileDescriptor Descriptor
		{
			get
			{
				return TrialActivityDataChangeScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005958 RID: 22872
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVUcmlhbEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhdUcmlh",
			"bEFjdGl2aXR5SW5mby5wcm90byJSCh9UcmlhbEFjdGl2aXR5RGF0YUNoYW5n",
			"ZVNjTm90aWZ5Ei8KE3RyaWFsX2FjdGl2aXR5X2luZm8YCiABKAsyEi5Ucmlh",
			"bEFjdGl2aXR5SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			TrialActivityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TrialActivityDataChangeScNotify), TrialActivityDataChangeScNotify.Parser, new string[]
			{
				"TrialActivityInfo"
			}, null, null, null, null)
		}));
	}
}
