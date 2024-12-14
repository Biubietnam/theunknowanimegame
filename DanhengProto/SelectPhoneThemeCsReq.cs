using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010AF RID: 4271
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SelectPhoneThemeCsReq : IMessage<SelectPhoneThemeCsReq>, IMessage, IEquatable<SelectPhoneThemeCsReq>, IDeepCloneable<SelectPhoneThemeCsReq>, IBufferMessage
	{
		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600BE6B RID: 48747 RVA: 0x00200EA4 File Offset: 0x001FF0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SelectPhoneThemeCsReq> Parser
		{
			get
			{
				return SelectPhoneThemeCsReq._parser;
			}
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0600BE6C RID: 48748 RVA: 0x00200EAB File Offset: 0x001FF0AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SelectPhoneThemeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0600BE6D RID: 48749 RVA: 0x00200EBD File Offset: 0x001FF0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectPhoneThemeCsReq.Descriptor;
			}
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x00200EC4 File Offset: 0x001FF0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectPhoneThemeCsReq()
		{
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x00200ECC File Offset: 0x001FF0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectPhoneThemeCsReq(SelectPhoneThemeCsReq other) : this()
		{
			this.themeId_ = other.themeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE70 RID: 48752 RVA: 0x00200EF1 File Offset: 0x001FF0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectPhoneThemeCsReq Clone()
		{
			return new SelectPhoneThemeCsReq(this);
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0600BE71 RID: 48753 RVA: 0x00200EF9 File Offset: 0x001FF0F9
		// (set) Token: 0x0600BE72 RID: 48754 RVA: 0x00200F01 File Offset: 0x001FF101
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

		// Token: 0x0600BE73 RID: 48755 RVA: 0x00200F0A File Offset: 0x001FF10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectPhoneThemeCsReq);
		}

		// Token: 0x0600BE74 RID: 48756 RVA: 0x00200F18 File Offset: 0x001FF118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectPhoneThemeCsReq other)
		{
			return other != null && (other == this || (this.ThemeId == other.ThemeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE75 RID: 48757 RVA: 0x00200F48 File Offset: 0x001FF148
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

		// Token: 0x0600BE76 RID: 48758 RVA: 0x00200F87 File Offset: 0x001FF187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BE77 RID: 48759 RVA: 0x00200F8F File Offset: 0x001FF18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE78 RID: 48760 RVA: 0x00200F98 File Offset: 0x001FF198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ThemeId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ThemeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE79 RID: 48761 RVA: 0x00200FCC File Offset: 0x001FF1CC
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

		// Token: 0x0600BE7A RID: 48762 RVA: 0x0020100A File Offset: 0x001FF20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectPhoneThemeCsReq other)
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

		// Token: 0x0600BE7B RID: 48763 RVA: 0x0020103B File Offset: 0x001FF23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE7C RID: 48764 RVA: 0x00201044 File Offset: 0x001FF244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ThemeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D5E RID: 19806
		private static readonly MessageParser<SelectPhoneThemeCsReq> _parser = new MessageParser<SelectPhoneThemeCsReq>(() => new SelectPhoneThemeCsReq());

		// Token: 0x04004D5F RID: 19807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D60 RID: 19808
		public const int ThemeIdFieldNumber = 8;

		// Token: 0x04004D61 RID: 19809
		private uint themeId_;
	}
}
