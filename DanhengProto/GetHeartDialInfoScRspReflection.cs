using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006E6 RID: 1766
	public static class GetHeartDialInfoScRspReflection
	{
		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06004F05 RID: 20229 RVA: 0x000D5842 File Offset: 0x000D3A42
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetHeartDialInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F28 RID: 7976
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRIZWFydERpYWxJbmZvU2NSc3AucHJvdG8aEUtHSEZKUEVHQk5MLnBy",
			"b3RvGhlIZWFydERpYWxTY3JpcHRJbmZvLnByb3RvGhtIZWFydERpYWxEaWFs",
			"b2d1ZUluZm8ucHJvdG8aG0hlYXJ0RGlhbFVubG9ja1N0YXR1cy5wcm90byLe",
			"AQoVR2V0SGVhcnREaWFsSW5mb1NjUnNwEi4KEHNjcmlwdF9pbmZvX2xpc3QY",
			"BiADKAsyFC5IZWFydERpYWxTY3JpcHRJbmZvEg8KB3JldGNvZGUYASABKA0S",
			"LQoNdW5sb2NrX3N0YXR1cxgKIAEoDjIWLkhlYXJ0RGlhbFVubG9ja1N0YXR1",
			"cxIyChJkaWFsb2d1ZV9pbmZvX2xpc3QYDCADKAsyFi5IZWFydERpYWxEaWFs",
			"b2d1ZUluZm8SIQoLTkRLSk9QTExEUEgYAyADKAsyDC5LR0hGSlBFR0JOTEIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			KGHFJPEGBNLReflection.Descriptor,
			HeartDialScriptInfoReflection.Descriptor,
			HeartDialDialogueInfoReflection.Descriptor,
			HeartDialUnlockStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetHeartDialInfoScRsp), GetHeartDialInfoScRsp.Parser, new string[]
			{
				"ScriptInfoList",
				"Retcode",
				"UnlockStatus",
				"DialogueInfoList",
				"NDKJOPLLDPH"
			}, null, null, null, null)
		}));
	}
}
