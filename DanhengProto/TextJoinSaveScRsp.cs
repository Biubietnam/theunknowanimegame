using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200135B RID: 4955
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TextJoinSaveScRsp : IMessage<TextJoinSaveScRsp>, IMessage, IEquatable<TextJoinSaveScRsp>, IDeepCloneable<TextJoinSaveScRsp>, IBufferMessage
	{
		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x0600DD26 RID: 56614 RVA: 0x0024CBF1 File Offset: 0x0024ADF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TextJoinSaveScRsp> Parser
		{
			get
			{
				return TextJoinSaveScRsp._parser;
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x0600DD27 RID: 56615 RVA: 0x0024CBF8 File Offset: 0x0024ADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TextJoinSaveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x0600DD28 RID: 56616 RVA: 0x0024CC0A File Offset: 0x0024AE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextJoinSaveScRsp.Descriptor;
			}
		}

		// Token: 0x0600DD29 RID: 56617 RVA: 0x0024CC11 File Offset: 0x0024AE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinSaveScRsp()
		{
		}

		// Token: 0x0600DD2A RID: 56618 RVA: 0x0024CC24 File Offset: 0x0024AE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinSaveScRsp(TextJoinSaveScRsp other) : this()
		{
			this.aINAOENMOME_ = other.aINAOENMOME_;
			this.textItemConfigId_ = other.textItemConfigId_;
			this.retcode_ = other.retcode_;
			this.textItemId_ = other.textItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD2B RID: 56619 RVA: 0x0024CC78 File Offset: 0x0024AE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinSaveScRsp Clone()
		{
			return new TextJoinSaveScRsp(this);
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x0600DD2C RID: 56620 RVA: 0x0024CC80 File Offset: 0x0024AE80
		// (set) Token: 0x0600DD2D RID: 56621 RVA: 0x0024CC88 File Offset: 0x0024AE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AINAOENMOME
		{
			get
			{
				return this.aINAOENMOME_;
			}
			set
			{
				this.aINAOENMOME_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x0600DD2E RID: 56622 RVA: 0x0024CC9B File Offset: 0x0024AE9B
		// (set) Token: 0x0600DD2F RID: 56623 RVA: 0x0024CCA3 File Offset: 0x0024AEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextItemConfigId
		{
			get
			{
				return this.textItemConfigId_;
			}
			set
			{
				this.textItemConfigId_ = value;
			}
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x0600DD30 RID: 56624 RVA: 0x0024CCAC File Offset: 0x0024AEAC
		// (set) Token: 0x0600DD31 RID: 56625 RVA: 0x0024CCB4 File Offset: 0x0024AEB4
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

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x0600DD32 RID: 56626 RVA: 0x0024CCBD File Offset: 0x0024AEBD
		// (set) Token: 0x0600DD33 RID: 56627 RVA: 0x0024CCC5 File Offset: 0x0024AEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextItemId
		{
			get
			{
				return this.textItemId_;
			}
			set
			{
				this.textItemId_ = value;
			}
		}

		// Token: 0x0600DD34 RID: 56628 RVA: 0x0024CCCE File Offset: 0x0024AECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextJoinSaveScRsp);
		}

		// Token: 0x0600DD35 RID: 56629 RVA: 0x0024CCDC File Offset: 0x0024AEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TextJoinSaveScRsp other)
		{
			return other != null && (other == this || (!(this.AINAOENMOME != other.AINAOENMOME) && this.TextItemConfigId == other.TextItemConfigId && this.Retcode == other.Retcode && this.TextItemId == other.TextItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD36 RID: 56630 RVA: 0x0024CD4C File Offset: 0x0024AF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AINAOENMOME.Length != 0)
			{
				num ^= this.AINAOENMOME.GetHashCode();
			}
			if (this.TextItemConfigId != 0U)
			{
				num ^= this.TextItemConfigId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.TextItemId != 0U)
			{
				num ^= this.TextItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD37 RID: 56631 RVA: 0x0024CDD8 File Offset: 0x0024AFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DD38 RID: 56632 RVA: 0x0024CDE0 File Offset: 0x0024AFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD39 RID: 56633 RVA: 0x0024CDEC File Offset: 0x0024AFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AINAOENMOME.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.AINAOENMOME);
			}
			if (this.TextItemId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TextItemId);
			}
			if (this.TextItemConfigId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.TextItemConfigId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD3A RID: 56634 RVA: 0x0024CE84 File Offset: 0x0024B084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AINAOENMOME.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AINAOENMOME);
			}
			if (this.TextItemConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextItemConfigId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.TextItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD3B RID: 56635 RVA: 0x0024CF10 File Offset: 0x0024B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TextJoinSaveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AINAOENMOME.Length != 0)
			{
				this.AINAOENMOME = other.AINAOENMOME;
			}
			if (other.TextItemConfigId != 0U)
			{
				this.TextItemConfigId = other.TextItemConfigId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.TextItemId != 0U)
			{
				this.TextItemId = other.TextItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD3C RID: 56636 RVA: 0x0024CF8D File Offset: 0x0024B18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD3D RID: 56637 RVA: 0x0024CF98 File Offset: 0x0024B198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 26U)
					{
						this.AINAOENMOME = input.ReadString();
						continue;
					}
					if (num == 48U)
					{
						this.TextItemId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.TextItemConfigId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040057F4 RID: 22516
		private static readonly MessageParser<TextJoinSaveScRsp> _parser = new MessageParser<TextJoinSaveScRsp>(() => new TextJoinSaveScRsp());

		// Token: 0x040057F5 RID: 22517
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057F6 RID: 22518
		public const int AINAOENMOMEFieldNumber = 3;

		// Token: 0x040057F7 RID: 22519
		private string aINAOENMOME_ = "";

		// Token: 0x040057F8 RID: 22520
		public const int TextItemConfigIdFieldNumber = 10;

		// Token: 0x040057F9 RID: 22521
		private uint textItemConfigId_;

		// Token: 0x040057FA RID: 22522
		public const int RetcodeFieldNumber = 14;

		// Token: 0x040057FB RID: 22523
		private uint retcode_;

		// Token: 0x040057FC RID: 22524
		public const int TextItemIdFieldNumber = 6;

		// Token: 0x040057FD RID: 22525
		private uint textItemId_;
	}
}
