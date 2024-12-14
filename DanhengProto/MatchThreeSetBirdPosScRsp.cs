using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AA7 RID: 2727
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchThreeSetBirdPosScRsp : IMessage<MatchThreeSetBirdPosScRsp>, IMessage, IEquatable<MatchThreeSetBirdPosScRsp>, IDeepCloneable<MatchThreeSetBirdPosScRsp>, IBufferMessage
	{
		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x060078DD RID: 30941 RVA: 0x00140615 File Offset: 0x0013E815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeSetBirdPosScRsp> Parser
		{
			get
			{
				return MatchThreeSetBirdPosScRsp._parser;
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x060078DE RID: 30942 RVA: 0x0014061C File Offset: 0x0013E81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchThreeSetBirdPosScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x060078DF RID: 30943 RVA: 0x0014062E File Offset: 0x0013E82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeSetBirdPosScRsp.Descriptor;
			}
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x00140635 File Offset: 0x0013E835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSetBirdPosScRsp()
		{
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x0014063D File Offset: 0x0013E83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSetBirdPosScRsp(MatchThreeSetBirdPosScRsp other) : this()
		{
			this.pos_ = other.pos_;
			this.retcode_ = other.retcode_;
			this.jKGBGFOPMHM_ = other.jKGBGFOPMHM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x0014067A File Offset: 0x0013E87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSetBirdPosScRsp Clone()
		{
			return new MatchThreeSetBirdPosScRsp(this);
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x060078E3 RID: 30947 RVA: 0x00140682 File Offset: 0x0013E882
		// (set) Token: 0x060078E4 RID: 30948 RVA: 0x0014068A File Offset: 0x0013E88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x060078E5 RID: 30949 RVA: 0x00140693 File Offset: 0x0013E893
		// (set) Token: 0x060078E6 RID: 30950 RVA: 0x0014069B File Offset: 0x0013E89B
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

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x060078E7 RID: 30951 RVA: 0x001406A4 File Offset: 0x0013E8A4
		// (set) Token: 0x060078E8 RID: 30952 RVA: 0x001406AC File Offset: 0x0013E8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JKGBGFOPMHM
		{
			get
			{
				return this.jKGBGFOPMHM_;
			}
			set
			{
				this.jKGBGFOPMHM_ = value;
			}
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x001406B5 File Offset: 0x0013E8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeSetBirdPosScRsp);
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x001406C4 File Offset: 0x0013E8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeSetBirdPosScRsp other)
		{
			return other != null && (other == this || (this.Pos == other.Pos && this.Retcode == other.Retcode && this.JKGBGFOPMHM == other.JKGBGFOPMHM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x00140720 File Offset: 0x0013E920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Pos != 0U)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.JKGBGFOPMHM != 0U)
			{
				num ^= this.JKGBGFOPMHM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x00140791 File Offset: 0x0013E991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x00140799 File Offset: 0x0013E999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x001407A4 File Offset: 0x0013E9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JKGBGFOPMHM != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.JKGBGFOPMHM);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Pos != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x0014081C File Offset: 0x0013EA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Pos != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Pos);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.JKGBGFOPMHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKGBGFOPMHM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x0014088C File Offset: 0x0013EA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeSetBirdPosScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Pos != 0U)
			{
				this.Pos = other.Pos;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.JKGBGFOPMHM != 0U)
			{
				this.JKGBGFOPMHM = other.JKGBGFOPMHM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x001408F0 File Offset: 0x0013EAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x001408FC File Offset: 0x0013EAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 80U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Pos = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.JKGBGFOPMHM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002E68 RID: 11880
		private static readonly MessageParser<MatchThreeSetBirdPosScRsp> _parser = new MessageParser<MatchThreeSetBirdPosScRsp>(() => new MatchThreeSetBirdPosScRsp());

		// Token: 0x04002E69 RID: 11881
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E6A RID: 11882
		public const int PosFieldNumber = 12;

		// Token: 0x04002E6B RID: 11883
		private uint pos_;

		// Token: 0x04002E6C RID: 11884
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002E6D RID: 11885
		private uint retcode_;

		// Token: 0x04002E6E RID: 11886
		public const int JKGBGFOPMHMFieldNumber = 3;

		// Token: 0x04002E6F RID: 11887
		private uint jKGBGFOPMHM_;
	}
}
