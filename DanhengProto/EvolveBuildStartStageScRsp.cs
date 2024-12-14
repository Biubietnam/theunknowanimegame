using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004CB RID: 1227
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildStartStageScRsp : IMessage<EvolveBuildStartStageScRsp>, IMessage, IEquatable<EvolveBuildStartStageScRsp>, IDeepCloneable<EvolveBuildStartStageScRsp>, IBufferMessage
	{
		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00096B5B File Offset: 0x00094D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildStartStageScRsp> Parser
		{
			get
			{
				return EvolveBuildStartStageScRsp._parser;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x00096B62 File Offset: 0x00094D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildStartStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x00096B74 File Offset: 0x00094D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildStartStageScRsp.Descriptor;
			}
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00096B7B File Offset: 0x00094D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartStageScRsp()
		{
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00096B84 File Offset: 0x00094D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartStageScRsp(EvolveBuildStartStageScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.kFPDPBBAOPL_ = ((other.kFPDPBBAOPL_ != null) ? other.kFPDPBBAOPL_.Clone() : null);
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00096BEC File Offset: 0x00094DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartStageScRsp Clone()
		{
			return new EvolveBuildStartStageScRsp(this);
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x00096BF4 File Offset: 0x00094DF4
		// (set) Token: 0x060036E1 RID: 14049 RVA: 0x00096BFC File Offset: 0x00094DFC
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

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x00096C05 File Offset: 0x00094E05
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x00096C0D File Offset: 0x00094E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo KFPDPBBAOPL
		{
			get
			{
				return this.kFPDPBBAOPL_;
			}
			set
			{
				this.kFPDPBBAOPL_ = value;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x060036E4 RID: 14052 RVA: 0x00096C16 File Offset: 0x00094E16
		// (set) Token: 0x060036E5 RID: 14053 RVA: 0x00096C1E File Offset: 0x00094E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00096C27 File Offset: 0x00094E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildStartStageScRsp);
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00096C38 File Offset: 0x00094E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildStartStageScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.KFPDPBBAOPL, other.KFPDPBBAOPL) && object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x00096C9C File Offset: 0x00094E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.kFPDPBBAOPL_ != null)
			{
				num ^= this.KFPDPBBAOPL.GetHashCode();
			}
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00096D07 File Offset: 0x00094F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00096D0F File Offset: 0x00094F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00096D18 File Offset: 0x00094F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.kFPDPBBAOPL_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.KFPDPBBAOPL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00096D90 File Offset: 0x00094F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.kFPDPBBAOPL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KFPDPBBAOPL);
			}
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00096E00 File Offset: 0x00095000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildStartStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.kFPDPBBAOPL_ != null)
			{
				if (this.kFPDPBBAOPL_ == null)
				{
					this.KFPDPBBAOPL = new SceneBattleInfo();
				}
				this.KFPDPBBAOPL.MergeFrom(other.KFPDPBBAOPL);
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new EvolveBuildLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00096E94 File Offset: 0x00095094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00096EA0 File Offset: 0x000950A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 58U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.kFPDPBBAOPL_ == null)
							{
								this.KFPDPBBAOPL = new SceneBattleInfo();
							}
							input.ReadMessage(this.KFPDPBBAOPL);
						}
					}
					else
					{
						if (this.levelInfo_ == null)
						{
							this.LevelInfo = new EvolveBuildLevelInfo();
						}
						input.ReadMessage(this.LevelInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015C9 RID: 5577
		private static readonly MessageParser<EvolveBuildStartStageScRsp> _parser = new MessageParser<EvolveBuildStartStageScRsp>(() => new EvolveBuildStartStageScRsp());

		// Token: 0x040015CA RID: 5578
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015CB RID: 5579
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040015CC RID: 5580
		private uint retcode_;

		// Token: 0x040015CD RID: 5581
		public const int KFPDPBBAOPLFieldNumber = 10;

		// Token: 0x040015CE RID: 5582
		private SceneBattleInfo kFPDPBBAOPL_;

		// Token: 0x040015CF RID: 5583
		public const int LevelInfoFieldNumber = 7;

		// Token: 0x040015D0 RID: 5584
		private EvolveBuildLevelInfo levelInfo_;
	}
}
