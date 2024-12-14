using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200110B RID: 4363
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetIsDisplayAvatarInfoScRsp : IMessage<SetIsDisplayAvatarInfoScRsp>, IMessage, IEquatable<SetIsDisplayAvatarInfoScRsp>, IDeepCloneable<SetIsDisplayAvatarInfoScRsp>, IBufferMessage
	{
		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600C28A RID: 49802 RVA: 0x0020A819 File Offset: 0x00208A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetIsDisplayAvatarInfoScRsp> Parser
		{
			get
			{
				return SetIsDisplayAvatarInfoScRsp._parser;
			}
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600C28B RID: 49803 RVA: 0x0020A820 File Offset: 0x00208A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetIsDisplayAvatarInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600C28C RID: 49804 RVA: 0x0020A832 File Offset: 0x00208A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetIsDisplayAvatarInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600C28D RID: 49805 RVA: 0x0020A839 File Offset: 0x00208A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetIsDisplayAvatarInfoScRsp()
		{
		}

		// Token: 0x0600C28E RID: 49806 RVA: 0x0020A841 File Offset: 0x00208A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetIsDisplayAvatarInfoScRsp(SetIsDisplayAvatarInfoScRsp other) : this()
		{
			this.isDisplay_ = other.isDisplay_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C28F RID: 49807 RVA: 0x0020A872 File Offset: 0x00208A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetIsDisplayAvatarInfoScRsp Clone()
		{
			return new SetIsDisplayAvatarInfoScRsp(this);
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600C290 RID: 49808 RVA: 0x0020A87A File Offset: 0x00208A7A
		// (set) Token: 0x0600C291 RID: 49809 RVA: 0x0020A882 File Offset: 0x00208A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDisplay
		{
			get
			{
				return this.isDisplay_;
			}
			set
			{
				this.isDisplay_ = value;
			}
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600C292 RID: 49810 RVA: 0x0020A88B File Offset: 0x00208A8B
		// (set) Token: 0x0600C293 RID: 49811 RVA: 0x0020A893 File Offset: 0x00208A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600C294 RID: 49812 RVA: 0x0020A89C File Offset: 0x00208A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetIsDisplayAvatarInfoScRsp);
		}

		// Token: 0x0600C295 RID: 49813 RVA: 0x0020A8AA File Offset: 0x00208AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetIsDisplayAvatarInfoScRsp other)
		{
			return other != null && (other == this || (this.IsDisplay == other.IsDisplay && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C296 RID: 49814 RVA: 0x0020A8E8 File Offset: 0x00208AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsDisplay)
			{
				num ^= this.IsDisplay.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C297 RID: 49815 RVA: 0x0020A940 File Offset: 0x00208B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C298 RID: 49816 RVA: 0x0020A948 File Offset: 0x00208B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C299 RID: 49817 RVA: 0x0020A954 File Offset: 0x00208B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.IsDisplay)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsDisplay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C29A RID: 49818 RVA: 0x0020A9AC File Offset: 0x00208BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsDisplay)
			{
				num += 2;
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C29B RID: 49819 RVA: 0x0020A9F8 File Offset: 0x00208BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetIsDisplayAvatarInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsDisplay)
			{
				this.IsDisplay = other.IsDisplay;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C29C RID: 49820 RVA: 0x0020AA48 File Offset: 0x00208C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x0020AA54 File Offset: 0x00208C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsDisplay = input.ReadBool();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004EAF RID: 20143
		private static readonly MessageParser<SetIsDisplayAvatarInfoScRsp> _parser = new MessageParser<SetIsDisplayAvatarInfoScRsp>(() => new SetIsDisplayAvatarInfoScRsp());

		// Token: 0x04004EB0 RID: 20144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EB1 RID: 20145
		public const int IsDisplayFieldNumber = 4;

		// Token: 0x04004EB2 RID: 20146
		private bool isDisplay_;

		// Token: 0x04004EB3 RID: 20147
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04004EB4 RID: 20148
		private uint retcode_;
	}
}
