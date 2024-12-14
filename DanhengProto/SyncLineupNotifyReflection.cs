using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001276 RID: 4726
	public static class SyncLineupNotifyReflection
	{
		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0600D2FB RID: 54011 RVA: 0x0023389B File Offset: 0x00231A9B
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncLineupNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400547D RID: 21629
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZTeW5jTGluZXVwTm90aWZ5LnByb3RvGhZTeW5jTGluZXVwUmVhc29uLnBy",
			"b3RvGhBMaW5ldXBJbmZvLnByb3RvIlYKEFN5bmNMaW5ldXBOb3RpZnkSJQoK",
			"UmVhc29uTGlzdBgBIAMoDjIRLlN5bmNMaW5ldXBSZWFzb24SGwoGTGluZXVw",
			"GA4gASgLMgsuTGluZXVwSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SyncLineupReasonReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncLineupNotify), SyncLineupNotify.Parser, new string[]
			{
				"ReasonList",
				"Lineup"
			}, null, null, null, null)
		}));
	}
}
