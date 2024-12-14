using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013C5 RID: 5061
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockPhoneThemeScNotify : IMessage<UnlockPhoneThemeScNotify>, IMessage, IEquatable<UnlockPhoneThemeScNotify>, IDeepCloneable<UnlockPhoneThemeScNotify>, IBufferMessage
	{
		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x0600E19A RID: 57754 RVA: 0x002584EC File Offset: 0x002566EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockPhoneThemeScNotify> Parser
		{
			get
			{
				return UnlockPhoneThemeScNotify._parser;
			}
		}

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x0600E19B RID: 57755 RVA: 0x002584F3 File Offset: 0x002566F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockPhoneThemeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x0600E19C RID: 57756 RVA: 0x00258505 File Offset: 0x00256705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockPhoneThemeScNotify.Descriptor;
			}
		}

		// Token: 0x0600E19D RID: 57757 RVA: 0x0025850C File Offset: 0x0025670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockPhoneThemeScNotify()
		{
		}

		// Token: 0x0600E19E RID: 57758 RVA: 0x00258514 File Offset: 0x00256714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockPhoneThemeScNotify(UnlockPhoneThemeScNotify other) : this()
		{
			this.themeId_ = other.themeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E19F RID: 57759 RVA: 0x00258539 File Offset: 0x00256739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockPhoneThemeScNotify Clone()
		{
			return new UnlockPhoneThemeScNotify(this);
		}

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x0600E1A0 RID: 57760 RVA: 0x00258541 File Offset: 0x00256741
		// (set) Token: 0x0600E1A1 RID: 57761 RVA: 0x00258549 File Offset: 0x00256749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ThemeId
		{
			get
			{
				return this.themeId_;
			}
			set
			{
				this.themeId_ = value;
			}
		}

		// Token: 0x0600E1A2 RID: 57762 RVA: 0x00258552 File Offset: 0x00256752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockPhoneThemeScNotify);
		}

		// Token: 0x0600E1A3 RID: 57763 RVA: 0x00258560 File Offset: 0x00256760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockPhoneThemeScNotify other)
		{
			return other != null && (other == this || (this.ThemeId == other.ThemeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1A4 RID: 57764 RVA: 0x00258590 File Offset: 0x00256790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ThemeId != 0U)
			{
				num ^= this.ThemeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E1A5 RID: 57765 RVA: 0x002585CF File Offset: 0x002567CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E1A6 RID: 57766 RVA: 0x002585D7 File Offset: 0x002567D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1A7 RID: 57767 RVA: 0x002585E0 File Offset: 0x002567E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ThemeId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ThemeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1A8 RID: 57768 RVA: 0x00258614 File Offset: 0x00256814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ThemeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ThemeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E1A9 RID: 57769 RVA: 0x00258652 File Offset: 0x00256852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockPhoneThemeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ThemeId != 0U)
			{
				this.ThemeId = other.ThemeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E1AA RID: 57770 RVA: 0x00258683 File Offset: 0x00256883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1AB RID: 57771 RVA: 0x0025868C File Offset: 0x0025688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ThemeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059CA RID: 22986
		private static readonly MessageParser<UnlockPhoneThemeScNotify> _parser = new MessageParser<UnlockPhoneThemeScNotify>(() => new UnlockPhoneThemeScNotify());

		// Token: 0x040059CB RID: 22987
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059CC RID: 22988
		public const int ThemeIdFieldNumber = 7;

		// Token: 0x040059CD RID: 22989
		private uint themeId_;
	}
}
