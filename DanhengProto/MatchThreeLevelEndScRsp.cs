using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AA3 RID: 2723
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchThreeLevelEndScRsp : IMessage<MatchThreeLevelEndScRsp>, IMessage, IEquatable<MatchThreeLevelEndScRsp>, IDeepCloneable<MatchThreeLevelEndScRsp>, IBufferMessage
	{
		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x060078AD RID: 30893 RVA: 0x0013FEED File Offset: 0x0013E0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeLevelEndScRsp> Parser
		{
			get
			{
				return MatchThreeLevelEndScRsp._parser;
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x060078AE RID: 30894 RVA: 0x0013FEF4 File Offset: 0x0013E0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchThreeLevelEndScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x060078AF RID: 30895 RVA: 0x0013FF06 File Offset: 0x0013E106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeLevelEndScRsp.Descriptor;
			}
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x0013FF0D File Offset: 0x0013E10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelEndScRsp()
		{
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x0013FF15 File Offset: 0x0013E115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelEndScRsp(MatchThreeLevelEndScRsp other) : this()
		{
			this.levelId_ = other.levelId_;
			this.retcode_ = other.retcode_;
			this.kIFPFCDEAAE_ = other.kIFPFCDEAAE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x0013FF52 File Offset: 0x0013E152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeLevelEndScRsp Clone()
		{
			return new MatchThreeLevelEndScRsp(this);
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x0013FF5A File Offset: 0x0013E15A
		// (set) Token: 0x060078B4 RID: 30900 RVA: 0x0013FF62 File Offset: 0x0013E162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x060078B5 RID: 30901 RVA: 0x0013FF6B File Offset: 0x0013E16B
		// (set) Token: 0x060078B6 RID: 30902 RVA: 0x0013FF73 File Offset: 0x0013E173
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

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x060078B7 RID: 30903 RVA: 0x0013FF7C File Offset: 0x0013E17C
		// (set) Token: 0x060078B8 RID: 30904 RVA: 0x0013FF84 File Offset: 0x0013E184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KIFPFCDEAAE
		{
			get
			{
				return this.kIFPFCDEAAE_;
			}
			set
			{
				this.kIFPFCDEAAE_ = value;
			}
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x0013FF8D File Offset: 0x0013E18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeLevelEndScRsp);
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x0013FF9C File Offset: 0x0013E19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeLevelEndScRsp other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Retcode == other.Retcode && this.KIFPFCDEAAE == other.KIFPFCDEAAE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x0013FFF8 File Offset: 0x0013E1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.KIFPFCDEAAE != 0U)
			{
				num ^= this.KIFPFCDEAAE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x00140069 File Offset: 0x0013E269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x00140071 File Offset: 0x0013E271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x0014007C File Offset: 0x0013E27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.LevelId);
			}
			if (this.KIFPFCDEAAE != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.KIFPFCDEAAE);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078BF RID: 30911 RVA: 0x001400F4 File Offset: 0x0013E2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.KIFPFCDEAAE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KIFPFCDEAAE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x00140164 File Offset: 0x0013E364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeLevelEndScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.KIFPFCDEAAE != 0U)
			{
				this.KIFPFCDEAAE = other.KIFPFCDEAAE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x001401C8 File Offset: 0x0013E3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078C2 RID: 30914 RVA: 0x001401D4 File Offset: 0x0013E3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 80U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.KIFPFCDEAAE = input.ReadUInt32();
					}
				}
				else
				{
					this.LevelId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002E58 RID: 11864
		private static readonly MessageParser<MatchThreeLevelEndScRsp> _parser = new MessageParser<MatchThreeLevelEndScRsp>(() => new MatchThreeLevelEndScRsp());

		// Token: 0x04002E59 RID: 11865
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E5A RID: 11866
		public const int LevelIdFieldNumber = 7;

		// Token: 0x04002E5B RID: 11867
		private uint levelId_;

		// Token: 0x04002E5C RID: 11868
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04002E5D RID: 11869
		private uint retcode_;

		// Token: 0x04002E5E RID: 11870
		public const int KIFPFCDEAAEFieldNumber = 10;

		// Token: 0x04002E5F RID: 11871
		private uint kIFPFCDEAAE_;
	}
}
